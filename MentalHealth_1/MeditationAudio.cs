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
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
using System.Security.Cryptography;

namespace MentalHealth_1
{
    public partial class MeditationAudio : Form
    {
        public MeditationAudio()
        {
            InitializeComponent();
            bool Hz174 = false;
            bool Hz285 = false;
            bool Hz396 = false;
            bool Hz417 = false;
            bool Hz528 = false;
            bool Hz639 = false;
            bool Hz741 = false;
            bool Hz852 = false;
            bool Hz963 = false;
            


        }
       
        private void button_back_Click(object sender, EventArgs e)
        {
            Meditation meditation = new Meditation();
            meditation.ShowDialog();
        }

        private void button_stopaudio_Click(object sender, EventArgs e)
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }

        private void pictureBox_174_Click(object sender, EventArgs e)
        {
            panel_174.BackColor = Color.Green;
            panel_285.BackColor = Color.White;

            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;
            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {
                
                {
                    SoundPlayer Audio174 = new SoundPlayer();
                    Audio174.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\174Hz.wav";

                    Audio174.Load();
                    Audio174.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_174, "Audio Not Found");
                
            }





        }

        private void pictureBox_285_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.Green;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio285 = new SoundPlayer();
                    Audio285.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\285Hz.wav";

                    Audio285.Load();
                    Audio285.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_285, "Audio Not Found");

            }
        }

        private void pictureBox_396_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.Green;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio396 = new SoundPlayer();
                    Audio396.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\396Hz.wav";

                    Audio396.Load();
                    Audio396.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_396, "Audio Not Found");

            }
        }

        private void pictureBox_417_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.Green;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio417 = new SoundPlayer();
                    Audio417.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\417Hz.wav";

                    Audio417.Load();
                    Audio417.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_417, "Audio Not Found");

            }
        }

        private void pictureBox_528_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.Green;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio528 = new SoundPlayer();
                    Audio528.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\528Hz.wav";

                    Audio528.Load();
                    Audio528.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_528, "Audio Not Found");

            }
        }

        private void pictureBox_639_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.Green;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio639 = new SoundPlayer();
                    Audio639.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\639Hz.wav";

                    Audio639.Load();
                    Audio639.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_639, "Audio Not Found");

            }
        }

        private void pictureBox_741_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.Green;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio741 = new SoundPlayer();
                    Audio741.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\741Hz.wav";

                    Audio741.Load();
                    Audio741.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_741, "Audio Not Found");

            }
        }

        private void pictureBox_852_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.Green;
            panel_963.BackColor = Color.White;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio852 = new SoundPlayer();
                    Audio852.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\852Hz.wav";

                    Audio852.Load();
                    Audio852.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_852, "Audio Not Found");

            }
        }

        private void pictureBox_963_Click(object sender, EventArgs e)
        {
            panel_285.BackColor = Color.White;
            panel_174.BackColor = Color.White;
            panel_396.BackColor = Color.White;
            panel_417.BackColor = Color.White;
            panel_528.BackColor = Color.White;
            panel_639.BackColor = Color.White;
            panel_741.BackColor = Color.White;
            panel_852.BackColor = Color.White;
            panel_963.BackColor = Color.Green;

            SoundPlayer player = new SoundPlayer();
            player.Stop();
            try
            {

                {
                    SoundPlayer Audio963 = new SoundPlayer();
                    Audio963.SoundLocation = @"C:\Users\jmon4\OneDrive\Desktop\MS539_VSCode\Mental Health App\MentalHealth_1\AudioWAV\963Hz.wav";

                    Audio963.Load();
                    Audio963.PlayLooping();
                }

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_963, "Audio Not Found");

            }
        }
    }
}



        
    
