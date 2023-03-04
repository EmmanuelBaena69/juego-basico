using System.Security.AccessControl;
using System.Security.Cryptography.Xml;
using System.Windows.Forms;

namespace juego_pai
{
    public partial class Form1 : Form
    {
        float velocidad = 15;
        int x;
        int y;
        bool limiteLeft = false;
        bool limiteRaight = false;
        public Form1()
        {
            InitializeComponent();
        }

        //manejar con las flechas
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                this.picNave.Location = new Point(picNave.Location.X + 20, picNave.Location.Y);
            }
            else if (e.KeyCode == Keys.Left)
            {
                this.picNave.Location = new Point(picNave.Location.X - 20, picNave.Location.Y);
            }
        }

        private void tmrStart_Tick(object sender, EventArgs e)
        {
            picMonster.Left += (int)velocidad;

            if (picMonster.Right > ClientSize.Width)
            {
                velocidad *= -1;
            }
            else if (picMonster.Left < 0)
            {
                velocidad *= -1;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrStart.Enabled = true;
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            tmrStart.Enabled = false;
        }

        private void picNave_Click(object sender, EventArgs e)
        {
            if (picNave.Location.X >= ClientSize.Width)
            {
                picNave.Location = new Point(picNave.Location.X, y);
            }
            else if (picNave.Location.X <= 0)
            {
                picNave.Location = new Point(picNave.Location.X, y);
            }
        }
    }
}