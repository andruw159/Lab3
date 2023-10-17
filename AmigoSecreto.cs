using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class AmigoSecreto
    {
        private int cantidadJugadores;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private int numeroEndulzadas;
        private int frecuenciaEndulzadasDias;
        private decimal valorEndulzada;
        private decimal valorRegalo;
        private List<Jugador> jugadores = new List<Jugador>();  // Inicializando directamente aquí

        // Propiedades públicas
        public int CantidadJugadores
        {
            get { return cantidadJugadores; }
            set { cantidadJugadores = value; }
        }

        public DateTime FechaInicio
        {
            get { return fechaInicio; }
            set { fechaInicio = value; }
        }

        public DateTime FechaFin
        {
            get { return fechaFin; }
            set { fechaFin = value; }
        }

        public int NumeroEndulzadas
        {
            get { return numeroEndulzadas; }
            set { numeroEndulzadas = value; }
        }

        public int FrecuenciaEndulzadasDias
        {
            get { return frecuenciaEndulzadasDias; }
            set { frecuenciaEndulzadasDias = value; }
        }

        public decimal ValorEndulzada
        {
            get { return valorEndulzada; }
            set { valorEndulzada = value; }
        }

        public decimal ValorRegalo
        {
            get { return valorRegalo; }
            set { valorRegalo = value; }
        }

        public List<Jugador> Jugadores => jugadores;

        // Métodos
        public void AgregarJugador(Jugador jugador)
        {
            jugadores.Add(jugador);
            cantidadJugadores++;
        }

        public void EliminarJugador(Jugador jugador)
        {
            jugadores.Remove(jugador);
            cantidadJugadores--;
        }

        public void AsignarAmigosSecretos()
        {
            if (jugadores.Count < 2)
            {
                throw new InvalidOperationException("Se necesitan al menos 2 jugadores para asignar amigos secretos.");
            }

            var posiblesAmigos = new List<Jugador>(jugadores);
            var random = new Random();

            foreach (var jugador in jugadores)
            {
                posiblesAmigos.Remove(jugador);

                var index = random.Next(posiblesAmigos.Count);
                jugador.AmigoSecreto = posiblesAmigos[index];

                posiblesAmigos.RemoveAt(index);
            }
        }

        public void ImprimirInformacionJuego()
        {
            Console.WriteLine("=== Información del Juego Amigo Secreto ===");

            Console.WriteLine($"Fecha de inicio: {FechaInicio.ToShortDateString()}");
            Console.WriteLine($"Fecha de finalización: {FechaFin.ToShortDateString()}");
            Console.WriteLine($"Cantidad de jugadores: {CantidadJugadores}");

            Console.WriteLine($"Número total de endulzadas: {NumeroEndulzadas}");
            Console.WriteLine($"Frecuencia de endulzadas (en días): {FrecuenciaEndulzadasDias}");
            Console.WriteLine($"Valor de la endulzada: ${ValorEndulzada}");
            Console.WriteLine($"Valor del regalo: ${ValorRegalo}");

            Console.WriteLine("=== Lista de Jugadores ===");
            foreach (var jugador in Jugadores)
            {
                Console.WriteLine(jugador.MostrarJugador());
            }
        }


        public void ImprimirGustosJugadores()
        {
            foreach (var jugador in jugadores)
            {
                Console.WriteLine(jugador.MostrarJugador());
            }
        }

        public void ProximaEndulzada(DateTime fechaActual)
        {
            if (fechaInicio == default)
            {
                throw new InvalidOperationException("La fecha de inicio no ha sido establecida.");
            }

            DateTime proximaEndulzada = fechaInicio;
            while (proximaEndulzada <= fechaActual)
            {
                proximaEndulzada = proximaEndulzada.AddDays(frecuenciaEndulzadasDias);
            }
            Console.WriteLine($"La próxima endulzada será el: {proximaEndulzada.ToShortDateString()}");
        }
    }
}
