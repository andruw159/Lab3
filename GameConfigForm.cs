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
    public partial class GameConfigForm : Form
    {
        public GameConfigForm (AmigoSecreto amigoSecreto)
        {
            InitializeComponent();

            // Asignar la instancia de AmigoSecreto a la variable local
            juego = amigoSecreto;

            // Inicializar la lista de Jugadores si es nula
            if (juego.Jugadores == null)
            {
                juego.Jugadores = new List<Jugador>();
            }
        }

        private void btnAgregarjugador_Click(object sender, EventArgs e)
        {
            // Crear un nuevo jugador a partir de los campos ingresados.
            Jugador nuevoJugador = new Jugador(
                txtNombreJugador.Text,
                txtCorreoJugador.Text,
                txtEndulzadaIdeal.Text,
                txtRegaloIdeal.Text);

            // Agregar el nuevo jugador a la lista de jugadores en el objeto `AmigoSecreto`.
            juego.Jugadores.Add(nuevoJugador);

            // Agregar el nombre del jugador a la ListBox para visualización.
            lstJugadores.Items.Add(nuevoJugador.Nombre);

            // Limpiar los TextBox para ingresar un nuevo jugador.
            txtNombreJugador.Clear();
            txtCorreoJugador.Clear();
            txtEndulzadaIdeal.Clear();
            txtRegaloIdeal.Clear();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            // Asignar amigos secretos.
            juego.AsignarAmigosSecretos();

            // Aquí, puedes optar por mostrar una confirmación, abrir un tercer formulario para jugar,
            // o cualquier otra acción que desees realizar después de configurar el juego.
            MessageBox.Show("Amigos secretos asignados exitosamente!");

            // Cerrar este formulario y volver al principal, o ir a un tercer formulario.
            this.Close();
        }
    }
}
