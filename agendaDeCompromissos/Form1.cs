using agendaDeCompromissos.Dominio.Entidades;
using agendaDeCompromissos.Dominio.Repositorios;
using System;
using System.Windows.Forms;

namespace agendaDeCompromissos
{
    public partial class Form1 : Form
    {
        private DbRepositorioEvento RepositorioEvento;
        public Form1()
        {
            InitializeComponent();
            RepositorioEvento = new DbRepositorioEvento();
            AtualizarTabela();
            dtData.CustomFormat = "dd/MM/yyyy hh:mm:ss";
        }

        public void AtualizarTabela()
        {
            var lista = RepositorioEvento.BuscarTodos();
            dtgAgenda.DataSource = lista;
        }

        private void Criar_Click(object sender, EventArgs e)
        {
            var novoEvento = new Evento(txtEvento.Text, dtData.Value);
            RepositorioEvento.Inserir(novoEvento);
            AtualizarTabela();
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            var colunaId = dtgAgenda.SelectedCells[0].OwningRow.Cells[2].Value.ToString();
            var novoEvento = new Evento(txtEvento.Text, dtData.Value);
            novoEvento.Id = int.Parse(colunaId);
            RepositorioEvento.Editar(novoEvento);
            AtualizarTabela();
            
        }

        private void Deletar_Click(object sender, EventArgs e)
        {
            RepositorioEvento.Deletar(int.Parse(dtgAgenda.SelectedCells[0].OwningRow.Cells[2].Value.ToString()));
            AtualizarTabela();
        }
    }
}
