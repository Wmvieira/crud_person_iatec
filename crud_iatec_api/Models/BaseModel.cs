/*using System.Data.SqlClient;
using System.Data;
namespace crud_iatec_api.Models
{
    public abstract class BaseModel
    {
        public static string table = "base";

        public void fill(Object data)
        {
            string[] atributes = this.tableAttributes(true);



            for (int i = 0; i < atributes.Length; i++)
            {

                var property = data.GetType().GetProperty(atributes[i]);

                if (property == null)
                {
                    continue;
                }
                this.GetType().GetProperty(atributes[i]).SetValue(this , property); 
            }
            
        }

        public bool isNew()
        {
            if(this.isPrimaryAutoIncrement())
            {
                string key = this.getPrimaryKeyName();
                return (this.GetType().GetProperty(key).GetValue(this) == null);
            } else
            {
                return (this.)
            }
        }

        public bool isPrimaryAutoIncrement()
        {
            return true;
        }

        public Object getPrimaryKeyValue()
        {
            string key = this.getPrimaryKeyName();
            return this.GetType().GetProperty(key).GetValue(this);
        }

        public string getPrimaryKeyName()
        {
            return "id";
        }

        public [] toArray(bool whitPrimaryKey = false)
        {
            
        }

        public static findByPrimaryKey(string key)
        {
            string sqlDataSource = this.getConnection();

            string tableName = this.tableName();

            string query = $"SELECT * FROM {tableName} WHERE {primaryKey} = {key}"



    }

    public void save()
        {
            this.beforeSave();

            DataTable table = new DataTable();
            string sqlDataSource = this.getConnection();
            SqlDataReader myReader;


            this.afterSave();
        }

        public void afterSave()
        {
            //Hook
        }

        public void beforeSave()
        {
            //Hook
        }

        public Array[] validate(Array[] errors)
        {
            return null;
        }

        abstract public string tableName();
        abstract public string[] tableAttributes(bool whithPrimaryKey = false);
        abstract public string getConnection();

    }
}
*/