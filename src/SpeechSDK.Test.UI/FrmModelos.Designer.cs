namespace SpeechSDK.Test.UI
{
    partial class FrmModelos
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
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.grdModelos = new System.Windows.Forms.DataGridView();
            this.Identificador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantidadeAmostras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdModelos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAdicionar.Location = new System.Drawing.Point(13, 415);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 23);
            this.btnAdicionar.TabIndex = 0;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRemover.Location = new System.Drawing.Point(110, 415);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(85, 23);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // grdModelos
            // 
            this.grdModelos.AllowUserToAddRows = false;
            this.grdModelos.AllowUserToDeleteRows = false;
            this.grdModelos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdModelos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdModelos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificador,
            this.QuantidadeAmostras});
            this.grdModelos.Location = new System.Drawing.Point(12, 12);
            this.grdModelos.MultiSelect = false;
            this.grdModelos.Name = "grdModelos";
            this.grdModelos.ReadOnly = true;
            this.grdModelos.RowTemplate.Height = 24;
            this.grdModelos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdModelos.Size = new System.Drawing.Size(305, 379);
            this.grdModelos.TabIndex = 2;
            // 
            // Identificador
            // 
            this.Identificador.DataPropertyName = "Nome";
            this.Identificador.HeaderText = "Identificador";
            this.Identificador.Name = "Identificador";
            // 
            // QuantidadeAmostras
            // 
            this.QuantidadeAmostras.DataPropertyName = "Quantidade";
            this.QuantidadeAmostras.HeaderText = "Quantidade de Amostras";
            this.QuantidadeAmostras.Name = "QuantidadeAmostras";
            // 
            // FrmModelos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 450);
            this.Controls.Add(this.grdModelos);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Name = "FrmModelos";
            this.Text = "Modelos";
            ((System.ComponentModel.ISupportInitialize)(this.grdModelos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.DataGridView grdModelos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificador;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantidadeAmostras;
    }
}