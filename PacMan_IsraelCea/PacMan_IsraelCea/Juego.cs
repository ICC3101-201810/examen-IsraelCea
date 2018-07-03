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
    public partial class PACMAN : Form
    {
        bool goup, godown, goleft, goright;
        int puntaje=0;
        int vmp = 6;//velocidad de movimiento de pacman
        int vm = 3;//velocidad fantasmas
        string jugador;
        


        public PACMAN()
        {
            InitializeComponent();
            UbicarPersonajes();
        }

        //Ubica a los personajes en la pantalla al iniciar el juego
        private void UbicarPersonajes()
        {
            //Centar pacman en la pantalla
            Pman.Left = (this.ClientSize.Width - Pman.Width) / 2;
            Pman.Top = (this.ClientSize.Height - Pman.Height) / 2;

            //Ubica aleatoriamente los fantasmas

            Random rnd = new Random();
            RedGhost.Left = rnd.Next(15, this.ClientSize.Width-15);
            RedGhost.Top = rnd.Next(15, this.ClientSize.Height-15);
            PinkGhost.Left = rnd.Next(15, this.ClientSize.Width-15);
            PinkGhost.Top = rnd.Next(15, this.ClientSize.Height-15);
        }

        //Método para cambiar la dirección de pacman cuando se presiona una tecla
        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                goright = false;
                goup = false;
                godown = false;
                Pman.Image = Properties.Resources.pacman_left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goleft = false;
                goright = true;
                goup = false;
                godown = false;
                Pman.Image = Properties.Resources.pacman_right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goleft = false;
                goright = false;
                goup = true;
                godown = false;
                Pman.Image = Properties.Resources.pacman_up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goleft = false;
                goright = false;
                goup = false;
                godown = true;
                Pman.Image = Properties.Resources.pacman_down;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }

        }
        //estos metodos calcula la distancia horizontal y vertical desde un punto cualquiera hasta pacman
        private int MirarPacmanX(int x)
        {
            int dx = Pman.Location.X-x;
            return dx;
        }
        private int MirarPacmanY(int y)
        {
            int dy = Pman.Location.Y - y;
            return dy;
        }

        //metodos que deciden donde debo mover al fantasma
        private List<bool> DondeMoverGhost(int px, int py)
        {
            //Horizontal, Vertical
            List<int> distancias = new List<int>();
            //izquierda,derecha,arriba,abajo
            List<bool> movimiento = new List<bool> { false, false, false, false };
            int dx = MirarPacmanX(px);
            int dy = MirarPacmanY(py);
            int dx2 = dx * dx;
            int dy2 = dy * dy;

            if (dx2 > dy2)
            {
                if (dx > 0)
                { movimiento[0] = true; }
                else if (dx < 0)
                { movimiento[1] = true; }
            }

            else if (dx2 < dy2)
            {
                if(dy>0)
                { movimiento[2]= true; }
                else if (dy<0)
                { movimiento[3]= true; }

            }
            return movimiento;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            labelPuntaje.Text = "Puntaje:" + puntaje;
            if(goup)
            {
                Pman.Top -= vmp;
            }

            if(godown)
            {
                Pman.Top += vmp;
            }

            if (goright)
            {
                Pman.Left += vmp;
            }
            
            if (goleft)
            {
                Pman.Left -= vmp;
            }

            //metodos para que choquen con los bordes de la form
            /*if(RedGhost.Bounds.IntersectsWith(this.Bounds))
            {
                RedGhost.Left = (-RedGhost.Left);
                RedGhost.Top = (-RedGhost.Top);
            }*/

            //Métodos para que los fantasman sigan a pacman
            int redX = RedGhost.Location.X;
            int redY = RedGhost.Location.Y;
            int pinkX = PinkGhost.Location.X;
            int pinkY = PinkGhost.Location.Y;
            List<bool> mRed  = DondeMoverGhost(redX, redY);
            if(mRed[0])
            { RedGhost.Left += vm; }
            else if (mRed[1])
            { RedGhost.Left -= vm; }
            else if (mRed[2])
            { RedGhost.Top += vm; }
            else if (mRed[3])
            { RedGhost.Top -= vm; }
            List<bool> mPink = DondeMoverGhost(pinkX, pinkY);
            if (mPink[0])
            { PinkGhost.Left += vm; }
            else if (mPink[1])
            { PinkGhost.Left -= vm; }
            else if (mPink[2])
            { PinkGhost.Top += vm; }
            else if (mPink[3])
            { PinkGhost.Top -= vm; }
            //Puntaje por comer fruta
            if (Pman.Bounds.IntersectsWith(Cherry.Bounds))
            {
                puntaje += 15;
                Cherry.Left = 100000;
                Cherry.Top = 100000;

            }

            if (Pman.Bounds.IntersectsWith(Uva.Bounds))
            {
                puntaje += 10;
                Uva.Visible = false;
                Uva.Left = 100000;
                Uva.Top = 100000;
            
            }

            //Pierde si lo toca un fantasma

            if (Pman.Bounds.IntersectsWith(RedGhost.Bounds))
            {
                this.Close();
                GameOver fin = new GameOver();
                fin.Show();
                
                

            }

            if(Pman.Bounds.IntersectsWith(Uva.Bounds))
            {
                this.Close();
                GameOver fin = new GameOver();
                fin.Show();
            }


            
        }

    }
}
