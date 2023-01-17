using System.Collections;

namespace dzporpm_1
{
    public class Client
    {
        private int Id { get; set; }
        private string SignNaturalLegalFace { get; set; }
        private IList[] Contracts { get; set; }
        private string Contacts { get; set; }
        List<LegalEntity> legalEntities = new List<LegalEntity>();
        List<NaturalPerson> naturals = new List<NaturalPerson>();
       
        public void Client() 
        {
        
        }
    }
}
