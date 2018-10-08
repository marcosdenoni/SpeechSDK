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
            this.txtArquivoAudio = new System.Windows.Forms.TextBox();
            this.btnSelecionarAudio = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gbxResultado = new System.Windows.Forms.GroupBox();
            this.btnAnalisar = new System.Windows.Forms.Button();
            this.lblIdModelo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbxResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSelecionarAudio);
            this.groupBox1.Controls.Add(this.txtArquivoAudio);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 57);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arquivo de Áudio";
            // 
            // txtArquivoAudio
            // 
            this.txtArquivoAudio.Location = new System.Drawing.Point(6, 21);
            this.txtArquivoAudio.Name = "txtArquivoAudio";
            this.txtArquivoAudio.Size = new System.Drawing.Size(346, 22);
            this.txtArquivoAudio.TabIndex = 0;
            // 
            // btnSelecionarAudio
            // 
            this.btnSelecionarAudio.Location = new System.Drawing.Point(358, 20);
            this.btnSelecionarAudio.Name = "btnSelecionarAudio";
            this.btnSelecionarAudio.Size = new System.Drawing.Size(33, 23);
            this.btnSelecionarAudio.TabIndex = 1;
            this.btnSelecionarAudio.Text = "...";
            this.btnSelecionarAudio.UseVisualStyleBackColor = true;
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
            this.gbxResultado.Location = new System.Drawing.Point(18, 134);
            this.gbxResultado.Name = "gbxResultado";
            this.gbxResultado.Size = new System.Drawing.Size(408, 244);
            this.gbxResultado.TabIndex = 1;
            this.gbxResultado.TabStop = false;
            this.gbxResultado.Text = "Resultado";
            // 
            // btnAnalisar
            // 
            this.btnAnalisar.Location = new System.Drawing.Point(163, 75);
            this.btnAnalisar.Name = "btnAnalisar";
            this.btnAnalisar.Size = new System.Drawing.Size(75, 23);
            this.btnAnalisar.TabIndex = 2;
            this.btnAnalisar.Text = "Analisar";
            this.btnAnalisar.UseVisualStyleBackColor = true;
            // 
            // lblIdModelo
            // 
            this.lblIdModelo.AutoSize = true;
            this.lblIdModelo.Location = new System.Drawing.Point(20, 29);
            this.lblIdModelo.Name = "lblIdModelo";
            this.lblIdModelo.Size = new System.Drawing.Size(73, 17);
            this.lblIdModelo.TabIndex = 0;
            this.lblIdModelo.Text = "Id Modelo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Heurística:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Modelo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(99, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "78";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Ton Kinn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tempo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(99, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "700 ms";
            // 
            // FrmAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 390);
            this.Controls.Add(this.btnAnalisar);
            this.Controls.Add(this.gbxResultado);
            this.Controls.Add(this.groupBox1);
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