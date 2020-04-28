using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RussianRoullete_Balkaran
{
    public partial class Form1 : Form
    {
        Bal_Class bal = new Bal_Class();//another class instance
        Random r = new Random();//Random class variable
        int total_Chance = 6;//local variable
        int trying_Gun = 2;//local variable
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ground.Image = RussianRoullete_Balkaran.Properties.Resources.loadddddd;//image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Balkaran.Properties.Resources.Loadings);//adding sound
            soundPlayer.Play();//sound

            button1.Enabled = false;
            bal.Ld = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ground.Image = RussianRoullete_Balkaran.Properties.Resources.spincham;//image
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Balkaran.Properties.Resources.Loadings);//adding sound
            soundPlayer.Play();//sound

            button2.Enabled = false;//button got false

            bal.Spn = r.Next(1, 6);//random numbers changing 1 to 6
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ground.Image = RussianRoullete_Balkaran.Properties.Resources.shoot;//Here i add the image on the picturebox
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Balkaran.Properties.Resources.Shot);//Add sound here
            soundPlayer.Play();//play sound

            if (total_Chance > 0 && bal.Spn == 1)
            {
                MessageBox.Show("Shoot You loose");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (total_Chance > 0 && bal.Spn != 1)
            {
                MessageBox.Show("Blank Fire");
                total_Chance = total_Chance - 1;//minus one from total
                bal.Spn = bal.Shot(bal.Spn);

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ground.Image = RussianRoullete_Balkaran.Properties.Resources.shoot;//shootaway image add
            System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer(RussianRoullete_Balkaran.Properties.Resources.Shot);//getting sound
            soundPlayer.Play();//sound paying

            if (total_Chance > 0 && bal.Spn == 1 && trying_Gun == 2)
            {
                MessageBox.Show("your score is 200");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            if (total_Chance > 0 && bal.Spn == 1 && trying_Gun == 1)
            {
                MessageBox.Show("you win you score is 100");
                button4.Enabled = false;
                button3.Enabled = false;
            }
            else if (total_Chance > 0 && bal.Spn != 1)
            {
                MessageBox.Show("Blank Fire");
                total_Chance = total_Chance - 1;//minus one from total
                bal.Spn = bal.Shot(bal.Spn);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Form1()).Show();
            this.Hide();
        }
    }
}
