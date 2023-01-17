namespace dzporpm_1
{
    internal class InsuranceContract
    {
        private DateTime Term { get; set; }
        private string Territory { get; set; }
        private string Franchise { get; set; }
        
        Product product;
        Insured insured;
        Beneficiary beneficiary;
        Policyholder policyholder;
        Manager manager;
        
        public InsuranceContract()
        {
            product = new Product();
            insured = new Insured();
            beneficiary = new Beneficiary();
            policyholder = new Policyholder();
            manager = new Manager();
        }
    }
}
