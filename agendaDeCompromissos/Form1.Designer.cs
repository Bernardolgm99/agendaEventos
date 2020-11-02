namespace agendaDeCompromissos
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgAgenda = new System.Windows.Forms.DataGridView();
            this.Criar = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.Deletar = new System.Windows.Forms.Button();
            this.Editar = new System.Windows.Forms.Button();
            this.txtEvento = new System.Windows.Forms.TextBox();
            this.lblEvento = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgAgenda
            // 
            this.dtgAgenda.AllowUserToAddRows = false;
            this.dtgAgenda.AllowUserToDeleteRows = false;
            this.dtgAgenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAgenda.Location = new System.Drawing.Point(12, 12);
            this.dtgAgenda.Name = "dtgAgenda";
            this.dtgAgenda.ReadOnly = true;
            this.dtgAgenda.Size = new System.Drawing.Size(343, 294);
            this.dtgAgenda.TabIndex = 0;
            // 
            // Criar
            // 
            this.Criar.Location = new System.Drawing.Point(280, 341);
            this.Criar.Name = "Criar";
            this.Criar.Size = new System.Drawing.Size(75, 23);
            this.Criar.TabIndex = 1;
            this.Criar.Text = "Criar";
            this.Criar.UseVisualStyleBackColor = true;
            this.Criar.Click += new System.EventHandler(this.Criar_Click);
            // 
            // dtData
            // 
            this.dtData.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtData.Location = new System.Drawing.Point(12, 383);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(237, 20);
            this.dtData.TabIndex = 2;
            // 
            // Deletar
            // 
            this.Deletar.Location = new System.Drawing.Point(280, 399);
            this.Deletar.Name = "Deletar";
            this.Deletar.Size = new System.Drawing.Size(75, 23);
            this.Deletar.TabIndex = 3;
            this.Deletar.Text = "Deletar";
            this.Deletar.UseVisualStyleBackColor = true;
            this.Deletar.Click += new System.EventHandler(this.Deletar_Click);
            // 
            // Editar
            // 
            this.Editar.Location = new System.Drawing.Point(280, 370);
            this.Editar.Name = "Editar";
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 4;
            this.Editar.Text = "Editar";
            this.Editar.UseVisualStyleBackColor = true;
            this.Editar.Click += new System.EventHandler(this.Editar_Click);
            // 
            // txtEvento
            // 
            this.txtEvento.Location = new System.Drawing.Point(12, 344);
            this.txtEvento.Name = "txtEvento";
            this.txtEvento.Size = new System.Drawing.Size(237, 20);
            this.txtEvento.TabIndex = 5;
            // 
            // lblEvento
            // 
            this.lblEvento.AutoSize = true;
            this.lblEvento.Location = new System.Drawing.Point(12, 328);
            this.lblEvento.Name = "lblEvento";
            this.lblEvento.Size = new System.Drawing.Size(44, 13);
            this.lblEvento.TabIndex = 6;
            this.lblEvento.Text = "Evento:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(12, 367);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(33, 13);
            this.lblData.TabIndex = 7;
            this.lblData.Text = "Data:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 436);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblEvento);
            this.Controls.Add(this.txtEvento);
            this.Controls.Add(this.Editar);
            this.Controls.Add(this.Deletar);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.Criar);
            this.Controls.Add(this.dtgAgenda);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgAgenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgAgenda;
        private System.Windows.Forms.Button Criar;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.Button Deletar;
        private System.Windows.Forms.Button Editar;
        private System.Windows.Forms.TextBox txtEvento;
        private System.Windows.Forms.Label lblEvento;
        private System.Windows.Forms.Label lblData;
    }
}

