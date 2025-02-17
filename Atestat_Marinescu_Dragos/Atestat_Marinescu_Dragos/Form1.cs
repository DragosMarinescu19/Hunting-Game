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
    public partial class Form1 : Form
    {

        PictureBox[] pb;
        int nrc, nrv = -1, vanate = 0, ratate = 0;

        public Form1()
        {
            
            int i;
            InitializeComponent();
            pb = new PictureBox[5];
            pb[1] = pictureBox5;
            pb[2] = pictureBox6;
            pb[3] = pictureBox7;
            pb[4] = pictureBox8;

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
            label3.Text = "Rate vanate : " + vanate;
            label4.Text = "Rate ratate : " + ratate;
            if (vanate == 10)
            {
                double p;
                p = ((double)vanate / (vanate + ratate) * 100);


                MessageBox.Show("Ati castigat jocul, procentajul de reusita este " + p + " %");

                timer2.Stop();
                Nivel2 nivel2 = new Nivel2();
                nivel2.Show();



            }
            else
                if (ratate == 10)
            {
                double p;
                p = ((double)vanate / (vanate + ratate) * 100);
                MessageBox.Show("Ati pierdut jocul, procentajul de reusita este " + p + "%");
                timer2.Stop();
            }


        }


        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Trebuie sa prindeti 10 rate");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            timer2.Start();
            vanate = 0;
            ratate = 0;
            label3.Text = "Rate vanate : " + vanate;
            label4.Text = "Rate ratate : " + ratate;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
            Random r = new Random();
            nrc = r.Next(1, 5);
            switch (nrc)
            {
                case 1:
                    pb[1].Image = Properties.Resources.rata;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.rata;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.rata;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.rata;
                    break;
            }
            switch (nrv)
            {
                case 1:
                    pb[1].Image = Properties.Resources.tinta;
                    break;
                case 2:
                    pb[2].Image = Properties.Resources.tinta;
                    break;
                case 3:
                    pb[3].Image = Properties.Resources.tinta;
                    break;
                case 4:
                    pb[4].Image = Properties.Resources.tinta;
                    break;
            }

            nrv = nrc;

        }
    }

}


       
        

        
