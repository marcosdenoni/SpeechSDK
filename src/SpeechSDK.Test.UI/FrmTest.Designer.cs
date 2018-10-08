namespace SpeechSDK.Test.UI
{
    partial class FrmTest
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
            this.gbxModelosCadastrados = new System.Windows.Forms.GroupBox();
            this.btnEditarModelos = new System.Windows.Forms.Button();
            this.gbxAnalise = new System.Windows.Forms.GroupBox();
            this.btnAnalisarAudio = new System.Windows.Forms.Button();
            this.gbxModelosCadastrados.SuspendLayout();
            this.gbxAnalise.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxModelosCadastrados
            // 
            this.gbxModelosCadastrados.Controls.Add(this.btnEditarModelos);
            this.gbxModelosCadastrados.Location = new System.Drawing.Point(12, 12);
            this.gbxModelosCadastrados.Name = "gbxModelosCadastrados";
            this.gbxModelosCadastrados.Size = new System.Drawing.Size(256, 169);
            this.gbxModelosCadastrados.TabIndex = 0;
            this.gbxModelosCadastrados.TabStop = false;
            this.gbxModelosCadastrados.Text = "Modelos Cadastrados";
            // 
            // btnEditarModelos
            // 
            this.btnEditarModelos.Location = new System.Drawing.Point(44, 53);
            this.btnEditarModelos.Name = "btnEditarModelos";
            this.btnEditarModelos.Size = new System.Drawing.Size(153, 68);
            this.btnEditarModelos.TabIndex = 0;
            this.btnEditarModelos.Text = "Editar Modelos";
            this.btnEditarModelos.UseVisualStyleBackColor = true;
            this.btnEditarModelos.Click += new System.EventHandler(this.btnEditarModelos_Click);
            // 
            // gbxAnalise
            // 
            this.gbxAnalise.Controls.Add(this.btnAnalisarAudio);
            this.gbxAnalise.Location = new System.Drawing.Point(274, 12);
            this.gbxAnalise.Name = "gbxAnalise";
            this.gbxAnalise.Size = new System.Drawing.Size(256, 169);
            this.gbxAnalise.TabIndex = 0;
            this.gbxAnalise.TabStop = false;
            this.gbxAnalise.Text = "Analise Áudio";
            // 
            // btnAnalisarAudio
            // 
            this.btnAnalisarAudio.Location = new System.Drawing.Point(49, 53);
            this.btnAnalisarAudio.Name = "btnAnalisarAudio";
            this.btnAnalisarAudio.Size = new System.Drawing.Size(153, 68);
            this.btnAnalisarAudio.TabIndex = 0;
            this.btnAnalisarAudio.Text = "Analisar Áudio";
            this.btnAnalisarAudio.UseVisualStyleBackColor = true;
            this.btnAnalisarAudio.Click += new System.EventHandler(this.btnAnalisarAudio_Click);
            // 
            // FrmTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 197);
            this.Controls.Add(this.gbxAnalise);
            this.Controls.Add(this.gbxModelosCadastrados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmTest";
            this.Text = "Speech SDK Test";
            this.gbxModelosCadastrados.ResumeLayout(false);
            this.gbxAnalise.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxModelosCadastrados;
        private System.Windows.Forms.Button btnEditarModelos;
        private System.Windows.Forms.GroupBox gbxAnalise;
        private System.Windows.Forms.Button btnAnalisarAudio;
    }
}

