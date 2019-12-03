using System;
using System.Data.SqlClient;
using SisCaVet.Models;

namespace SisCaVet.Data
{
    public class LoginData : Data
    {
        public Veterinario Read(string Email, string Senha)
        {
            Veterinario veterinario = null;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM usuarios WHERE Email = @email AND Senha = @senha";
                       
            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@senha", Senha);

            var reader = cmd.ExecuteReader();

            if(reader.Read()) {
                veterinario = new Veterinario
                {
                  Id = (int)reader["Id"],
                  Nome = (string)reader["Veterinario"],
                  Email = (string)reader["Email"],
                  DataNascimento =(DateTime)reader["DataNascimento"],
                };
            }
            return veterinario;
        }
    }
}