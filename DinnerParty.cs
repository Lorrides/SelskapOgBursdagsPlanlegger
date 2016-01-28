

using System;

namespace SelskapOgBursdagsPlanlegger
{
    class DinnerParty
    {
        const int CostOfFoodPerPerson = 25;

        private int numberOfPeople;
        public int NumberOfPeople
        {
            get { return numberOfPeople; }
            set
            {
                numberOfPeople = value;
                CalculateCostOfDecorations(fancyDecorations);
            }
        }

        private bool fancyDecorations;

        public decimal CostOfBeveragesPerPersom;
        public decimal CostOfDecorations = 0;
        public decimal DagensKurs = 8;






        public DinnerParty(int numberOfPeople, bool healtyOption, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            this.fancyDecorations = fancyDecorations;
            SetHealthyPotion(healtyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        internal void SetHealthyPotion(bool helse)
        {
            if (helse)
            {
                CostOfBeveragesPerPersom = 5.0M * DagensKurs;
            }
            else
            {
                CostOfBeveragesPerPersom = 20.0M * DagensKurs;
            }
        }

        internal void CalculateCostOfDecorations(bool fancy)
        {
            fancyDecorations = fancy;
            if (fancy)
            {
                CostOfDecorations = (NumberOfPeople * 150.00M * DagensKurs) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 70.50M * DagensKurs) + 30M;
            }
        }



        internal decimal CalculateCost(bool kostnader)
        {
            decimal totalKost = CostOfDecorations + ((CostOfBeveragesPerPersom + CostOfFoodPerPerson) * NumberOfPeople);

            if (kostnader)
            {
                return totalKost * .95M;
            }
            else
            {
                return totalKost;
            }
        }
    }
}
