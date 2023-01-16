namespace dzporpm_1
{
    internal class InsuranceContract
    {
        private DateTime Term { get; set; }
        private string Territory { get; set; }
        private string Franchise { get; set; }
        List<Product> products = new List<Product>();
        List<Insured> insureds = new List<Insured>();
        List<Beneficiary> beneficiaries = new List<Beneficiary>();
        List<Policyholder> policyholders = new List<Policyholder>();
        List<Manager> managers = new List<Manager>();
    }
}
