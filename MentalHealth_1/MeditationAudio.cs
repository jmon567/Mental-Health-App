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
<<<<<<< HEAD
using System.Security.Cryptography;
=======
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Diagnostics;
>>>>>>> fb99b9f945e4587a0eb67031b7d606d6b679e716

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

        private void pictureBox_174_Click(object sender, EventArgs e)
        {
            try
            {
<<<<<<< HEAD
                SoundPlayer Audio174 = new SoundPlayer();
                // Audio174.SoundLocation = @"C:\\Mac\Home\Desktop\MS539Code_VS\MentalHealthApp\MentalHealth_1\MentalHealth_1\AudioWAV\174Hz.wav";
                Audio174.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "AudioWAV\\174Hz.wav");
                if (File.Exists(Audio174.SoundLocation))
                {
                  
                    MessageBox.Show("Test");
                }
                Audio174.Load();
                Audio174.Play();

            }
            catch (Exception ex)
            {
                errorProvider1.SetError(pictureBox_174, "Audio Not Found");
            }
=======

                    SoundPlayer Audio174 = new SoundPlayer();
               Audio174.SoundLocation = @"C:\Users\jackmiller\Desktop\Code\MentalHealth_1\bin\Debug\net8.0 - windows\frequencies\BAD HABITS.wav";
               // Audio174.SoundLocation = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "frequencies/174Hz.m4a");
               Audio174.Load();
                Audio174.PlayLooping();
                   // Audio174.Play();

                }
                catch (Exception ex) {                
                    
                    errorProvider1.SetError(pictureBox_174, "Audio Not Found");

                    //Console.WriteLine("Audio Not Found");
                }
                
            



>>>>>>> fb99b9f945e4587a0eb67031b7d606d6b679e716
        }

       
    }



        
    
}
