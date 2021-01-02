using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        Random Poisition = new Random();
        List<Point> points = new List<Point>();
        PictureBox PickFT=null, PickND=null;
        int Cl = 0;
        int SC = 0;
        private void Update_SC()
        {
            foreach (PictureBox picture in panel1.Controls)
                picture.Enabled = false;

            ++Cl;
            label2.Text = Convert.ToString(Cl);
            if (PickFT.Tag == PickND.Tag) timer4.Start();
            else timer3.Start();
        }

        private void ST()
        {
            if (Convert.ToInt32(label4.Text) == 0) {
                label4.Visible = false;
                label3.Visible = false;
                foreach (PictureBox picture in panel1.Controls)
                {
                    picture.Enabled = true;
                    picture.Cursor = Cursors.Hand;
                    picture.BackgroundImage = Properties.Resources.im0;
                }
            }
            else {
            timer1.Interval = Convert.ToInt32(label4.Text) * 1000;
            timer1.Start();
            timer2.Start();

            C1.BackgroundImage = Properties.Resources.im1;
            DC1.BackgroundImage = Properties.Resources.im1;
            C2.BackgroundImage = Properties.Resources.im2;
            DC2.BackgroundImage = Properties.Resources.im2;
            C3.BackgroundImage = Properties.Resources.im3;
            DC3.BackgroundImage = Properties.Resources.im3;
            C4.BackgroundImage = Properties.Resources.im4;
            DC4.BackgroundImage = Properties.Resources.im4;
            C5.BackgroundImage = Properties.Resources.im5;
            DC5.BackgroundImage = Properties.Resources.im5;
            C6.BackgroundImage = Properties.Resources.im6;
            DC6.BackgroundImage = Properties.Resources.im6;
            C7.BackgroundImage = Properties.Resources.im7;
            DC7.BackgroundImage = Properties.Resources.im7;
            C8.BackgroundImage = Properties.Resources.im8;
            DC8.BackgroundImage = Properties.Resources.im8;
            C9.BackgroundImage = Properties.Resources.im9;
            DC9.BackgroundImage = Properties.Resources.im9;
            C10.BackgroundImage = Properties.Resources.im10;
            DC10.BackgroundImage = Properties.Resources.im10;
            C11.BackgroundImage = Properties.Resources.im11;
            DC11.BackgroundImage = Properties.Resources.im11;
            C12.BackgroundImage = Properties.Resources.im12;
            DC12.BackgroundImage = Properties.Resources.im12;
            C13.BackgroundImage = Properties.Resources.im13;
            DC13.BackgroundImage = Properties.Resources.im13;
            C14.BackgroundImage = Properties.Resources.im14;
            DC14.BackgroundImage = Properties.Resources.im14;
            C15.BackgroundImage = Properties.Resources.im15;
            DC15.BackgroundImage = Properties.Resources.im15;
            C16.BackgroundImage = Properties.Resources.im18;
            DC16.BackgroundImage = Properties.Resources.im18;
            }
        }

        public Form3()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label2.Text = "0";
            panel1.SuspendLayout();
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }

            foreach (PictureBox picture in panel1.Controls)
            {
                int next = Poisition.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
                picture.BackgroundImage = Properties.Resources.im0;
            }

        }

        
       
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
                picture.BackgroundImage = Properties.Resources.im0;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label4.Text);
            --time;
            if (time!=0)
            {   
                if(time<10) label4.Text = "0"+Convert.ToString(time);
                else label4.Text = Convert.ToString(time);
            }
            else
            {
                timer2.Stop();
                label4.Visible = false;
                label3.Visible = false;
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PickFT.Enabled = true;
            PickND.Enabled = true;
            PickFT.BackgroundImage = Properties.Resources.im0;
            PickND.BackgroundImage = Properties.Resources.im0;
            PickFT = null;
            PickND = null;
            foreach (PictureBox picture in panel1.Controls)
                if (picture.Visible == true)
                    picture.Enabled = true;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            timer4.Stop();
            ++SC;
            PickFT.Visible = false;
            PickND.Visible = false;
            PickFT = null;
            PickND = null;
            
              foreach (PictureBox picture in panel1.Controls) 
                if (picture.Visible == true)
                    picture.Enabled = true;
            
        }

        private void C1_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                PickFT = C1;
                PickFT.BackgroundImage = Properties.Resources.im1;
                C1.Enabled = false;
                
            }
            else
            {
                C1.BackgroundImage = Properties.Resources.im1;
                PickND = C1;
                Update_SC();
            }
        }

        private void DC1_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC1.BackgroundImage = Properties.Resources.im1;
                DC1.Enabled = false;
                PickFT = DC1;
            }
            else
            {
                DC1.BackgroundImage = Properties.Resources.im1;
                PickND = DC1;
                Update_SC();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C2.BackgroundImage = Properties.Resources.im2;
                C2.Enabled = false;
                PickFT = C2;
            }
            else
            {
                C2.BackgroundImage = Properties.Resources.im2;
                PickND = C2;
                Update_SC();
            }
        }

        private void DC2_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC2.BackgroundImage = Properties.Resources.im2;
                DC2.Enabled = false;
                PickFT = DC2;
            }
            else
            {
                DC2.BackgroundImage = Properties.Resources.im2;
                PickND = DC2;
                Update_SC();
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C3.BackgroundImage = Properties.Resources.im3;
                C3.Enabled = false;
                PickFT = C3;
            }
            else
            {
                C3.BackgroundImage = Properties.Resources.im3;
                PickND = C3;
                Update_SC();
            }
        }

        private void DC3_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC3.BackgroundImage = Properties.Resources.im3;
                DC3.Enabled = false;
                PickFT = DC3;
            }
            else
            {
                DC3.BackgroundImage = Properties.Resources.im3;
                PickND = DC3;
                Update_SC();
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C4.BackgroundImage = Properties.Resources.im4;
                C4.Enabled = false;
                PickFT = C4;
            }
            else
            {
                C4.BackgroundImage = Properties.Resources.im4;
                PickND = C4;
                Update_SC();
            }
        }

        private void DC4_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC4.BackgroundImage = Properties.Resources.im4;
                DC4.Enabled = false;
                PickFT = DC4;
            }
            else
            {
                DC4.BackgroundImage = Properties.Resources.im4;
                PickND = DC4;
                Update_SC();
            }
        }

        private void DC8_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC8.BackgroundImage = Properties.Resources.im8;
                DC8.Enabled = false;
                PickFT = DC8;
            }
            else
            {
                DC8.BackgroundImage = Properties.Resources.im8;
                PickND = DC8;
                Update_SC();
            }
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C8.BackgroundImage = Properties.Resources.im8;
                C8.Enabled = false;
                PickFT = C8;
            }
            else
            {
                 C8.BackgroundImage = Properties.Resources.im8;
                PickND =  C8;
                Update_SC();
            }
        }

        private void DC7_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC7.BackgroundImage = Properties.Resources.im7;
                DC7.Enabled = false;
                PickFT = DC7;
            }
            else
            {
                DC7.BackgroundImage = Properties.Resources.im7;
                PickND = DC7;
                Update_SC();
            }
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C7.BackgroundImage = Properties.Resources.im7;
                C7.Enabled = false;
                PickFT = C7;
            }
            else
            {
                C7.BackgroundImage = Properties.Resources.im7;
                PickND = C7;
                Update_SC();
            }

        }

        private void DC6_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC6.BackgroundImage = Properties.Resources.im6;
                DC6.Enabled = false;
                PickFT = DC6;
            }
            else
            {
                DC6.BackgroundImage = Properties.Resources.im6;
                PickND = DC6;
                Update_SC();
            }
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C6.BackgroundImage = Properties.Resources.im6;
                C6.Enabled = false;
                PickFT = C6;
            }
            else
            {
                C6.BackgroundImage = Properties.Resources.im6;
                PickND = C6;
                Update_SC();
            }
        }

        private void DC5_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC5.BackgroundImage = Properties.Resources.im5;
                DC5.Enabled = false;
                PickFT = DC5;
            }
            else
            {
                DC5.BackgroundImage = Properties.Resources.im5;
                PickND = DC5;
                Update_SC();
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C5.BackgroundImage = Properties.Resources.im5;
                C5.Enabled = false;
                PickFT = C5;
            }
            else
            {
                C5.BackgroundImage = Properties.Resources.im5;
                PickND = C5;
                Update_SC();
            }
        }

        private void C9_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C9.BackgroundImage = Properties.Resources.im9;
                C9.Enabled = false;
                PickFT = C9;
            }
            else
            {
                C9.BackgroundImage = Properties.Resources.im9;
                PickND = C9;
                Update_SC();
            }
        }

        private void C13_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C13.BackgroundImage = Properties.Resources.im13;
                C13.Enabled = false;
                PickFT = C13;
            }
            else
            {
                C13.BackgroundImage = Properties.Resources.im13;
                PickND = C13;
                Update_SC();
            }
        }

       
        private void DC9_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC9.BackgroundImage = Properties.Resources.im9;
                DC9.Enabled = false;
                PickFT = DC9;
            }
            else
            {
                DC9.BackgroundImage = Properties.Resources.im9;
                PickND = DC9;
                Update_SC();
            }
        }

        private void DC16_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC16.BackgroundImage = Properties.Resources.im18;
                DC16.Enabled = false;
                PickFT = DC16;
            }
            else
            {
                DC16.BackgroundImage = Properties.Resources.im18;
                PickND = DC16;
                Update_SC();
            }
        }

        private void DC12_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC12.BackgroundImage = Properties.Resources.im12;
                DC12.Enabled = false;
                PickFT = DC12;
            }
            else
            {
                DC12.BackgroundImage = Properties.Resources.im12;
                PickND = DC12;
                Update_SC();
            }
        }

        private void C16_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C16.BackgroundImage = Properties.Resources.im18;
                C16.Enabled = false;
                PickFT = C16;
            }
            else
            {
                C16.BackgroundImage = Properties.Resources.im18;
                PickND = C16;
                Update_SC();
            }
        }

        private void DC13_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC13.BackgroundImage = Properties.Resources.im13;
                DC13.Enabled = false;
                PickFT = DC13;
            }
            else
            {
                DC13.BackgroundImage = Properties.Resources.im13;
                PickND = DC13;
                Update_SC();
            }
        }

        private void C12_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C12.BackgroundImage = Properties.Resources.im12;
                C12.Enabled = false;
                PickFT = C12;
            }
            else
            {
                C12.BackgroundImage = Properties.Resources.im12;
                PickND = C12;
                Update_SC();
            }

        }

        private void C10_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C10.BackgroundImage = Properties.Resources.im10;
                C10.Enabled = false;
                PickFT = C10;
            }
            else
            {
                C10.BackgroundImage = Properties.Resources.im10;
                PickND = C10;
                Update_SC();
            }
        }

        private void C14_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C14.BackgroundImage = Properties.Resources.im14;
                C14.Enabled = false;
                PickFT = C14;
            }
            else
            {
                C14.BackgroundImage = Properties.Resources.im14;
                PickND = C14;
                Update_SC();
            }
        }

        private void DC15_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC15.BackgroundImage = Properties.Resources.im15;
                DC15.Enabled = false;
                PickFT = DC15;
            }
            else
            {
                DC15.BackgroundImage = Properties.Resources.im15;
                PickND = DC15;
                Update_SC();
            }
        }

        private void DC11_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC11.BackgroundImage = Properties.Resources.im11;
                DC11.Enabled = false;
                PickFT = DC11;
            }
            else
            {
                DC11.BackgroundImage = Properties.Resources.im11;
                PickND = DC11;
                Update_SC();
            }
        }

        private void DC10_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC10.BackgroundImage = Properties.Resources.im10;
                DC10.Enabled = false;
                PickFT = DC10;
            }
            else
            {
                DC10.BackgroundImage = Properties.Resources.im10;
                PickND = DC10;
                Update_SC();
            }
        }

        private void DC14_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC14.BackgroundImage = Properties.Resources.im14;
                DC14.Enabled = false;
                PickFT = DC14;
            }
            else
            {
                DC14.BackgroundImage = Properties.Resources.im14;
                PickND = DC14;
                Update_SC();
            }
        }

        private void C15_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C15.BackgroundImage = Properties.Resources.im15;
                C15.Enabled = false;
                PickFT = C15;
            }
            else
            {
                C15.BackgroundImage = Properties.Resources.im15;
                PickND = C15;
                Update_SC();
            }
        }

        private void C11_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C11.BackgroundImage = Properties.Resources.im11;
                C11.Enabled = false;
                PickFT = C11;
            }
            else
            {
                C11.BackgroundImage = Properties.Resources.im11;
                PickND = C11;
                Update_SC();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {

            int time = Convert.ToInt32(label4.Text);
            --time;
            if (time < 10) label4.Text = "0" + Convert.ToString(time);
            else label4.Text = Convert.ToString(time);
            if (time == 0)
            {
                label5.Visible = false;
                label5.Enabled = false;
            }
            if(time == 59)
            {
                label6.Visible = true;
                label6.Enabled = true;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            int time = Convert.ToInt32(label4.Text);
            ++time;
            if(time<10) label4.Text = "0"+Convert.ToString(time);
            else label4.Text = Convert.ToString(time);
            if (time == 60)
            {
                label6.Visible = false;
                label6.Enabled = false;
            }

            if (time == 1)
            {
                label5.Visible = true;
                label5.Enabled = true;
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label6.Visible = false;
            label6.Enabled = false;
            label5.Visible = false;
            label5.Enabled = false;
            button3.Visible = false;
            button3.Enabled = false;
            ST();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }
    }
}
