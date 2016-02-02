using System.Windows.Forms;

namespace SelskapOgBursdagsPlanlegger
{
    internal class BirthdayParty : Party
    {
        private const int DagensKurs = 9;
        public int CakeSize;

        private string _cakeWriting = "";
        private string _toManyLetters = "Too many letters for a";
        private string _inchCake = "inch cake";

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
            : base(numberOfPeople, fancyDecorations)
        {
            CalculateCakeSize();
            CakeWriting = cakeWriting;
            CalculateCostOfDecorations(fancyDecorations);
        }

        public string CakeWriting
        {
            get { return _cakeWriting; }
            set
            {
                int maxLength;
                if (CakeSize == 8)
                    maxLength = 16;
                else
                    maxLength = 40;
                if (value.Length > maxLength)
                {
                    MessageBox.Show( _toManyLetters + CakeSize + _inchCake);
                    if (maxLength > _cakeWriting.Length)
                        maxLength = _cakeWriting.Length;
                    _cakeWriting = _cakeWriting.Substring(0, maxLength);
                }
                else
                    _cakeWriting = value;
            }
        }

        public override int NumberOfPeople
        {
            get { return base.NumberOfPeople; }
            set
            {
                base.NumberOfPeople = value;
                CalculateCakeSize();
                CakeWriting = _cakeWriting;
            }
        }

        private void CalculateCakeSize()
        {
            if (NumberOfPeople <= 4)
                CakeSize = 8;
            else
                CakeSize = 16;
        }

        public override decimal CalculateCost()
        {
            decimal cakeCost;
            if (CakeSize == 8)
                cakeCost = 40M + CakeWriting.Length*10M*DagensKurs;
            else
                cakeCost = 75M + CakeWriting.Length*10M*DagensKurs;
            return base.CalculateCost() + cakeCost;
        }
    }
}