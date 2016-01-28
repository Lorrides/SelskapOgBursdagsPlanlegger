

using System;

namespace SelskapOgBursdagsPlanlegger
{
    class DinnerParty
    {
        private bool checked1;
        private bool checked2;
        private int value;

        public DinnerParty(int value, bool checked1, bool checked2)
        {
            this.value = value;
            this.checked1 = checked1;
            this.checked2 = checked2;
        }

        public int NumberOfPeople { get; internal set; }

        internal void CalculateCostOfDecorations(bool @checked)
        {
            throw new NotImplementedException();
        }

        internal void SetHealthyPotion(bool @checked)
        {
            throw new NotImplementedException();
        }
    }
}
