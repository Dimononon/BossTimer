using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;
using System.Drawing;



namespace Boss_Timer
{
    public class BossPanel
    {
        public int seconds = 0, msInSec = 1000, bossCD = 0;
        private bool isPlaying = false;

        private Panel panel = new Panel();
        private TextBox textSeconds = new TextBox();
        private TextBox textMinutes = new TextBox();
        private TextBox textHours = new TextBox();
        private PictureBox play = new PictureBox();
        private PictureBox pause = new PictureBox();
        private PictureBox repeat = new PictureBox();
        private PictureBox icon = new PictureBox();
        private Label name = new Label();
        private BossCDBar progressBar = new BossCDBar();
        //private ProgressBar progressBar = new ProgressBar();


        public void InstantiatePanel(FlowLayoutPanel form, int left, int top, string bossName)
        {

            if (!Int32.TryParse(ConfigurationManager.AppSettings[bossName], out bossCD))
            {
                throw new Exception("Can't read config");
            }
            
            form.Controls.Add(panel);
            panel.Width = 168;
            panel.Height = 90;
            panel.Left = left;
            panel.Top = top;
            panel.BorderStyle = BorderStyle.FixedSingle;

            panel.Controls.Add(progressBar);
            progressBar.Width = 136;
            progressBar.Height = 10;
            progressBar.Left = 64;
            progressBar.Maximum = bossCD;
            progressBar.Step = 1;


            panel.Controls.Add(name);
            name.Width = 60;
            name.Height = 30;
            name.Font = new Font("Comic Sans MS", 7);
            name.Text = bossName;
            //name.BorderStyle = BorderStyle.FixedSingle;

            panel.Controls.Add(icon);
            icon.Width = 48;
            icon.Height = 48;
            icon.Location = new Point(8, 30);
            icon.BorderStyle = BorderStyle.FixedSingle;


            panel.Controls.Add(textHours);
            textHours.Width = 24;
            textHours.Location = new Point(64, 20);
            textHours.Text = "0";

            panel.Controls.Add(textMinutes);
            textMinutes.Width = 24;
            textMinutes.Location = new Point(98, 20);
            textMinutes.Text = "0";


            panel.Controls.Add(textSeconds);
            textSeconds.Width = 24;
            textSeconds.Location = new Point(132, 20);
            textSeconds.Text = "0";



            panel.Controls.Add(play);
            play.Width = 24;
            play.Height = 24;
            play.Location = new Point(64, 54);
            play.BorderStyle = BorderStyle.FixedSingle;

            panel.Controls.Add(pause);
            pause.Width = 24;
            pause.Height = 24;
            pause.Location = new Point(98, 54);
            pause.BorderStyle = BorderStyle.FixedSingle;

            panel.Controls.Add(repeat);
            repeat.Width = 24;
            repeat.Height = 24;
            repeat.Location = new Point(132, 54);
            repeat.BorderStyle = BorderStyle.FixedSingle;

        }
        async void TimeTick()
        {
            while (isPlaying)
            {
                if (seconds > 0)
                {

                    textHours.Text = Convert.ToString(seconds / 3600);
                    textMinutes.Text = Convert.ToString((seconds - Convert.ToInt32(textHours.Text) * 3600) / 60);
                    textSeconds.Text = Convert.ToString((seconds - Convert.ToInt32(textHours.Text) * 3600) - (Convert.ToInt32(textMinutes.Text) * 60));
                    seconds--;
                    progressBar.Value = seconds;

                    await Task.Delay(msInSec);
                }
                else if (seconds == 0)
                {
                    seconds--;
                    isPlaying = false;
                    PlayNotification();
                }
                else
                {
                    isPlaying = false;
                    textHours.Text = "0";
                    textMinutes.Text = "0";
                    textSeconds.Text = "0";
                }
            }
        }

        private void PlayNotification()
        {
            throw new NotImplementedException();
        }

        public void StartTimer()
        {
            isPlaying = true;
            seconds = (Convert.ToInt32(textHours.Text) * 3600) + (Convert.ToInt32(textMinutes.Text) * 60) + Convert.ToInt32(textSeconds.Text);
            TimeTick();
        }
        public void StartTimer(int bossCD)
        {
            isPlaying = true;
            seconds = bossCD;
            TimeTick();
        }
        public void CreateEventHandlers()
        {
            play.Click += new EventHandler(play_Click);
            pause.Click += new EventHandler(pause_Click);
            repeat.Click += new EventHandler(repeat_Click);
        }
        private void play_Click(object sender, EventArgs e)
        {
            StartTimer();
        }
        private void pause_Click(object sender, EventArgs e)
        {
            isPlaying = false;
        }

        private void repeat_Click(object sender, EventArgs e)
        {
            StartTimer(bossCD);
        }
    }
}
