using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Elijah
{
    public partial class Form1 : Form
    {
        //Variables
        // int score = 0;
        Random Location = new Random();
        List<Point> points = new List<Point>();
        bool again = false;
        PictureBox PendingImage1;
        PictureBox PendingImage2;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "5";
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                picture.Enabled = false;
                points.Add(picture.Location);
            }
            foreach (PictureBox picture in CardsHolder.Controls)
            {
                int next = Location.Next(points.Count);
                Point p = points[next];
                picture.Location = p;
                points.Remove(p);
            }
            timer2.Start();
            timer1.Start();
            Card1.Image = Properties.Resources.Card1;
            DubCard1.Image = Properties.Resources.Card1;
            Card2.Image = Properties.Resources.Card2;
            DubCard2.Image = Properties.Resources.Card2;
            Card3.Image = Properties.Resources.Card3;
            DubCard3.Image = Properties.Resources.Card3;
            Card4.Image = Properties.Resources.Card4;
            DubCard4.Image = Properties.Resources.Card4;
            Card5.Image = Properties.Resources.Card5;
            DubCard5.Image = Properties.Resources.Card5;
            Card6.Image = Properties.Resources.Card6;
            DubCard6.Image = Properties.Resources.Card6;
            Card7.Image = Properties.Resources.Card7;
            DubCard7.Image = Properties.Resources.Card7;
            Card8.Image = Properties.Resources.Card8;
            DubCard8.Image = Properties.Resources.Card8;            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            foreach (PictureBox picture in CardsHolder.Controls)
            {
               picture.Enabled = true;            
               picture.Cursor = Cursors.Hand;
               picture.Image = Properties.Resources.Cover;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int timer = Convert.ToInt32(label1.Text);
            timer = timer-1;
            label1.Text = Convert.ToString(timer);
            if (timer == 0)
            {
                timer2.Stop();
            }
        }

        // Change Cards Value
        #region Cards
        private void Card1_Click(object sender, EventArgs e)
        {
            Card1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DubCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard1_Click(object sender, EventArgs e)
        {
            DubCard1.Image = Properties.Resources.Card1;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard1;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard1;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card1.Enabled = false;
                    DubCard1.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card2_Click(object sender, EventArgs e)
        {
            Card2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DubCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard2_Click(object sender, EventArgs e)
        {
            DubCard2.Image = Properties.Resources.Card2;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard2;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard2;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card2.Enabled = false;
                    DubCard2.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card3_Click(object sender, EventArgs e)
        {
            Card3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DubCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard3_Click(object sender, EventArgs e)
        {
            DubCard3.Image = Properties.Resources.Card3;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard3;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard3;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card3.Enabled = false;
                    DubCard3.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card4_Click(object sender, EventArgs e)
        {
            Card4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DubCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard4_Click(object sender, EventArgs e)
        {
            DubCard4.Image = Properties.Resources.Card4;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard4;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard4;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card4.Enabled = false;
                    DubCard4.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card5_Click(object sender, EventArgs e)
        {
            Card5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DubCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard5_Click(object sender, EventArgs e)
        {
            DubCard5.Image = Properties.Resources.Card5;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard5;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard5;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card5.Enabled = false;
                    DubCard5.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card6_Click(object sender, EventArgs e)
        {
            Card6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DubCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard6_Click(object sender, EventArgs e)
        {
            DubCard6.Image = Properties.Resources.Card6;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard6;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard6;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card6.Enabled = false;
                    DubCard6.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card7_Click(object sender, EventArgs e)
        {
            Card7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DubCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard7_Click(object sender, EventArgs e)
        {
            DubCard7.Image = Properties.Resources.Card7;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard7;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard7;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card7.Enabled = false;
                    DubCard7.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void Card8_Click(object sender, EventArgs e)
        {
            Card8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = Card8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = Card8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DubCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }

        private void DubCard8_Click(object sender, EventArgs e)
        {
            DubCard8.Image = Properties.Resources.Card8;
            if (PendingImage1 == null)
            {
                PendingImage1 = DubCard8;
            }
            else if (PendingImage1 != null && PendingImage2 == null)
            {
                PendingImage2 = DubCard8;
            }
            if (PendingImage1 != null && PendingImage2 != null)
            {
                if (PendingImage1.Tag == PendingImage2.Tag)
                {
                    PendingImage1 = null;
                    PendingImage2 = null;
                    Card8.Enabled = false;
                    DubCard8.Enabled = false;
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) + 10);
                }
                else
                {
                    ScoreCounter.Text = Convert.ToString(Convert.ToInt32(ScoreCounter.Text) - 10);
                    timer3.Start();
                }
            }
        }
        #endregion

        private void timer3_Tick(object sender, EventArgs e)
        {
            timer3.Stop();
            PendingImage1.Image = Properties.Resources.Cover;
            PendingImage2.Image = Properties.Resources.Cover;
            PendingImage1 = null;
            PendingImage2 = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }
    }
}
