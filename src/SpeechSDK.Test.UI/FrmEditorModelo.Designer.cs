namespace SpeechSDK.Test.UI
{
    partial class FrmEditorModelo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grdAudios = new System.Windows.Forms.DataGridView();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.gbxNome = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gbxAudios = new System.Windows.Forms.GroupBox();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.grdAudios)).BeginInit();
            this.gbxNome.SuspendLayout();
            this.gbxAudios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdAudios
            // 
            this.grdAudios.AllowUserToAddRows = false;
            this.grdAudios.AllowUserToDeleteRows = false;
            this.grdAudios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAudios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador});
            this.grdAudios.Location = new System.Drawing.Point(6, 22);
            this.grdAudios.MultiSelect = false;
            this.grdAudios.Name = "grdAudios";
            this.grdAudios.ReadOnly = true;
            this.grdAudios.RowTemplate.Height = 24;
            this.grdAudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdAudios.Size = new System.Drawing.Size(490, 227);
            this.grdAudios.TabIndex = 5;
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Location = new System.Drawing.Point(411, 276);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(85, 23);
            this.btnRemover.TabIndex = 4;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.Location = new System.Drawing.Point(314, 276);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // gbxNome
            // 
            this.gbxNome.Controls.Add(this.txtNome);
            this.gbxNome.Location = new System.Drawing.Point(12, 12);
            this.gbxNome.Name = "gbxNome";
            this.gbxNome.Size = new System.Drawing.Size(232, 62);
            this.gbxNome.TabIndex = 6;
            this.gbxNome.TabStop = false;
            this.gbxNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 21);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(220, 22);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // gbxAudios
            // 
            this.gbxAudios.Controls.Add(this.grdAudios);
            this.gbxAudios.Controls.Add(this.btnAdicionar);
            this.gbxAudios.Controls.Add(this.btnRemover);
            this.gbxAudios.Location = new System.Drawing.Point(12, 80);
            this.gbxAudios.Name = "gbxAudios";
            this.gbxAudios.Size = new System.Drawing.Size(502, 305);
            this.gbxAudios.TabIndex = 7;
            this.gbxAudios.TabStop = false;
            this.gbxAudios.Text = "Audios";
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Caminho";
            this.Identificador.HeaderText = "Caminho";
            this.Identificador.Name = "Identificador";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalvar.Location = new System.Drawing.Point(417, 415);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Abrir Audio";
            // 
            // FrmEditorModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.gbxAudios);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gbxNome);
            this.Name = "FrmEditorModelo";
            this.Text = "Editor Modelo";
            ((System.ComponentModel.ISupportInitialize)(this.grdAudios)).EndInit();
            this.gbxNome.ResumeLayout(false);
            this.gbxNome.PerformLayout();
            this.gbxAudios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdAudios;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.GroupBox gbxNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gbxAudios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}