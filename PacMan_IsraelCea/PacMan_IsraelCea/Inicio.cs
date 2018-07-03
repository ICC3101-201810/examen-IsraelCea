using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PacMan_IsraelCea
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IniciarJuego(object sender, EventArgs e)
        {
            PACMAN pantallaJuego = new PACMAN();
            pantallaJuego.Show();
        }

        private void MostrarRanking(object sender, EventArgs e)
        {
            Ranking pantallaRanking = new Ranking();
            pantallaRanking.Show();
        }
    }
}
