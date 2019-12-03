using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using SisCaVet.Models;

namespace SisCaVet.Data 
{
    public class ProcedimentoData : Data 
    {

        public List<Procedimento> Read()
        {
            List<Procedimento> lista = new List<Procedimento>();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = "SELECT * FROM v_procedimentos";
        
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                Procedimento p = new Procedimento();

                p.Id =  (int)reader["Id"];
                p.Descricao = (string)reader["Descricao"];
                p.Valor = (decimal)reader["Valor"];
                lista.Add(p);
            }

            return lista;
        }

        public void Create(Procedimento e)
        {
            var status = 0;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;

            cmd.CommandText = @"INSERT INTO Procedimentos VALUES(@desc, @valor, @status)";

            cmd.Parameters.AddWithValue("@desc", e.Descricao);
            cmd.Parameters.AddWithValue( "@valor", e.Valor);
            cmd.Parameters.AddWithValue( "@status", status);
            cmd.ExecuteNonQuery();
        }
        
        public void Delete(int id){
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"UPDATE Procedimentos SET Status = @status
            WHERE Id = @id";

            cmd.Parameters.AddWithValue( "@id", id);
            cmd.Parameters.AddWithValue( "@status", 1);

            cmd.ExecuteNonQuery();
        }


        public Procedimento Read(int id)
        {
            Procedimento p = null;

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = @"SELECT * FROM Procedimentos WHERE id = @id";

                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    p = new Procedimento
                    {
                        Id = (int)reader["Id"], 
                        Descricao = (string)reader["Descricao"], 
                        Valor = (decimal)reader["Valor"]
                    };
                   
                }

            return p;
        }
    
        public void Update (Procedimento e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = connection;
            cmd.CommandText = @"UPDATE Procedimentos SET Descricao = @desc, 
            Valor = @valor WHERE Id = @id";
            
            cmd.Parameters.AddWithValue("@desc", e.Descricao);
            cmd.Parameters.AddWithValue( "@valor", e.Valor);
            cmd.Parameters.AddWithValue("@id", e.Id);

            cmd.ExecuteNonQuery();

        }

    }   

}