namespace SelskapOgBursdagsPlanlegger
{
    internal class Party
    {
        private const int CostOfFoodPerPerson = 25;
        private const int DagensKurs = 9;
        private bool _fancyDecorations;

        private int _numberOfPeople;
        public decimal CostOfDecorations;

        public Party(int numberOfPeople, bool fancyDecorations)
        {
            _fancyDecorations = fancyDecorations;
            NumberOfPeople = numberOfPeople;
        }

        public virtual int NumberOfPeople
        {
            get { return _numberOfPeople; }
            set
            {
                _numberOfPeople = value;
                CalculateCostOfDecorations(_fancyDecorations);
            }
        }

        public void CalculateCostOfDecorations(bool fancy)
        {
            _fancyDecorations = fancy;
            if (fancy)
                CostOfDecorations = NumberOfPeople*15.00M + 50M;
            else
                CostOfDecorations = NumberOfPeople*7.50M + 30M ;
        }

        public virtual decimal CalculateCost()
        {
            var totalCost = CostOfDecorations + CostOfFoodPerPerson*NumberOfPeople * DagensKurs;
            if (NumberOfPeople > 12)
            {
                totalCost += 100M;
            }
            return totalCost;
        }
    }
}