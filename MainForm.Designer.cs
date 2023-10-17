namespace Lab3
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumJugadores = new System.Windows.Forms.Label();
            this.btnConfigurarJuego = new System.Windows.Forms.Button();
            this.nudCantidadJugadores = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadJugadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumJugadores
            // 
            this.lblNumJugadores.AutoSize = true;
            this.lblNumJugadores.Location = new System.Drawing.Point(214, 86);
            this.lblNumJugadores.Name = "lblNumJugadores";
            this.lblNumJugadores.Size = new System.Drawing.Size(230, 16);
            this.lblNumJugadores.TabIndex = 0;
            this.lblNumJugadores.Text = "Seleccione la cantidad de jugadores:";
            // 
            // btnConfigurarJuego
            // 
            this.btnConfigurarJuego.Location = new System.Drawing.Point(247, 178);
            this.btnConfigurarJuego.Name = "btnConfigurarJuego";
            this.btnConfigurarJuego.Size = new System.Drawing.Size(96, 23);
            this.btnConfigurarJuego.TabIndex = 1;
            this.btnConfigurarJuego.Text = "button1";
            this.btnConfigurarJuego.UseVisualStyleBackColor = true;
            this.btnConfigurarJuego.Click += new System.EventHandler(this.btnConfigurarJuego_Click);
            // 
            // nudCantidadJugadores
            // 
            this.nudCantidadJugadores.Location = new System.Drawing.Point(265, 127);
            this.nudCantidadJugadores.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudCantidadJugadores.Name = "nudCantidadJugadores";
            this.nudCantidadJugadores.Size = new System.Drawing.Size(78, 22);
            this.nudCantidadJugadores.TabIndex = 2;
            this.nudCantidadJugadores.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudCantidadJugadores);
            this.Controls.Add(this.btnConfigurarJuego);
            this.Controls.Add(this.lblNumJugadores);
            this.Name = "MainForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadJugadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumJugadores;
        private System.Windows.Forms.Button btnConfigurarJuego;
        private System.Windows.Forms.NumericUpDown nudCantidadJugadores;
    }
}

