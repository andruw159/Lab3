using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnConfigurarJuego_Click(object sender, EventArgs e)
        {
            int numJugadores = (int)nudCantidadJugadores.Value;

            // Crear instancia de AmigoSecreto.
            AmigoSecreto juego = new AmigoSecreto();
            juego.CantidadJugadores = numJugadores;

            // Pasar al formulario de configuración del juego.
            GameConfigForm gameConfig = new GameConfigForm(juego);
            gameConfig.Show();
            this.Hide();
        }
    }
}
