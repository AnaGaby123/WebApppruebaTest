using System.Collections.Generic;
using System.Data.SqlClient;

namespace WebApplicationUnitTestNetCore.Data
{
    public static class EmployeeData
    {

        public static List<employee> GetEmployee()
        {

            var r = PruebaHybrid();

            return new() {
                 new(){ Id= 1, Name="Employe_1"},
                 new(){ Id= 2, Name="Employe_2"},
                 new(){ Id= 3, Name="Employe_3"},
                 new(){ Id= 4, Name="Employe_4"},
                 new(){ Id= 5, Name="Employe_5"},
                 new(){ Id= 6, Name="Employe_6"},
            };
        }


        public static List<responseTest> PruebaHybrid()
        {
            List<responseTest> list = new();
            try
            {
                SqlConnectionStringBuilder builder = new();



                builder.DataSource = "RYNL039";
                builder.UserID = "ProquifaDotNetDBUser";
                builder.Password = "+pFz4_H2REF2YNe9";
                builder.InitialCatalog = "ProquifaDoNet";

                using SqlConnection connection = new (builder.ConnectionString);
                connection.Open();
                String sql = "SELECT name, collation_name FROM sys.databases";
                using SqlCommand command = new SqlCommand(sql, connection);
                using SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    list.Add(new responseTest { item = string.Format("{0} {1}", reader.GetString(0), reader.GetString(1)) });
                }

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            //Console.WriteLine("\nDone. Press enter.");
            //Console.ReadLine();
            //Console.ReadLine();

            return list;
        }
    }

}

