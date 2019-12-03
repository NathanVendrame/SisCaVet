using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SisCaVet.Models;

namespace SisCaVet.Data 
{
    public class AnimalData : Data
    {
        
        public List<Cliente> Clientes()
        {
            List<Cliente> lista = new List<Cliente>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM Clientes";
        
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Cliente c = new Cliente();

                c.Id =  (int)reader["Id"];
                c.Nome = (string)reader["Nome"];
                c.Cpf = (string)reader["Cpf"];
                c.Rg = (string)reader["Rg"];
                c.DataNascimento = (DateTime)reader["DataNascimento"];
                c.Telefone = (string)reader["Telefone"];
                c.Longadouro = (string)reader["Longadouro"];
                c.Bairro = (string)reader["Bairro"];
                c.Cep = (string)reader["Cep"];
                c.Cidade = (string)reader["Cidade"];
                c.Estado = (string)reader["Estado"];
                c.QuantidadeConsultasAberto = (int)reader["QuantidadeConsultasAberto"];                
                c.Status = (int)reader["Status"];           
               
                lista.Add(c);
            }

            return lista;
        }

        public List<Animal> Read()
        {
            List<Animal> lista = new List<Animal>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM v_animais";
        
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Animal a = new Animal();

                a.Id =  (int)reader["Id"];
                a.Cliente = new Cliente
                {
                    Nome = (string)reader["Cliente"]
                };
                a.Nome = (string)reader["Animal"];
                a.Idade = (int)reader["Idade"];
                a.Peso = (decimal)reader["Peso"];
                a.Raca = (string)reader["Raca"];
                a.Especie = (string)reader["Especie"];        
                
                lista.Add(a);
            }

            return lista;
        }

        public void Create(Animal e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = @"EXEC cadAni @nome, @idade, @peso, @raca, @descricao, @cliente, @especie, @status";
            
            cmd.Parameters.AddWithValue("@cliente", e.Cliente.Id);
            cmd.Parameters.AddWithValue("@nome", e.Nome);            
            cmd.Parameters.AddWithValue("@idade", e.Idade);
            cmd.Parameters.AddWithValue("@peso", e.Peso);
            cmd.Parameters.AddWithValue("@raca", e.Raca);
            cmd.Parameters.AddWithValue("@especie", e.Especie); 
            cmd.Parameters.AddWithValue("@descricao", e.Descricao); 
            cmd.Parameters.AddWithValue("@status", e.Status);           

            cmd.ExecuteNonQuery();
        }
        
        public void Delete(int id)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"UPDATE animais SET Status = @status
            WHERE Id = @id";

            cmd.Parameters.AddWithValue( "@id", id);
            cmd.Parameters.AddWithValue( "@status", 1);
            cmd.ExecuteNonQuery();
        }

        public Animal Read(int id)
        {
            Animal a = null;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM v_animais WHERE Id = @id";

                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    a = new Animal();
                    
                    a.Id =  (int)reader["Id"];
                    a.Cliente = new Cliente {
                        Nome = (string)reader["Cliente"]
                    };
                    a.Nome = (string)reader["Animal"];
                    a.Idade = (int)reader["Idade"];
                    a.Peso = (decimal)reader["Peso"];
                    a.Raca = (string)reader["Raca"];
                    a.Especie = (string)reader["Especie"];                    
                                      
                }

            return a;
        }
    
        public void Update (Animal e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"EXEC AltAni @id, @nome, @idade, @peso, @raca, @descricao,@cliente, @especie, @status";           

            cmd.Parameters.AddWithValue("@cliente", e.Cliente.Id);
            cmd.Parameters.AddWithValue("@nome", e.Nome);            
            cmd.Parameters.AddWithValue("@idade", e.Idade);
            cmd.Parameters.AddWithValue("@peso", e.Peso);
            cmd.Parameters.AddWithValue("@raca", e.Raca);
            cmd.Parameters.AddWithValue("@especie", e.Especie); 
            cmd.Parameters.AddWithValue("@id", e.Id);  
            cmd.Parameters.AddWithValue("@status", 0);
            cmd.Parameters.AddWithValue("@descricao", (object)e.Descricao ?? DBNull.Value);

            cmd.ExecuteNonQuery();

        }

    }   

}





