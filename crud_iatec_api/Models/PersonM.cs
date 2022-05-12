
namespace crud_iatec_api.Models
{
    public class PersonM
    {

        public int id { get; set; } = 0;
        public string name { get; set; } = string.Empty;
        public DateTime birthDate { get; set; }
        public string cpf { get; set; } = string.Empty;

        public string save()
        {
            string query = "";
            if (this.id != 0 )
            {
                query = 
                        @$"
                        UPDATE person SET name = {this.name}, birthDate = {this.birthDate}, cpf = {this.cpf} WHERE id = {this.id}";

            } else
            {
                query =
                        @$"
                        INSERT INTO person VALUES ({this.name}, {this.birthDate}, {this.cpf})";
            }


            return query;

        }

        public string deletePerson()
        {
            if(this.id == 0)
            {
                return string.Empty;
            }

            string query = @$"
                    delete from dbo.Person where id = {this.id}";

            return query;
        }

        public string getAllPersons()
        {
            string query = @"
                    select id, name from dbo.Person";

            return query;
        }

    }
}
