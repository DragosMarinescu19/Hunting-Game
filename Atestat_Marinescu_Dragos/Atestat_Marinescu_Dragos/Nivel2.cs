using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atestat_Marinescu_Dragos
{
    public partial class Nivel2 : Form
    {
        PictureBox[] pb;
        int nrc, nrv = -1, vanate = 0, ratate = 0;
        public Nivel2()
        {
            int i;
            InitializeComponent();
            pb = new PictureBox[5];
            pb[1] = pictureBox1;
            pb[2] = pictureBox2;
            pb[3] = pictureBox3;
            pb[4] = pictureBox4;

            for (i = 1; i <= 4; i++)
                pb[i].Click += new System.EventHandler(clic_imagine);

            
        }
        private void clic_imagine(object sender, EventArgs e)
        {

            int i;
            for (i = 1; i <= 4; i++)

                if (sender == pb[i])
                    if (nrc == i)
                        vanate++;
                    else
                        ratate++;
            label1.Text = "Maimute vanate : " + vanate;
            label2.Text = "Maimute ratate : " + ratate;
            if (vanate == 20)
            {
                double p;
                p = ((double)vanate / (vanate + ratate) * 100);


                MessageBox.Show("Ati castigat jocul, procentajul de reusita este " + p + " %");
                timer1.Stop();


            }
            else
                if (ratate == 20)
            {
                double p;
                p = ((double)vanate / (vanate + ratate) * 100);
                MessageBox.Show("Ati pierdut jocul, procentajul de reusita este " + p + "%");
                timer1.Stop();
            }


        }


        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trebuie sa prindeti 20 de maimute");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Random r = new Random();
            nrc = r.Next(1, 5);
            switch (nrc)
            {
                case 1:
                    pb[1].Image = Properties.Resources.maimuta;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.maimuta;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.maimuta;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.maimuta;

                    break;
            }
            switch (nrv)
            {
                case 1:
                    pb[1].Image = Properties.Resources.bananier;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.bananier;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.bananier;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.bananier;
                    break;
            }

            nrv = nrc;

        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Start();
            vanate = 0;
            ratate = 0;
            label1.Text = "Maimute vanate : " + vanate;
            label2.Text = "Maimute ratate : " + ratate;
        }
        

            
    }
}
