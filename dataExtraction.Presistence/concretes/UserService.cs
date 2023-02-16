using dataExtraction.Application.Abstract;
using dataExtraction.Domain.entities;
using System.Data.SqlClient;

namespace dataExtraction.Presistence.concretes
{
    public class UserService : IUserService
    {
        public List<User> GetAllUsers()
        {
            string connectionString = @"Data Source=HP\SQLEXPRESS;Initial Catalog=Users;Integrated Security=True";
            List<User> users = new List<User>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new SqlCommand("SELECT * FROM Users", connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        // Okunan verileri User nesnesine dönüştürme
                        User user = new User();
                        user.Id = reader.GetInt32(0);
                        user.FirstName = reader.GetString(1);
                        user.LastName = reader.GetString(2);
                        user.Balance = reader.GetDouble(3);

                        // User nesnesini listeye ekleme
                        users.Add(user);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Veritabanına bağlanırken hata oluştu: " + ex.Message);
                }
            }
            


            return users;
        }
    }
}
