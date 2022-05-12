using System.ComponentModel.DataAnnotations;

namespace crud_iatec_api
{
    public class Person
    {
        public int id{ get; set; }
        
        [StringLength(30)] 
        public string name{ get; set; } = string.Empty;
        public DateTime birthDate { get; set; }

        [StringLength(11)]
        public string cpf { get; set; } = string.Empty;

        public List<Phone>? phones { get; set; }
    }
}
