using System.Collections;

namespace dzporpm_1
{
    public class Client
    {
        private int Id { get; set; }
        private string SignNaturalLegalFace { get; set; }
        private IList[] Contracts { get; set; }
        private IList[] Contacts { get; set; }
        
        LegalEntity legalEntity;
        NaturalPerson naturalPerson;
        
        public Client()
        {
            legalEntity = new LegalEntity();
            naturalPerson = new NaturalPerson();
        }
       
        public void Client() 
        {
        
        }
    }
}
