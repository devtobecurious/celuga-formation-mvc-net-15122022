using MySql.Data.MySqlClient;
using SelfieAWookie.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfieAWookie.Core.Services.Selfies
{
    public class SelfieMySqlService : ISelfieService
    {
        public List<Selfie> GetList()
        {
            List<Selfie> list = new List<Selfie>(); 

            using MySqlConnection connection = new MySqlConnection();

            connection.ConnectionString = "Server=127.0.0.1;Database=celuga-formation-mvcnet;Uid=celuga;Pwd=celuga05012023!;";

            connection.Open();
            using MySqlCommand command = connection.CreateCommand();
            command.CommandText = "SELECT Id, Titre FROM selfie";
            using MySqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                Selfie selfie = new();

                selfie.Id = reader.GetInt32("Id");
                selfie.Titre = reader.GetString("Titre");

                list.Add(selfie);
            }

            return list;
        }
    }
}
