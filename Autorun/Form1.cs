using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;

using System.Text;

using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;

namespace Autorun
{
    public partial class Form1 : Form
    {
        SoundPlayer sndpl = new SoundPlayer(Autorun.Properties.Resources.hawk);
        SoundPlayer startsnd = new SoundPlayer(Autorun.Properties.Resources.INTRO_s);




        public Form1()
        {           


            InitializeComponent();
            startsnd.Play();

            back.Visible = false;
            wallpaper.Visible = false;
            ringtone.Visible = false;
            presentation.Visible = false;
            title.Visible = false;
     
        }

        

       

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            install.ForeColor = Color.White;


        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            install.ForeColor = Color.Yellow;
        }

        private void install_Click(object sender, EventArgs e)
        {
            install.ForeColor = Color.Orange;

            if (Environment.OSVersion.Version.Major == 5)
            {
                if (Environment.OSVersion.Version.Minor == 1)
                {
                    DialogResult dialogResult = MessageBox.Show("Na tym komputerze zainstalowany jest system Windows XP. Do prawidłowego działania programu w tym systemie wymagany jest Microsoft .NET Framework 4. Czy chcesz go zainstalować teraz?", "Wykryto Windows XP!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string fullPath = @"DATA_bin\imp_fil\.net FRAMEWORK 4\dotNetFx40_Full_x86_x64.exe";
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Path.GetFileName(fullPath);
                        psi.WorkingDirectory = Path.GetDirectoryName(fullPath);                      
                        var process = Process.Start(psi);
                        process.WaitForExit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        
                    }
                }
                else if (Environment.OSVersion.Version.Minor == 2)
                {
                    DialogResult dialogResult = MessageBox.Show("Na tym komputerze zainstalowany jest system Windows XP 64 bit lub Windows Server 2003. Do prawidłowego działania programu w tym systemie wymagany jest Microsoft .NET Framework 4. Czy chcesz go zainstalować teraz?", "Wykryto Windows XP 64 bit lub Server 2003!", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string fullPath = @"DATA_bin\imp_fil\.net FRAMEWORK 4\dotNetFx40_Full_x86_x64.exe";
                        ProcessStartInfo psi = new ProcessStartInfo();
                        psi.FileName = Path.GetFileName(fullPath);
                        psi.WorkingDirectory = Path.GetDirectoryName(fullPath);
                        var process = Process.Start(psi);
                        process.WaitForExit();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
            }

            Process.Start(@"DATA_bin\install\setup.exe");
            sndpl.Play();
        }

        private void exit_p_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        /// <summary>
        /// //////////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pdf_reader_MouseEnter(object sender, EventArgs e)
        {
            pdf_reader.ForeColor = Color.White;
        }

        private void pdf_reader_MouseLeave(object sender, EventArgs e)
        {
            pdf_reader.ForeColor = Color.Yellow;
        }

        private void pdf_reader_Click(object sender, EventArgs e)
        {
            pdf_reader.ForeColor = Color.Orange;
            sndpl.Play();
            var helpFile = Path.Combine(Path.GetTempPath(), "manual.txt");
            File.WriteAllText(helpFile, Autorun.Properties.Resources.manual);
            Process.Start(helpFile);


        }
        /// <summary>
        /// ////////
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bonuses_MouseEnter(object sender, EventArgs e)
        {
            bonuses.ForeColor = Color.White;
        }

        private void bonuses_MouseLeave(object sender, EventArgs e)
        {
            bonuses.ForeColor = Color.Yellow;
        }

        private void bonuses_Click(object sender, EventArgs e)
        {
            bonuses.ForeColor = Color.Orange;

            install.Visible = false;
            bonuses.Visible = false;
            pdf_reader.Visible = false;
            exit_p.Visible = false;
            stronka.Visible = false;

            back.Visible = true;
            wallpaper.Visible = true;
            ringtone.Visible = true;
            presentation.Visible = true;
       
            sndpl.Play();
        }

        private void exit_p_MouseEnter(object sender, EventArgs e)
        {
            exit_p.ForeColor = Color.White;
        }

        private void exit_p_MouseLeave(object sender, EventArgs e)
        {
            exit_p.ForeColor = Color.Yellow;
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Image silmari = Autorun.Properties.Resources.INTROROR;
            e.Graphics.DrawImage(silmari, 0, 0, 640, 480); 
        }

  
        private void label1_Click(object sender, EventArgs e)
        {
            install.Visible = true;
            bonuses.Visible = true;
            pdf_reader.Visible = true;
            exit_p.Visible = true;
           


        }

        private void stronka_MouseEnter(object sender, EventArgs e)
        {
            stronka.ForeColor = Color.White;
        }

        private void stronka_MouseLeave(object sender, EventArgs e)
        {
            stronka.ForeColor = Color.Yellow;
        }

        private void stronka_MouseClick(object sender, MouseEventArgs e)
        {
            stronka.ForeColor = Color.Orange;
            try
            {
                System.Diagnostics.Process.Start("http://silmariped.y0.pl/");
            }
            catch { }
        }

        private void label1_MouseEnter_1(object sender, EventArgs e)
        {
            back.ForeColor = Color.White;
            
        }

       

        private void ringtone_MouseEnter(object sender, EventArgs e)
        {
            ringtone.ForeColor = Color.Red;
        }

        private void wallpaper_MouseEnter(object sender, EventArgs e)
        {
            wallpaper.ForeColor = Color.Red;
        }

        private void wallpaper_MouseClick(object sender, MouseEventArgs e)
        {
            wallpaper.ForeColor = Color.White;
            Process.Start(@"DATA_bin\ext_fil\wlp_ext\Tapety");
        }

        private void back_MouseClick(object sender, MouseEventArgs e)
        {
            wallpaper.Visible = false;
            ringtone.Visible = false;
            presentation.Visible = false;
            back.Visible = false;

            install.Visible = true;
            bonuses.Visible = true;
            pdf_reader.Visible = true;
            exit_p.Visible = true;
            stronka.Visible = true;

            sndpl.Play();

        }

        private void presentation_MouseEnter(object sender, EventArgs e)
        {
            presentation.ForeColor = Color.Red;
        }

        private void presentation_MouseClick(object sender, MouseEventArgs e)
        {
            presentation.ForeColor = Color.White;
            Process.Start(@"DATA_bin\tsh_fil\Silmaripedia - prezentacja.avi");
        }

        private void ringtone_MouseClick(object sender, MouseEventArgs e)
        {
            ringtone.ForeColor = Color.White;
            Process.Start(@"DATA_bin\ext_fil\rng_ext\Dzwonki");
        }

        private void wallpaper_MouseLeave(object sender, EventArgs e)
        {
            wallpaper.ForeColor = Color.Yellow;
        }

        private void ringtone_MouseLeave(object sender, EventArgs e)
        {
            ringtone.ForeColor = Color.Yellow;
        }

        private void presentation_MouseLeave(object sender, EventArgs e)
        {
            presentation.ForeColor = Color.Yellow;
        }

        private void Wróć_MouseLeave(object sender, EventArgs e)
        {
            back.ForeColor = Color.Red;
        }

        private void optim_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            title.Visible = true;
        }




     
        
    }
}
