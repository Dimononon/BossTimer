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
        private string bossRussianName;

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
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        public void InstantiatePanel(FlowLayoutPanel form, int left, int top, string bossName)
        {
            
            if (!Int32.TryParse(ConfigurationManager.AppSettings[bossName], out bossCD))
            {
                throw new Exception("Can't read config");
            }
            if (bossName == "ancientArcherCD") bossRussianName = "Древний лучник";
            else if (bossName == "slimeCD") bossRussianName = "Слизень";
            else if (bossName == "steelguardCD") bossRussianName = "Стальной страж";
            else if (bossName == "nightmareCD") bossRussianName = "Кошмар";
            else if (bossName == "twinsCD") bossRussianName = "Близнецы";
            else if (bossName == "fireLordCD") bossRussianName = "Повелитель огня";
            else if (bossName == "spiderCD") bossRussianName = "Паучиха";
            else if (bossName == "drownedCD") bossRussianName = "Утопленник";
            else if (bossName == "wizardCD") bossRussianName = "Колдун";
            else if (bossName == "deathCD") bossRussianName = "Смерть";
            else if (bossName == "riderCD") bossRussianName = "Наездник";
            else if (bossName == "pillagerCD") bossRussianName = "Разбойник";
            else if (bossName == "lavaCubeCD") bossRussianName = "Лавовый куб";
            else if (bossName == "ghostHunterCD") bossRussianName = "Призрачный охотник";
            else if (bossName == "blackDragonCD") bossRussianName = "Чёрный дракон";
            else if (bossName == "giantCD") bossRussianName = "Гигант";
            else if (bossName == "snowMonsterCD") bossRussianName = "Снежный монстр";
            else if (bossName == "accursedLegionCD") bossRussianName = "Проклятый легион";
            else if (bossName == "monstrCD") bossRussianName = "Монстр";
            else if (bossName == "necromancerCD") bossRussianName = "Некромант";
            else if (bossName == "eaterOfDarknessCD") bossRussianName = "Пожиратель тьмы";
            else if (bossName == "chudoCD") bossRussianName = "Чудовище";
            else if (bossName == "blacksmithCD") bossRussianName = "Кузнец";
            else if (bossName == "mightyShulkerCD") bossRussianName = "Могущественный шалкер";
            else if (bossName == "casterCD") bossRussianName = "Заклинатель";
            else if (bossName == "deadHoursemanCD") bossRussianName = "Мёртвый всадний";
            else if (bossName == "samuraiCD") bossRussianName = "Самурай";
            else if (bossName == "deadLordCD") bossRussianName = "Повелитель мёртвых";
            else if (bossName == "shadowLordCD") bossRussianName = "Теневой лорд";
            else if (bossName == "goliathCD") bossRussianName = "Голиаф";
            else if (bossName == "destroyerCD") bossRussianName = "Разрушитель";
            else if (bossName == "screamCD") bossRussianName = "Крик";
            else if (bossName == "spectralCubeCD") bossRussianName = "Спектральный куб";
            else if (bossName == "shadowCD") bossRussianName = "Тень";
            else if (bossName == "heraldOfHellCD") bossRussianName = "Вестник ада";
            else if (bossName == "blazeCD") bossRussianName = "Ифрит";
            else if (bossName == "piglinCD") bossRussianName = "Пиглин";
            else if (bossName == "hoglinCD") bossRussianName = "Хоглин";
            else if (bossName == "zombiePiglinCD") bossRussianName = "Зомби пиглин";
            else if (bossName == "brutalPiglinCD") bossRussianName = "Брутальный пиглин";
            else if (bossName == "magmaCD") bossRussianName = "Магма";
            else if (bossName == "zoglinCD") bossRussianName = "Зоглин";
            else if (bossName == "hellKnightCD") bossRussianName = "Адский рыцарь";


            form.Controls.Add(panel);
            panel.Width = 168;
            panel.Height = 90;
            panel.Left = left;
            panel.Top = top;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.Enabled = true;
            panel.Visible = true;

            panel.Controls.Add(progressBar);
            progressBar.Width = 102;
            progressBar.Height = 10;
            progressBar.Left = 64;
            progressBar.Maximum = bossCD;
            progressBar.Step = 1;


            panel.Controls.Add(name);
            name.Width = 64;
            name.Height = 30;
            name.Font = new Font("Comic Sans MS", 6.7f);
            name.Text = bossRussianName;
            //name.BorderStyle = BorderStyle.FixedSingle;

            panel.Controls.Add(icon);
            icon.Width = 48;
            icon.Height = 48;
            icon.Location = new Point(8, 30);
            icon.BorderStyle = BorderStyle.FixedSingle;
            if (bossName == "ancientArcherCD") icon.Image = Resources.ancientArcherCD;
            else if (bossName == "slimeCD") icon.Image = Resources.slimeCD;
            else if (bossName == "steelguardCD") icon.Image = Resources.steelGuardCD;
            else if (bossName == "nightmareCD") icon.Image = Resources.nightmareCD;
            else if (bossName == "twinsCD") icon.Image = Resources.twinsCD;
            else if (bossName == "fireLordCD") icon.Image = Resources.fireLordCD;
            else if (bossName == "spiderCD") icon.Image = Resources.spiderCD;
            else if (bossName == "drownedCD") icon.Image = Resources.drownedCD;
            else if (bossName == "wizardCD") icon.Image = Resources.wizardCD;
            else if (bossName == "deathCD") icon.Image = Resources.deathCD;
            else if (bossName == "riderCD") icon.Image = Resources.riderCD;
            else if (bossName == "pillagerCD") icon.Image = Resources.pillagerCD;
            else if (bossName == "lavaCubeCD") icon.Image = Resources.lavaCubeCD;
            else if (bossName == "ghostHunterCD") icon.Image = Resources.ghostHunterCD;
            else if (bossName == "blackDragonCD") icon.Image = Resources.blackDragonCD;
            else if (bossName == "giantCD") icon.Image = Resources.giantCD;
            else if (bossName == "snowMonsterCD") icon.Image = Resources.snowMonsterCD;
            else if (bossName == "accursedLegionCD") icon.Image = Resources.accursedLegionCD;
            else if (bossName == "monstrCD") icon.Image = Resources.monstrCD;
            else if (bossName == "necromancerCD") icon.Image = Resources.necromancerCD;
            else if (bossName == "eaterOfDarknessCD") icon.Image = Resources.eaterOfDarknessCD;
            else if (bossName == "chudoCD") icon.Image = Resources.chudoCD;
            else if (bossName == "blacksmithCD") icon.Image = Resources.blacksmithCD;
            else if (bossName == "mightyShulkerCD") icon.Image = Resources.mightyShulkerCD;
            else if (bossName == "casterCD") icon.Image = Resources.casterCD;
            else if (bossName == "deadHoursemanCD") icon.Image = Resources.deadHoursemanCD;
            else if (bossName == "samuraiCD") icon.Image = Resources.samuraiCD;
            else if (bossName == "deadLordCD") icon.Image = Resources.deadLordCD;
            else if (bossName == "shadowLordCD") icon.Image = Resources.shadowLordCD;
            else if (bossName == "goliathCD") icon.Image = Resources.goliathCD;
            else if (bossName == "destroyerCD") icon.Image = Resources.destroyerCD;
            else if (bossName == "screamCD") icon.Image = Resources.screamCD;
            else if (bossName == "spectralCubeCD") icon.Image = Resources.spectralCubeCD;
            else if (bossName == "shadowCD") icon.Image = Resources.shadowCD;
            else if (bossName == "heraldOfHellCD") icon.Image = Resources.heraldOfHellCD;
            else if (bossName == "blazeCD") icon.Image = Resources.blazeCD;
            else if (bossName == "piglinCD") icon.Image = Resources.piglinCD;
            else if (bossName == "hoglinCD") icon.Image = Resources.hoglinCD;
            else if (bossName == "zombiePiglinCD") icon.Image = Resources.zombiePiglinCD;
            else if (bossName == "brutalPiglinCD") icon.Image = Resources.brutalPiglinCD;
            else if (bossName == "magmaCD") icon.Image = Resources.magmaCD;
            else if (bossName == "zoglinCD") icon.Image = Resources.zoglinCD;
            else if (bossName == "hellKnightCD") icon.Image = Resources.hellKnightCD;

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
            //play.BorderStyle = BorderStyle.FixedSingle;
            play.Image = Resources.playButton;

            panel.Controls.Add(pause);
            pause.Width = 24;
            pause.Height = 24;
            pause.Location = new Point(98, 54);
            //pause.BorderStyle = BorderStyle.FixedSingle;
            pause.Image = Resources.pauseButton;

            panel.Controls.Add(repeat);
            repeat.Width = 24;
            repeat.Height = 24;
            repeat.Location = new Point(132, 54);
            //repeat.BorderStyle = BorderStyle.FixedSingle;
            repeat.Image = Resources.repeatButton;
        }
        public void DisenablePanel()
        {
            panel.Visible = false;
            panel.Enabled = false;
            isPlaying = false;
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


                    if (!Int32.TryParse(ConfigurationManager.AppSettings["msInSec"], out msInSec))
                    {
                        throw new Exception("Can't read config");
                    }

                    await Task.Delay(msInSec);
                }
                else if (seconds == 0)
                {
                    textHours.Text = Convert.ToString(seconds / 3600);
                    textMinutes.Text = Convert.ToString((seconds - Convert.ToInt32(textHours.Text) * 3600) / 60);
                    textSeconds.Text = Convert.ToString((seconds - Convert.ToInt32(textHours.Text) * 3600) - (Convert.ToInt32(textMinutes.Text) * 60));
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

        async private void PlayNotification()
        {
            panel.BackColor = Color.IndianRed;
            wplayer.URL = "Notification.mp3";
            wplayer.controls.play();
            await Task.Delay(60000);
            panel.BackColor = SystemColors.Control;
            
        }

        public void StartTimer()
        {
            if (!isPlaying)
            {
                isPlaying = true;
                seconds = (Convert.ToInt32(textHours.Text) * 3600) + (Convert.ToInt32(textMinutes.Text) * 60) + Convert.ToInt32(textSeconds.Text);
                TimeTick();
            }
            
        }
        public void StartTimer(int bossCD)
        {
            if (!isPlaying)
            {
                isPlaying = true;
                seconds = bossCD;
                TimeTick();
            }
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
