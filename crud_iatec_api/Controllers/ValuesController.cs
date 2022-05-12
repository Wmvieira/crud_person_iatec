using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;
using System.Data;
using crud_iatec_api.Models;

namespace crud_iatec_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public ValuesController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public JsonResult Get()
        {
            PersonM person = new PersonM(); 
            string query = person.getAllPersons();


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;

             using(SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }


            return new JsonResult(table);
        }
        //[HttpPut]
        /*public string Put(Person p)
        {
            PersonM person = new PersonM();
            
            if(p.id <= 0)
            {
                throw new Exception();
            }


            DataTable table = new DataTable();
            string sqlDataSource = _configuration.GetConnectionString("DefaultConnection");
            SqlDataReader myReader;

            using (SqlConnection myCon = new SqlConnection(sqlDataSource))
            {
                myCon.Open();
                using (SqlCommand sqlCommand = new SqlCommand(query, myCon))
                {
                    myReader = sqlCommand.ExecuteReader();
                    table.Load(myReader);

                    myReader.Close();
                    myCon.Close();
                }
            }

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(table);

            return json;
        }*/
    }
}
