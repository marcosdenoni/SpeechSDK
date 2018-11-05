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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionarAudio);
            this.groupBox1.Controls.Add(this.txtArquivoAudio);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(310, 46);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo de Áudio";
            // 
            // btnSelecionarAudio
            // 
            this.btnSelecionarAudio.Location = new System.Drawing.Point(268, 16);
            this.btnSelecionarAudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecionarAudio.Name = "btnSelecionarAudio";
            this.btnSelecionarAudio.Size = new System.Drawing.Size(25, 19);
            this.btnSelecionarAudio.TabIndex = 1;
            this.btnSelecionarAudio.Text = "...";
            this.btnSelecionarAudio.UseVisualStyleBackColor = true;
            // 
            // txtArquivoAudio
            // 
            this.txtArquivoAudio.Location = new System.Drawing.Point(4, 17);
            this.txtArquivoAudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArquivoAudio.Name = "txtArquivoAudio";
            this.txtArquivoAudio.Size = new System.Drawing.Size(260, 20);
            this.txtArquivoAudio.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gbxResultado
            // 
            this.gbxResultado.Controls.Add(this.label7);
            this.gbxResultado.Controls.Add(this.label6);
            this.gbxResultado.Controls.Add(this.label4);
            this.gbxResultado.Controls.Add(this.label2);
            this.gbxResultado.Controls.Add(this.label5);
            this.gbxResultado.Controls.Add(this.label1);
            this.gbxResultado.Controls.Add(this.label3);
            this.gbxResultado.Controls.Add(this.lblIdModelo);
            this.gbxResultado.Location = new System.Drawing.Point(14, 109);
            this.gbxResultado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxResultado.Size = new System.Drawing.Size(306, 198);
            this.gbxResultado.TabIndex = 1;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(74, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "700 ms";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 93);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tempo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 68);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ton Kinn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "78";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heurística:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "1";
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Location = new System.Drawing.Point(15, 24);
            this.lblIdModelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(57, 13);
            this.lblIdModelo.TabIndex = 0;
            this.lblIdModelo.Text = "Id Modelo:";
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(122, 61);
            this.btnAnalisar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(56, 19);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            this.btnAnalisar.Click += new System.EventHandler(this.btnAnalisar_Click);
            // 
            // FrmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 317);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblIdModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}