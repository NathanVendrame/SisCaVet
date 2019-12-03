using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SisCaVet.Models;

namespace SisCaVet.Data 
{
    public class ConsultaData : Data
    {
        
        public List<Animal> Animais()
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

        public List<Veterinario> Veterinarios()
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

        public List<Procedimento> Procedimentos()
        {
            List<Procedimento> lista = new List<Procedimento>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM v_procedimentos";
        
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Procedimento v = new Procedimento();

                Procedimento p = new Procedimento();

                p.Id =  (int)reader["Id"];
                p.Descricao = (string)reader["Descricao"];
                p.Valor = (decimal)reader["Valor"];
                lista.Add(p);             
               
                lista.Add(v);
            }

            return lista;
        }

        public List<Consulta> Read()
        {
            List<Consulta> lista = new List<Consulta>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM v_consultas";
        
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Consulta c = new Consulta();

                c.Id =  (int)reader["Id"];
                c.Cliente = new Cliente
                {
                    Nome = (string)reader["Cliente"]
                };
                c.Veterinario = new Veterinario{
                    Nome = (string)reader["Veterinario"]
                };
                c.Animal = new Animal {
                    Nome = (string)reader["Animal"]
                };
                
                c.Descricao = (string)reader["Descricao"];
                c.Data = (DateTime)reader["Data"];
                c.ValorTotal = (decimal)reader["ValorTotal"];
                c.Status = (int)reader["Status"];               
                
                lista.Add(c);
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
            cmd.CommandText = @"UPDATE consultas SET Status = @status
            WHERE Id = @id";

            cmd.Parameters.AddWithValue( "@id", id);
            cmd.Parameters.AddWithValue( "@status", 1);
            cmd.ExecuteNonQuery();
        }
/*
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

        }*/ 

    }  

}





