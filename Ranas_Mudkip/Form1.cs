using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ranas_Mudkip
{
    public partial class Form1 : Form
    {
        string[] posiciones = new string[7];
        int x;
        int x2;
        public Form1()
        {
            InitializeComponent();
            
        }

        public bool Verificar()
        {
            if (posiciones[x] == "FALSE")
            {
                return true;
            }
            else
            {
                return false;
            }

        } 

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.background;
            posiciones[0] = "AZUL";
            posiciones[1] = "AZUL";
            posiciones[2] = "AZUL";
            posiciones[3] = "FALSE";
            posiciones[4] = "ROJO";
            posiciones[5] = "ROJO";
            posiciones[6] = "ROJO";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            x2 = 0;
            x = x2 + 1;
            if (Verificar() == true && posiciones[x - 1] == "AZUL")
            {
                posiciones[0] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox1.Image = null;
                pictureBox2.Image = Properties.Resources._258;
            }
            x = x2 + 2;
            if (Verificar() == true && posiciones[x - 2] == "AZUL")
            {
                posiciones[0] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox1.Image = null;
                pictureBox3.Image = Properties.Resources._258;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            x2 = 1;
            x = x2 + 1;
            if (Verificar() == true && posiciones[x - 1] == "AZUL")
            {
                posiciones[1] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox2.Image = null;
                pictureBox3.Image = Properties.Resources._258;
            }
            x = x2 + 2;
            if (Verificar() == true && posiciones[x - 2] == "AZUL")
            {
                posiciones[1] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox2.Image = null;
                pictureBox4.Image = Properties.Resources._258;
            }
            x = x2 - 1;
            if (Verificar() == true &&  posiciones[x+1] == "ROJO" )
            {
                posiciones[1] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox2.Image = null;
                pictureBox1.Image = Properties.Resources._2582;
            }
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            x2 = 2;
            x = x2 + 1;
            if (Verificar() == true && posiciones[x - 1] == "AZUL")
            {
                posiciones[2] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox3.Image = null;
                pictureBox4.Image = Properties.Resources._258;
            }
            x = x2 + 2;
            if (Verificar() == true && posiciones[x - 2] == "AZUL")
            {
                posiciones[2] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox3.Image = null;
                pictureBox5.Image = Properties.Resources._258;
            }
            x = x2 - 1;
            if (Verificar() == true && posiciones[x + 1] == "ROJO")
            {
                posiciones[2] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox3.Image = null;
                pictureBox2.Image = Properties.Resources._2582;
            }
            x = x2 - 2;
            if (Verificar() == true && posiciones[x + 2] == "ROJO")
            {
                posiciones[2] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox3.Image = null;
                pictureBox1.Image = Properties.Resources._2582;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            x2 = 3;
            x = x2 + 1;
            if (Verificar() == true && posiciones[x - 1] == "AZUL")
            {
                posiciones[3] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox4.Image = null;
                pictureBox5.Image = Properties.Resources._258;
            }
            x = x2 + 2;
            if (Verificar() == true && posiciones[x - 2] == "AZUL")
            {
                posiciones[3] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox4.Image = null;
                pictureBox6.Image = Properties.Resources._258;
            }
            x = x2 - 1;
            if (Verificar() == true && posiciones[x + 1] == "ROJO")
            {
                posiciones[3] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox4.Image = null;
                pictureBox3.Image = Properties.Resources._2582;
            }
            x = x2 - 2;
            if (Verificar() == true && posiciones[x + 2] == "ROJO")
            {
                posiciones[3] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox4.Image = null;
                pictureBox2.Image = Properties.Resources._2582;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            x2 = 4;
            x = x2 + 1;
            if (Verificar() == true && posiciones[x - 1] == "AZUL")
            {
                posiciones[4] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox5.Image = null;
                pictureBox6.Image = Properties.Resources._258;
            }
            x = x2 + 2;
            if (Verificar() == true && posiciones[x - 2] == "AZUL")
            {
                posiciones[4] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox5.Image = null;
                pictureBox7.Image = Properties.Resources._258;
            }
            x = x2 - 1;
            if (Verificar() == true && posiciones[x + 1] == "ROJO")
            {
                posiciones[4] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox5.Image = null;
                pictureBox4.Image = Properties.Resources._2582;
            }
            x = x2 - 2;
            if (Verificar() == true && posiciones[x + 2] == "ROJO")
            {
                posiciones[4] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox5.Image = null;
                pictureBox3.Image = Properties.Resources._2582;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            x2 = 5;
            x = x2 + 1;
            if (Verificar() == true && posiciones[x - 1] == "AZUL")
            {
                posiciones[5] = "FALSE";
                posiciones[x] = "AZUL";
                pictureBox6.Image = null;
                pictureBox7.Image = Properties.Resources._258;
            }            
            x = x2 - 1;
            if (Verificar() == true && posiciones[x + 1] == "ROJO")
            {
                posiciones[5] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox6.Image = null;
                pictureBox5.Image = Properties.Resources._2582;
            }
            x = x2 - 2;
            if (Verificar() == true && posiciones[x + 2] == "ROJO")
            {
                posiciones[5] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox6.Image = null;
                pictureBox4.Image = Properties.Resources._2582;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            x2 = 6;            
            x = x2 - 1;
            if (Verificar() == true && posiciones[x + 1] == "ROJO")
            {
                posiciones[6] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox7.Image = null;
                pictureBox6.Image = Properties.Resources._2582;
            }
            x = x2 - 2;
            if (Verificar() == true && posiciones[x + 2] == "ROJO")
            {
                posiciones[6] = "FALSE";
                posiciones[x] = "ROJO";
                pictureBox7.Image = null;
                pictureBox5.Image = Properties.Resources._2582;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            posiciones[0] = "AZUL";
            posiciones[1] = "AZUL";
            posiciones[2] = "AZUL";
            posiciones[3] = "FALSE";
            posiciones[4] = "ROJO";
            posiciones[5] = "ROJO";
            posiciones[6] = "ROJO";
            pictureBox1.Image = Properties.Resources._258;
            pictureBox2.Image = Properties.Resources._258;
            pictureBox3.Image = Properties.Resources._258;
            pictureBox4.Image = null;
            pictureBox5.Image = Properties.Resources._2582;
            pictureBox6.Image = Properties.Resources._2582;
            pictureBox7.Image = Properties.Resources._2582;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            posiciones[0] = "AZUL";
            posiciones[1] = "AZUL";
            posiciones[2] = "AZUL";
            posiciones[3] = "FALSE";
            posiciones[4] = "ROJO";
            posiciones[5] = "ROJO";
            posiciones[6] = "ROJO";
            pictureBox1.Image = Properties.Resources._258;
            pictureBox2.Image = Properties.Resources._258;
            pictureBox3.Image = Properties.Resources._258;
            pictureBox4.Image = null;
            pictureBox5.Image = Properties.Resources._2582;
            pictureBox6.Image = Properties.Resources._2582;
            pictureBox7.Image = Properties.Resources._2582;
        }

    }
}
