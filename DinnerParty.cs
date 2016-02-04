namespace SelskapOgBursdagsPlanlegger
{
    internal class DinnerParty : Party
    {
        private const int DagensKurs = 9;
        public decimal CostOfBeveragesPerPerson;


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
                CostOfBeveragesPerPerson = 5.00M*DagensKurs;
            else
                CostOfBeveragesPerPerson = 20.00M*DagensKurs;
        }

        public decimal CalculateCost(bool healthyOption)
        {
            var totalCost = base.CalculateCost()
                            + CostOfBeveragesPerPerson*NumberOfPeople;

            if (healthyOption)
                return totalCost*.95M;
            return totalCost;
        }
    }
}