namespace SpeechSDK.Test.UI
{
    partial class FrmAnalise
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSelecionarAudio = new System.Windows.Forms.Button();
            this.txtArquivoAudio = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.btnClassificar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionarAudio);
            this.groupBox1.Controls.Add(this.txtArquivoAudio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(413, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo de Áudio";
            // 
            // btnSelecionarAudio
            // 
            this.btnSelecionarAudio.Location = new System.Drawing.Point(357, 20);
            this.btnSelecionarAudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSelecionarAudio.Name = "btnSelecionarAudio";
            this.btnSelecionarAudio.Size = new System.Drawing.Size(33, 23);
            this.btnSelecionarAudio.TabIndex = 1;
            this.btnSelecionarAudio.Text = "...";
            this.btnSelecionarAudio.UseVisualStyleBackColor = true;
            this.btnSelecionarAudio.Click += new System.EventHandler(this.btnSelecionarAudio_Click);
            // 
            // txtArquivoAudio
            // 
            this.txtArquivoAudio.Location = new System.Drawing.Point(5, 21);
            this.txtArquivoAudio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtArquivoAudio.Name = "txtArquivoAudio";
            this.txtArquivoAudio.Size = new System.Drawing.Size(345, 22);
            this.txtArquivoAudio.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Title = "Abrir Audio";
            // 
            // gbxResultado
            // 
            this.gbxResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbxResultado.Controls.Add(this.txtResultado);
            this.gbxResultado.Location = new System.Drawing.Point(19, 134);
            this.gbxResultado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxResultado.Size = new System.Drawing.Size(408, 335);
            this.gbxResultado.TabIndex = 1;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(17, 73);
            this.btnAnalisar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // btnClassificar
            // 
            this.btnClassificar.Location = new System.Drawing.Point(98, 74);
            this.btnClassificar.Name = "btnClassificar";
            this.btnClassificar.Size = new System.Drawing.Size(100, 23);
            this.btnClassificar.TabIndex = 3;
            this.btnClassificar.Text = "Classificar";
            this.btnClassificar.UseVisualStyleBackColor = true;
            this.btnClassificar.Click += new System.EventHandler(this.btnClassificar_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResultado.Location = new System.Drawing.Point(3, 17);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(402, 316);
            this.txtResultado.TabIndex = 0;
            // 
            // FrmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 480);
            this.Controls.Add(this.btnClassificar);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmAnalise";
            this.Text = "Analise";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxResultado.ResumeLayout(false);
            this.gbxResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSelecionarAudio;
        private System.Windows.Forms.TextBox txtArquivoAudio;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox gbxResultado;
        private System.Windows.Forms.Button btnAnalisar;
        private System.Windows.Forms.Button btnClassificar;
        private System.Windows.Forms.TextBox txtResultado;
    }
}