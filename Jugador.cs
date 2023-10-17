using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Jugador
    {
        // Auto-propiedades
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string EndulzadaIdeal { get; set; }
        public string RegaloIdeal { get; set; }
        public Jugador AmigoSecreto { get; set; }

        // Constructor
        public Jugador(string nombre, string correo, string endulzadaIdeal, string regaloIdeal)
        {
            // Aquí podrías agregar validaciones, si lo consideras necesario
            Nombre = nombre;
            Correo = correo;
            EndulzadaIdeal = endulzadaIdeal;
            RegaloIdeal = regaloIdeal;
        }

        // Sobrescritura del método ToString
        public override string ToString()
        {
            return "Jugador: " + Nombre + ", " + Correo + ", " + EndulzadaIdeal + ", " + RegaloIdeal;
        }
    }
}

