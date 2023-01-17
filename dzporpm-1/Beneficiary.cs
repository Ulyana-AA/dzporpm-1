namespace dzporpm_1
{
    internal class Beneficiary : Client
    {
        List<InsuranceContract> insuranceContracts = new List<InsuranceContract>();
        
        Policyholder policyholder;
        public Beneficiary() 
        {
            policyholder = new Policyholder();
        }
    }
}
