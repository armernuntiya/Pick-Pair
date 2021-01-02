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
    public partial class Form2 : Form
    {
        Random Poisition = new Random();
        List<Point> points = new List<Point>();

        PictureBox PickFT,PickND;

        int SC = 0;

        int R_L = 0, B_L = 0, G_L = 0, S_L = 0;

        int R_R = 0, B_R = 0, G_R = 0, S_R = 0;

        int round = 0,num1,num2;

        private void Re_P()
        {   
            
            if (round == 0)
            {   if (R_L+B_L+G_L==0) Time_WP.Start();
                else if (R_L != 0)
                {
                    ReR_L.Visible = true;
                    ReR_L.Enabled = true;
                }
                if (B_L != 0)
                {
                    ReB_L.Visible = true;
                    ReB_L.Enabled = true;
                }
                if (G_L != 0)
                {
                    ReG_L.Visible = true;
                    ReG_L.Enabled = true;
                }
            }
            else
            {
                if (R_R+B_R+G_R==0) Time_WP.Start();
                else if (R_R != 0)
                {
                    ReR_R.Visible = true;
                    ReR_R.Enabled = true;
                }
                if (B_R != 0)
                {
                    ReB_R.Visible = true;
                    ReB_R.Enabled = true;
                }
                if (G_R != 0)
                {
                    ReG_R.Visible = true;
                    ReG_R.Enabled = true;
                }
            }
        }
        private void Update_SC()
        {
            num1 = Convert.ToInt32(PickFT.Tag);
            num2 = Convert.ToInt32(PickND.Tag);
            foreach (PictureBox picture in panel1.Controls)
                picture.Enabled = false;

            if ((num1 == num2) || (num1 == 20 && num2 != 19) || (num1 != 19 && num2 == 20)) Time_CP.Start();
            else if ((num1 == 19 && num2 != 20) || (num1 != 20 && num2 == 19)) Re_P();
            else Time_WP.Start();
        }

        private void Change_Round()
        {
            round = round ^ 1;
            if (round == 1)
            {
                RD_R.Visible = true;
                RD_L.Visible = false;
            }
            else
            {
                RD_R.Visible = false;
                RD_L.Visible = true;
            }
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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
            }



            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Enabled = false;
                picture.BackgroundImage = Properties.Resources.im0;
            }

        }
        private void C1_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {  
                C1.BackgroundImage = Properties.Resources.im1;
                C1.BackColor = Color.Red;
                C1.Enabled = false;
                PickFT = C1;
            }
            else
            {
                C1.BackgroundImage = Properties.Resources.im1;
                C1.BackColor = Color.Red;
                PickND = C1;
                Update_SC();
            }
        }

        private void DC1_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC1.BackgroundImage = Properties.Resources.im1;
                DC1.BackColor = Color.Red;
                DC1.Enabled = false;
                PickFT = DC1;
            }
            else
            {
                DC1.BackgroundImage = Properties.Resources.im1;
                DC1.BackColor = Color.Red;
                PickND = DC1;
                Update_SC();
            }
        }

        private void C2_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C2.BackgroundImage = Properties.Resources.im2;
                C2.BackColor = Color.Red;
                C2.Enabled = false;
                PickFT = C2;
            }
            else
            {
                C2.BackgroundImage = Properties.Resources.im2;
                C2.BackColor = Color.Red;
                PickND = C2;
                Update_SC();
            }
        }

        private void DC2_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC2.BackgroundImage = Properties.Resources.im2;
                DC2.BackColor = Color.Red;
                DC2.Enabled = false;
                PickFT = DC2;
            }
            else
            {
                DC2.BackgroundImage = Properties.Resources.im2;
                DC2.BackColor = Color.Red;
                PickND = DC2;
                Update_SC();
            }
        }

        private void C3_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C3.BackgroundImage = Properties.Resources.im3;
                C3.BackColor = Color.Red;
                C3.Enabled = false;
                PickFT = C3;
            }
            else
            {
                C3.BackgroundImage = Properties.Resources.im3;
                C3.BackColor = Color.Red;
                PickND = C3;
                Update_SC();
            }
        }

        private void DC3_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC3.BackgroundImage = Properties.Resources.im3;
                DC3.BackColor = Color.Red;
                DC3.Enabled = false;
                PickFT = DC3;
            }
            else
            {
                DC3.BackgroundImage = Properties.Resources.im3;
                DC3.BackColor = Color.Red;
                PickND = DC3;
                Update_SC();
            }
        }

        private void C4_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C4.BackgroundImage = Properties.Resources.im4;
                C4.BackColor = Color.Red;
                C4.Enabled = false;
                PickFT = C4;
            }
            else
            {
                C4.BackgroundImage = Properties.Resources.im4;
                C4.BackColor = Color.Red;
                PickND = C4;
                Update_SC();
            }
        }

        private void DC4_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC4.BackgroundImage = Properties.Resources.im4;
                DC4.BackColor = Color.Red;
                DC4.Enabled = false;
                PickFT = DC4;
            }
            else
            {
                DC4.BackgroundImage = Properties.Resources.im4;
                DC4.BackColor = Color.Red;
                PickND = DC4;
                Update_SC();
            }
        }

        private void DC8_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC8.BackgroundImage = Properties.Resources.im8;
                DC8.BackColor = Color.Lime;
                DC8.Enabled = false;
                PickFT = DC8;
            }
            else
            {
                DC8.BackgroundImage = Properties.Resources.im8;
                DC8.BackColor = Color.Lime;
                PickND = DC8;
                Update_SC();
            }
        }

        private void C8_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C8.BackgroundImage = Properties.Resources.im8;
                C8.BackColor = Color.Lime;
                C8.Enabled = false;
                PickFT = C8;
            }
            else
            {
                C8.BackgroundImage = Properties.Resources.im8;
                C8.BackColor = Color.Lime;
                PickND = C8;
                Update_SC();
            }
        }

        private void DC7_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC7.BackgroundImage = Properties.Resources.im7;
                DC7.BackColor = Color.Lime;
                DC7.Enabled = false;
                PickFT = DC7;
            }
            else
            {
                DC7.BackgroundImage = Properties.Resources.im7;
                DC7.BackColor = Color.Lime;
                PickND = DC7;
                Update_SC();
            }
        }

        private void C7_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C7.BackgroundImage = Properties.Resources.im7;
                C7.BackColor = Color.Lime;
                C7.Enabled = false;
                PickFT = C7;
            }
            else
            {
                C7.BackgroundImage = Properties.Resources.im7;
                C7.BackColor = Color.Lime;
                PickND = C7;
                Update_SC();
            }

        }

        private void DC6_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC6.BackgroundImage = Properties.Resources.im6;
                DC6.BackColor = Color.Lime;
                DC6.Enabled = false;
                PickFT = DC6;
            }
            else
            {
                DC6.BackgroundImage = Properties.Resources.im6;
                DC6.BackColor = Color.Lime;
                PickND = DC6;
                Update_SC();
            }
        }

        private void C6_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C6.BackgroundImage = Properties.Resources.im6;
                C6.BackColor = Color.Lime;
                C6.Enabled = false;
                PickFT = C6;
            }
            else
            {
                C6.BackgroundImage = Properties.Resources.im6;
                C6.BackColor = Color.Lime;
                PickND = C6;
                Update_SC();
            }
        }

        private void DC5_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC5.BackgroundImage = Properties.Resources.im5;
                DC5.BackColor = Color.Red;
                DC5.Enabled = false;
                PickFT = DC5;
            }
            else
            {
                DC5.BackgroundImage = Properties.Resources.im5;
                DC5.BackColor = Color.Red;
                PickND = DC5;
                Update_SC();
            }
        }

        private void C5_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C5.BackgroundImage = Properties.Resources.im5;
                C5.BackColor = Color.Red;
                C5.Enabled = false;
                PickFT = C5;
            }
            else
            {
                C5.BackgroundImage = Properties.Resources.im5;
                C5.BackColor = Color.Red;
                PickND = C5;
                Update_SC();
            }
        }

        private void C9_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C9.BackgroundImage = Properties.Resources.im9;
                C9.BackColor = Color.Lime;
                C9.Enabled = false;
                PickFT = C9;
            }
            else
            {
                C9.BackgroundImage = Properties.Resources.im9;
                C9.BackColor = Color.Lime;
                PickND = C9;
                Update_SC();
            }
        }

        private void C13_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C13.BackgroundImage = Properties.Resources.im13;
                C13.BackColor = Color.Blue;
                C13.Enabled = false;
                PickFT = C13;
            }
            else
            {
                C13.BackgroundImage = Properties.Resources.im13;
                C13.BackColor = Color.Blue;
                PickND = C13;
                Update_SC();
            }
        }


        private void DC9_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC9.BackgroundImage = Properties.Resources.im9;
                DC9.BackColor = Color.Lime;
                DC9.Enabled = false;
                PickFT = DC9;
            }
            else
            {
                DC9.BackgroundImage = Properties.Resources.im9;
                DC9.BackColor = Color.Lime;
                PickND = DC9;
                Update_SC();
            }
        }

        

        private void DC12_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC12.BackgroundImage = Properties.Resources.im12;
                DC12.BackColor = Color.Blue;
                DC12.Enabled = false;
                PickFT = DC12;
            }
            else
            {
                DC12.BackgroundImage = Properties.Resources.im12;
                DC12.BackColor = Color.Blue;
                PickND = DC12;
                Update_SC();
            }
        }

        

        private void DC13_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC13.BackgroundImage = Properties.Resources.im13;
                DC13.BackColor = Color.Blue;
                DC13.Enabled = false;
                PickFT = DC13;
            }
            else
            {
                DC13.BackgroundImage = Properties.Resources.im13;
                DC13.BackColor = Color.Blue;
                PickND = DC13;
                Update_SC();
            }
        }

        private void C12_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C12.BackgroundImage = Properties.Resources.im12;
                C12.BackColor = Color.Blue;
                C12.Enabled = false;
                PickFT = C12;
            }
            else
            {
                C12.BackgroundImage = Properties.Resources.im12;
                C12.BackColor = Color.Blue;
                PickND = C12;
                Update_SC();
            }

        }

        private void C10_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C10.BackgroundImage = Properties.Resources.im10;
                C10.BackColor = Color.Lime;
                C10.Enabled = false;
                PickFT = C10;
            }
            else
            {
                C10.BackgroundImage = Properties.Resources.im10;
                C10.BackColor = Color.Lime;
                PickND = C10;
                Update_SC();
            }
        }

        private void C14_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C14.BackgroundImage = Properties.Resources.im14;
                C14.BackColor = Color.Blue;
                C14.Enabled = false;
                PickFT = C14;
            }
            else
            {
                C14.BackgroundImage = Properties.Resources.im14;
                C14.BackColor = Color.Blue;
                PickND = C14;
                Update_SC();
            }
        }

        private void DC15_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC15.BackgroundImage = Properties.Resources.im15;
                DC15.BackColor = Color.Blue;
                DC15.Enabled = false;
                PickFT = DC15;
            }
            else
            {
                DC15.BackgroundImage = Properties.Resources.im15;
                DC15.BackColor = Color.Blue;
                PickND = DC15;
                Update_SC();
            }
        }

        private void DC11_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC11.BackgroundImage = Properties.Resources.im11;
                DC11.BackColor = Color.Blue;
                DC11.Enabled = false;
                PickFT = DC11;
            }
            else
            {
                DC11.BackgroundImage = Properties.Resources.im11;
                DC11.BackColor = Color.Blue;
                PickND = DC11;
                Update_SC();
            }
        }

        private void DC10_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC10.BackgroundImage = Properties.Resources.im10;
                DC10.BackColor = Color.Lime;
                DC10.Enabled = false;
                PickFT = DC10;
            }
            else
            {
                DC10.BackgroundImage = Properties.Resources.im10;
                DC10.BackColor = Color.Lime;
                PickND = DC10;
                Update_SC();
            }
        }

        private void DC14_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                DC14.BackgroundImage = Properties.Resources.im14;
                DC14.BackColor = Color.Blue;
                DC14.Enabled = false;
                PickFT = DC14;
            }
            else
            {
                DC14.BackgroundImage = Properties.Resources.im14;
                DC14.BackColor = Color.Blue;
                PickND = DC14;
                Update_SC();
            }
        }

        private void C15_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C15.BackgroundImage = Properties.Resources.im15;
                C15.BackColor = Color.Blue;
                C15.Enabled = false;
                PickFT = C15;
            }
            else
            {
                C15.BackgroundImage = Properties.Resources.im15;
                C15.BackColor = Color.Blue;
                PickND = C15;
                Update_SC();
            }
        }

        private void ReB_R_Click(object sender, EventArgs e)
        {
            B_R--;
            BP_R.Text = Convert.ToString(B_R);
            if (B_R == 4)
            {
                S_R -= 2;
                SPP_R.Text = Convert.ToString(S_R);
            }
            ReR_R.Visible = false;
            ReR_R.Enabled = false;
            ReB_R.Visible = false;
            ReB_R.Enabled = false;
            ReG_R.Visible = false;
            ReG_R.Enabled = false;
            Time_WP.Start();
        }

        private void ReR_L_Click(object sender, EventArgs e)
        {
            R_L--;
            RP_L.Text = Convert.ToString(R_L);
            if (R_L == 4)
            {
                S_L -= 2;
                SPP_L.Text = Convert.ToString(S_L);
            }
            ReR_L.Visible = false;
            ReR_L.Enabled = false;
            ReB_L.Visible = false;
            ReB_L.Enabled = false;
            ReG_L.Visible = false;
            ReG_L.Enabled = false;
            Time_WP.Start();
        }

        private void ReB_L_Click(object sender, EventArgs e)
        {
            B_L--;
            BP_L.Text = Convert.ToString(B_L);
            if (B_L == 4)
            {
                S_L -= 2;
                SPP_L.Text = Convert.ToString(S_L);
            }
            ReR_L.Visible = false;
            ReR_L.Enabled = false;
            ReB_L.Visible = false;
            ReB_L.Enabled = false;
            ReG_L.Visible = false;
            ReG_L.Enabled = false;
            Time_WP.Start();
        }

        private void ReG_R_Click(object sender, EventArgs e)
        {
            G_R--;
            GP_R.Text = Convert.ToString(G_R);
            if (G_R == 4)
            {
                S_R -= 2;
                SPP_R.Text = Convert.ToString(S_R);
            }
            ReR_R.Visible = false;
            ReR_R.Enabled = false;
            ReB_R.Visible = false;
            ReB_R.Enabled = false;
            ReG_R.Visible = false;
            ReG_R.Enabled = false;
            Time_WP.Start();
        }

        private void ReR_R_Click(object sender, EventArgs e)
        {
            R_R--;
            RP_R.Text = Convert.ToString(R_R);
            if (R_R == 4)
            {
                S_R -= 2;
                SPP_R.Text = Convert.ToString(S_R);
            }
            ReR_R.Visible = false;
            ReR_R.Enabled = false;
            ReB_R.Visible = false;
            ReB_R.Enabled = false;
            ReG_R.Visible = false;
            ReG_R.Enabled = false;
            Time_WP.Start();
        }

        private void ReG_L_Click(object sender, EventArgs e)
        {
            G_L--;
            GP_L.Text = Convert.ToString(G_L);
            if (G_L == 4)
            {
                S_L -= 2;
                SPP_L.Text = Convert.ToString(S_L);
            }
            ReR_L.Visible = false;
            ReR_L.Enabled = false;
            ReB_L.Visible = false;
            ReB_L.Enabled = false;
            ReG_L.Visible = false;
            ReG_L.Enabled = false;
            Time_WP.Start();
        }

       
        private void C11_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                C11.BackgroundImage = Properties.Resources.im11;
                C11.BackColor = Color.Blue;
                C11.Enabled = false;
                PickFT = C11;
            }
            else
            {
                C11.BackgroundImage = Properties.Resources.im11;
                C11.BackColor = Color.Blue;
                PickND = C11;
                Update_SC();
            }
        }

        private void JK_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                JK.BackgroundImage = Properties.Resources.imJK;
                JK.BackColor = Color.White;
                JK.Enabled = false;
                PickFT = JK;
            }
            else
            {
                JK.BackgroundImage = Properties.Resources.imJK;
                JK.BackColor = Color.White;
                PickND = JK;
                Update_SC();
            }
        }

        private void WT_Click(object sender, EventArgs e)
        {
            if (PickFT == null)
            {
                WT.BackgroundImage = Properties.Resources.imWT;
                WT.BackColor = Color.Black;
                WT.Enabled = false;
                PickFT = WT;
            }
            else
            {
                WT.BackgroundImage = Properties.Resources.imWT;
                WT.BackColor = Color.Black;
                PickND = WT;
                Update_SC();
            }
        }

        private void ST_P_L_Click(object sender, EventArgs e)
        {
            round = 0;
            ST_P_L.Enabled = false;
            ST_P_L.Visible = false;
            ST_P_R.Enabled = false;
            ST_P_R.Visible = false;
            RD_R.Visible = false;
            RD_L.Visible = true;
            foreach (PictureBox picture in panel1.Controls)
            { 
                picture.Enabled = true;
                picture.Cursor = Cursors.Hand;
            }
        }

        private void ST_P_R_Click(object sender, EventArgs e)
        {
            round = 1;
            ST_P_L.Enabled = false;
            ST_P_L.Visible = false;
            ST_P_R.Enabled = false;
            ST_P_R.Visible = false;
            RD_R.Visible = true;
            RD_L.Visible = false;
            foreach (PictureBox picture in panel1.Controls)
            {
                picture.Cursor = Cursors.Hand;
                picture.Enabled = true;
            }
        }

        private void Again_BT_Click(object sender, EventArgs e)
        {
            Close();
            Form2 f2 = new Form2();
            f2.Show();
        }

        private void Time_WP_Tick(object sender, EventArgs e)
        {
            Time_WP.Stop();
            if (num1 == 20 || num1 == 19)
            {
                PickFT.Visible = false;
                PickFT.Enabled = false;
            }
            else
            {
               PickFT.BackgroundImage = Properties.Resources.im0;
               PickFT.BackColor = Color.DarkOrange;
            }

            if (num2 == 20 || num2 == 19)
            {
                PickND.Visible = false;
                PickND.Enabled = false;
            }
            else
            {
                PickND.BackgroundImage = Properties.Resources.im0;
                PickND.BackColor = Color.DarkOrange;
            }
            PickFT = null;
            PickND = null;
            foreach (PictureBox picture in panel1.Controls)
                if (picture.Visible == true)
                    picture.Enabled = true;
            Change_Round();
        }

        private void Time_CP_Tick(object sender, EventArgs e)
        {
            Time_CP.Stop();
            SC++;
            PickFT.Visible = false;
            PickND.Visible = false;
            PickFT.Enabled = false;
            PickND.Enabled = false;
            if (num1 <= 5 || num2 <= 5)
            {
                if (round == 0)
                {
                    R_L++;
                    RP_L.Text = Convert.ToString(R_L);
                    if (R_L == 5)
                    {
                        S_L += 2;
                        SPP_L.Text = Convert.ToString(S_L);
                    }
                }
                else
                {
                    R_R++;
                    RP_R.Text = Convert.ToString(R_R);
                    if (R_R == 5)
                    {
                        S_R += 2;
                        SPP_R.Text = Convert.ToString(S_R);
                    }
                }
            }
            else if(num1 <= 10 || num2 <= 10)
            {
                if (round == 0)
                {
                    G_L++;
                    GP_L.Text = Convert.ToString(G_L);
                    if(G_L==5)
                    {
                        S_L += 2;
                        SPP_L.Text = Convert.ToString(S_L);
                    }
                }
                else
                {
                    G_R++;
                    GP_R.Text = Convert.ToString(G_R);
                    if (G_R == 5)
                    {
                        S_R += 2;
                        SPP_R.Text = Convert.ToString(S_R);
                    }
                }
            }
            else
            {
                if (round == 0)
                {
                    B_L++;
                    BP_L.Text = Convert.ToString(B_L);
                    if (B_L==5)
                    {
                        S_L += 2;
                        SPP_L.Text = Convert.ToString(S_L);
                    }
                }
                else
                {
                    B_R++;
                    BP_R.Text = Convert.ToString(B_R);
                    if (B_R == 5)
                    {
                        S_R += 2;
                        SPP_R.Text = Convert.ToString(S_R);
                    }
                }
            }
            PickFT = null;
            PickND = null;
            if (SC == 15)
            {
                RD_L.Visible = false;
                RD_R.Visible = false;
                TT_L.Visible = true;
                TT_R.Visible = true;
                NT_L.Visible = true;
                NT_R.Visible = true;
                int tl = B_L + R_L + G_L + S_L;
                int tr = B_R + R_R + G_R + S_R;
                NT_L.Text = Convert.ToString(tl);
                NT_R.Text = Convert.ToString(tr);
                if(tl>tr)
                {
                    W_L.Visible = true;
                }
                else if (tl < tr)
                {
                    W_R.Visible = true;
                }
                else
                {
                    W_L.Visible = true;
                    W_R.Visible = true;
                    W_L.Text = "Draw";
                    W_R.Text = "Draw";
                }
            }
            else
            {   
                
                foreach (PictureBox picture in panel1.Controls)
                    if (picture.Visible == true)
                        picture.Enabled = true;
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
            Form1 f1 = new Form1();
            f1.Show();
        }


    }
}
