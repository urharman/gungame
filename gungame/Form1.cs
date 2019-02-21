using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace gungame
{
    public partial class Form1 : Form
    {
        int x = 2, y = 3;
        int z = 4, cunt = 0;

        GenreateFire obj = new GenreateFire();
        Image Imageobj = new Image();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            y = 0;
            x = 0;
            cunt = 0;
            btnShot.Enabled = true;
            pictureBox1.ImageLocation = @"C:\Users\singh\source\repos\gungame\gungame\picture and audio\gun_PNG1385.png";
            pictChamber.ImageLocation = @"C:\Users\singh\source\repos\gungame\gungame\picture and audio\54revolver.png";
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\singh\source\repos\gungame\gungame\picture and audio\gunshoot.wav");
                splayer.Play();
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            SoundPlayer splayer = new SoundPlayer(@"C:\Users\singh\source\repos\gungame\gungame\picture and audio\50.wav");
            splayer.Play();
            x = x + 1;
            if (x == 1)
            {
               
                pictureBox1.ImageLocation = @"C:\Users\singh\source\repos\gungame\gungame\picture and audio\load.gif";

            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            {
                SoundPlayer splayer = new SoundPlayer(@"C:\Users\singh\source\repos\gungame\gungame\picture and audio\gunreleod.wav");
                splayer.Play();
            }

            if (x > 0)
            {
             
                    pictChamber.ImageLocation = @"C:\Users\singh\source\repos\gungame\gungame\picture and audio/1234.png";
            }
            else {
                MessageBox.Show("Please Click on Load Bullet First");
            }

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int value()
        {
            Random rand = new Random();
            int random = rand.Next(1, 3);
            return random;

        }

        private void btnPlayer1_Click(object sender, EventArgs e)
        {
            if (x > 0)
            {
                y++;
                pictureBox1.ImageLocation = @"C:\Users\singh\source\repos\gungame\gungame\picture and audio\Shot.gif";
                if (y == z && cunt<2)
                {
                    cunt++;
                    System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\Users\singh\source\repos\gungame\gungame\picture and audio\gunshoot.wav");
                    player.Play();
                    z = obj.fire();
                }
                if (cunt == 1)
                {
                    MessageBox.Show("Game Over Bullets Finished");
                    btnShot.Enabled = false;
                }
            }
     
        }
    }
}
