namespace dzporpm_1
{
    internal class Beneficiary : Client
    {
        List<InsuranceContract> insuranceContracts = new List<InsuranceContract>();
        
        public Policyholder Policyholder { get; set; }
    }
}
