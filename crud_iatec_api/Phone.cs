using System.ComponentModel.DataAnnotations;


namespace crud_iatec_api
{
    public class Phone
    {
        public int id { get; set; }

        [StringLength(11)]
        public string phone { get; set; } = string.Empty;

        public int personId { get; set; }

        public Person? person { get; set; }


    }
}
