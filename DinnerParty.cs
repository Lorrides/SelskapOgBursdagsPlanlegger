

using System;

namespace SelskapOgBursdagsPlanlegger
{
    class DinnerParty : Party
    {
        public decimal CostOfBeveragesPerPerson;
        const int DagensKurs = 9;

        public DinnerParty(int numberOfPeople, bool healthyOption,
                           bool fancyDecorations)
            : base(numberOfPeople, fancyDecorations)
        {
            SetHealthyOption(healthyOption);
            CalculateCostOfDecorations(fancyDecorations);
        }

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
                CostOfBeveragesPerPerson = 5.00M * DagensKurs;
            else
                CostOfBeveragesPerPerson = 20.00M * DagensKurs;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            decimal totalCost = base.CalculateCost()
                              + (CostOfBeveragesPerPerson * NumberOfPeople);

            if (healthyOption)
                return totalCost * .95M * DagensKurs;
            else
                return totalCost;
        }
    }
}
