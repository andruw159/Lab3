namespace Lab3
{
    partial class GameConfigForm
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
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.txtEndulzadaIdeal = new System.Windows.Forms.TextBox();
            this.txtRegaloIdeal = new System.Windows.Forms.TextBox();
            this.txtCorreoJugador = new System.Windows.Forms.TextBox();
            this.btnAgregarjugador = new System.Windows.Forms.Button();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.lstJugadores = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtNombreJugador
            // 
            this.txtNombreJugador.Location = new System.Drawing.Point(119, 28);
            this.txtNombreJugador.Name = "txtNombreJugador";
            this.txtNombreJugador.Size = new System.Drawing.Size(95, 22);
            this.txtNombreJugador.TabIndex = 0;
            // 
            // txtEndulzadaIdeal
            // 
            this.txtEndulzadaIdeal.Location = new System.Drawing.Point(119, 117);
            this.txtEndulzadaIdeal.Name = "txtEndulzadaIdeal";
            this.txtEndulzadaIdeal.Size = new System.Drawing.Size(95, 22);
            this.txtEndulzadaIdeal.TabIndex = 1;
            // 
            // txtRegaloIdeal
            // 
            this.txtRegaloIdeal.Location = new System.Drawing.Point(119, 163);
            this.txtRegaloIdeal.Name = "txtRegaloIdeal";
            this.txtRegaloIdeal.Size = new System.Drawing.Size(95, 22);
            this.txtRegaloIdeal.TabIndex = 2;
            // 
            // txtCorreoJugador
            // 
            this.txtCorreoJugador.Location = new System.Drawing.Point(119, 73);
            this.txtCorreoJugador.Name = "txtCorreoJugador";
            this.txtCorreoJugador.Size = new System.Drawing.Size(95, 22);
            this.txtCorreoJugador.TabIndex = 3;
            // 
            // btnAgregarjugador
            // 
            this.btnAgregarjugador.Location = new System.Drawing.Point(359, 227);
            this.btnAgregarjugador.Name = "btnAgregarjugador";
            this.btnAgregarjugador.Size = new System.Drawing.Size(68, 33);
            this.btnAgregarjugador.TabIndex = 4;
            this.btnAgregarjugador.Text = "button1";
            this.btnAgregarjugador.UseVisualStyleBackColor = true;
            this.btnAgregarjugador.Click += new System.EventHandler(this.btnAgregarjugador_Click);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(493, 227);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(68, 33);
            this.btnFinalizar.TabIndex = 5;
            this.btnFinalizar.Text = "button2";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // lstJugadores
            // 
            this.lstJugadores.FormattingEnabled = true;
            this.lstJugadores.ItemHeight = 16;
            this.lstJugadores.Location = new System.Drawing.Point(71, 227);
            this.lstJugadores.Name = "lstJugadores";
            this.lstJugadores.Size = new System.Drawing.Size(109, 68);
            this.lstJugadores.TabIndex = 6;
            // 
            // GameConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lstJugadores);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.btnAgregarjugador);
            this.Controls.Add(this.txtCorreoJugador);
            this.Controls.Add(this.txtRegaloIdeal);
            this.Controls.Add(this.txtEndulzadaIdeal);
            this.Controls.Add(this.txtNombreJugador);
            this.Name = "GameConfigForm";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.TextBox txtEndulzadaIdeal;
        private System.Windows.Forms.TextBox txtRegaloIdeal;
        private System.Windows.Forms.TextBox txtCorreoJugador;
        private System.Windows.Forms.Button btnAgregarjugador;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListBox lstJugadores;
    }
}