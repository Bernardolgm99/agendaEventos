using agendaDeCompromissos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace agendaDeCompromissos.Dominio.Repositorios
{
    public class DbRepositorioEvento
    {
        private const String CONECTIONSTRING = "Data Source =DESKTOP-87F8S1I\\JARVAS; Initial Catalog =Agenda;"
            + "Integrated Security=true; Current Language=Portuguese";
        public List<Evento> BuscarTodos()
        {
            var listaEventos = new List<Evento>();
            var query = "SELECT id, nome, data FROM evento WHERE data>=SYSDATETIME() ORDER BY data";
            using (SqlConnection conexao = new SqlConnection(CONECTIONSTRING))
            {
                var comando = new SqlCommand(query, conexao);
                try
                {
                    conexao.Open();
                    SqlDataReader reader = comando.ExecuteReader();
                    while (reader.Read())
                    {
                        var evento = new Evento()
                        {
                            Id = int.Parse(reader[0].ToString()),
                            Nome = reader[1].ToString(),
                            Data = DateTime.Parse(reader[2].ToString())
                        };
                        listaEventos.Add(evento);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return listaEventos;
        }
        public void Inserir(Evento evento)
        {
            var query = $"INSERT INTO Evento VALUES('{evento.Nome}','{evento.Data}')";
            using (SqlConnection conexao = new SqlConnection(CONECTIONSTRING))
            {
                var comando = new SqlCommand(query, conexao);
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void Editar(Evento evento)
        {
            var query = $"UPDATE Evento SET nome='{evento.Nome}', data='{evento.Data}' WHERE id={evento.Id}";
            using (SqlConnection conexao = new SqlConnection(CONECTIONSTRING))
            {
                var comando = new SqlCommand(query, conexao);
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
        public void Deletar(int id)
        {
            var query = $"DELETE FROM Evento WHERE id={id}";
            using (SqlConnection conexao = new SqlConnection(CONECTIONSTRING))
            {
                var comando = new SqlCommand(query, conexao);
                try
                {
                    conexao.Open();
                    comando.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
        }
    }
}
