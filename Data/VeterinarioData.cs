using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SisCaVet.Models;

namespace SisCaVet.Data 
{
    public class VeterinarioData : Data 
    {        
        public List<Veterinario> Read()
        {
            List<Veterinario> lista = new List<Veterinario>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM v_veterinarios";
        
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Veterinario v = new Veterinario();

                v.Id =  (int)reader["Id"];
                v.Nome = (string)reader["Nome"];
                v.Cpf = (string)reader["Cpf"];
                v.Rg = (string)reader["Rg"];
                v.DataNascimento = (DateTime)reader["DataNascimento"];
                v.Telefone = (string)reader["Telefone"];
                v.Longadouro = (string)reader["Rua"];
                v.Bairro = (string)reader["Bairro"];
                v.Cep = (string)reader["Cep"];
                v.Cidade = (string)reader["Cidade"];
                v.Estado = (string)reader["Estado"];
                v.Especialidade = (string)reader["Especialidade"];
                v.Salario = (decimal)reader["Salario"];
                v.Crmv = (int)reader["Crmv"];
                v.Status = (int)reader["Status"];                         
                
                lista.Add(v);
            }

            return lista;
        }

        public void Create(Veterinario e)
        {
            var login = e.Cpf; 
            var senha = e.Rg;

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = @"EXEC cadVet @nome, @cpf, @rg, @dataNascimento, @telefone, 
            @rua, @bairro, @cep, @cidade, @estado, @status, @email,  @senha, @salario, @especialidade,  @crmv";

            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.Parameters.AddWithValue("@cpf", e.Cpf);
            cmd.Parameters.AddWithValue("@rg", e.Rg);
            cmd.Parameters.AddWithValue("@dataNascimento", e.DataNascimento);
            cmd.Parameters.AddWithValue("@telefone", e.Telefone);
            cmd.Parameters.AddWithValue("@rua", e.Longadouro);
            cmd.Parameters.AddWithValue("@bairro", e.Bairro);
            cmd.Parameters.AddWithValue("@cep", e.Cep);
            cmd.Parameters.AddWithValue("@cidade", e.Cidade);
            cmd.Parameters.AddWithValue("@estado", e.Estado);
            cmd.Parameters.AddWithValue("@especialidade", e.Especialidade);
            cmd.Parameters.AddWithValue("@salario", e.Salario);
            cmd.Parameters.AddWithValue("@crmv", e.Crmv);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@senha",senha);     
            cmd.Parameters.AddWithValue("@status", e.Status);

            cmd.ExecuteNonQuery();
        }
        
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"UPDATE pessoas SET Status = @status
            WHERE Id = @id";

            cmd.Parameters.AddWithValue( "@id", id);
            cmd.Parameters.AddWithValue( "@status", 1);
            cmd.ExecuteNonQuery();
        }

        public Veterinario Read(int id)
        {
            Veterinario c = null;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * from v_veterinarios WHERE Id = @id";

                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    c = new Veterinario
                    {
                        Id = (int)reader["Id"], 
                        Nome = (string)reader["Nome"], 
                        Cpf = (string)reader["Cpf"], 
                        Rg = (string)reader["Rg"], 
                        DataNascimento = (DateTime)reader["DataNascimento"], 
                        Telefone = (string)reader["Telefone"], 
                        Longadouro = (string)reader["Rua"], 
                        Bairro = (string)reader["Bairro"], 
                        Cep = (string)reader["Cep"], 
                        Cidade = (string)reader["Cidade"], 
                        Estado = (string)reader["Estado"], 
                        Especialidade = (string)reader["Especialidade"],
                        Salario = (decimal)reader["Salario"],
                        Crmv = (int)reader["Crmv"],
                        Status = (int)reader["Status"], 
                        Email = (string)reader["Email"],
                        Senha = (string)reader["Senha"]                       
                    };                   
                }

            return c;
        }
    
        public void Update (Veterinario e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"EXEC AltVet @id, @nome, @cpf, @rg, @dataNascimento, @telefone, @rua, @bairro, 
                                                @cep, @cidade, @estado, @status, @especialidade, @salario, @crmv, @email, @senha";
            
            cmd.Parameters.AddWithValue("@nome", e.Nome);
            cmd.Parameters.AddWithValue("@cpf", e.Cpf);
            cmd.Parameters.AddWithValue("@rg", e.Rg);
            cmd.Parameters.AddWithValue("@dataNascimento", e.DataNascimento);
            cmd.Parameters.AddWithValue("@telefone", e.Telefone);
            cmd.Parameters.AddWithValue("@rua", e.Longadouro);
            cmd.Parameters.AddWithValue("@bairro", e.Bairro);
            cmd.Parameters.AddWithValue("@cep", e.Cep);
            cmd.Parameters.AddWithValue("@cidade", e.Cidade);
            cmd.Parameters.AddWithValue("@estado", e.Estado);
            cmd.Parameters.AddWithValue("@especialidade", e.Especialidade);
            cmd.Parameters.AddWithValue("@salario", e.Salario);
            cmd.Parameters.AddWithValue("@email", e.Email);
            cmd.Parameters.AddWithValue("@crmv", e.Crmv);
            cmd.Parameters.AddWithValue("@senha", e.Senha);
            cmd.Parameters.AddWithValue("@status", e.Status);
            cmd.Parameters.AddWithValue("@id", e.Id);
                

            cmd.ExecuteNonQuery();

        }

    }   

}





