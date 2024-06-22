namespace Exercicios
{
    partial class FrmPrincipal
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
            gpxPrincipal = new GroupBox();
            btnChamados = new Button();
            btnUsuarios = new Button();
            btnSair = new Button();
            gpxPrincipal.SuspendLayout();
            SuspendLayout();
            // 
            // gpxPrincipal
            // 
            gpxPrincipal.Controls.Add(btnChamados);
            gpxPrincipal.Controls.Add(btnUsuarios);
            gpxPrincipal.Location = new Point(171, 84);
            gpxPrincipal.Name = "gpxPrincipal";
            gpxPrincipal.Size = new Size(450, 200);
            gpxPrincipal.TabIndex = 0;
            gpxPrincipal.TabStop = false;
            // 
            // btnChamados
            // 
            btnChamados.BackColor = Color.FromArgb(192, 255, 255);
            btnChamados.ForeColor = Color.Black;
            btnChamados.Location = new Point(263, 30);
            btnChamados.Name = "btnChamados";
            btnChamados.Size = new Size(150, 150);
            btnChamados.TabIndex = 1;
            btnChamados.Text = "Chamados";
            btnChamados.UseVisualStyleBackColor = false;
            btnChamados.Click += btnChamados_Click;
            // 
            // btnUsuarios
            // 
            btnUsuarios.BackColor = Color.FromArgb(192, 255, 192);
            btnUsuarios.ForeColor = Color.Black;
            btnUsuarios.Location = new Point(33, 30);
            btnUsuarios.Name = "btnUsuarios";
            btnUsuarios.Size = new Size(150, 150);
            btnUsuarios.TabIndex = 0;
            btnUsuarios.Text = "Usuários";
            btnUsuarios.UseVisualStyleBackColor = false;
            btnUsuarios.Click += btnUsuarios_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(255, 128, 128);
            btnSair.Location = new Point(12, 388);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(100, 50);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSair);
            Controls.Add(gpxPrincipal);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmPrincipal";
            Load += FrmPrincipal_Load;
            gpxPrincipal.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gpxPrincipal;
        private Button btnChamados;
        private Button btnUsuarios;
        private Button btnSair;
    }
}