using System;

namespace agendaDeCompromissos.Dominio.Entidades
{
    public class Evento
    {
        public Evento(String nome, DateTime data)
        {
            Nome = nome;
            Data = data;
        }
        public Evento()
        {

        }
        public String Nome { get; set; }
        public DateTime Data { get; set; }
        public int Id { get; set; }
    }
}