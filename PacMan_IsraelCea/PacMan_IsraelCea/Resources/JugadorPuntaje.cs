using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PacMan_IsraelCea.Resources
{   
    [Serializable]
    class JugadorPuntaje
    {
        string jugador;
        int puntaje;
        public JugadorPuntaje( string jugador, int puntaje)
        {
            this.jugador = jugador;
            this.puntaje = puntaje;
        }
    }
}
