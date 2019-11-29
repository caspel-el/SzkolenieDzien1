//#define Select
#define Insert
//#define Update
//#define Delete
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace lab34_db
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=192.168.3.42,50500; Initial Catalog=caspelec; User ID=CASPEL; Password=CASPEL22";
            SqlConnection sqlConnection;
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();

            Console.WriteLine("Connection open");
#if (Select)
            SqlCommand sqlCommandSelect;
            SqlDataReader sqlDataReader;
            string sqlSelect = "";
            sqlSelect = "select * from portfel";

            sqlCommandSelect = new SqlCommand(sqlSelect, sqlConnection);
            sqlDataReader = sqlCommandSelect.ExecuteReader();

            while(sqlDataReader.Read())
            {
                Console.WriteLine($"{sqlDataReader.GetValue(0)}  {sqlDataReader.GetValue(1)}" +
                    $"{sqlDataReader.GetValue(2)} {sqlDataReader.GetValue(3)} {sqlDataReader.GetValue(4)}");

            }
            sqlDataReader.Close();
            sqlCommandSelect.Dispose();

#elif (Insert)
            SqlCommand sqlCommandInsert;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlInsert = "";
            sqlInsert = "insert into portfel values(1,'jakis wydatel','WYDATEK', 123.44, '11.11.2019'";

            sqlCommandInsert = new SqlCommand(sqlInsert, sqlConnection);
            sqlDataAdapter.InsertCommand = new SqlCommand(sqlInsert, sqlConnection);
            sqlDataAdapter.InsertCommand.ExecuteNonQuery();
            sqlCommandInsert.Dispose();


#elif (Update)

            SqlCommand sqlCommandUpdate;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlUpdate = "";
            sqlUpdate = "update portfel set id =55 where id=1";

            sqlCommandUpdate = new SqlCommand(sqlUpdate, sqlConnection);
            sqlDataAdapter.UpdateCommand = new SqlCommand(sqlUpdate, sqlConnection);
            sqlDataAdapter.UpdateCommand.ExecuteNonQuery();
            sqlCommandUpdate.Dispose();
#elif (Delete)
            SqlCommand sqlCommandDelete;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            string sqlDelete = "";
            sqlDelete = "delete portfel where id=55";

            sqlCommandDelete = new SqlCommand(sqlDelete, sqlConnection);
            sqlDataAdapter.DeleteCommand = new SqlCommand(sqlDelete, sqlConnection);
            sqlDataAdapter.DeleteCommand.ExecuteNonQuery();
            sqlCommandDelete.Dispose();

#endif

            Console.ReadKey();
            sqlConnection.Close();
        }
    }
}
