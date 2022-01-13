using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Windows.Forms;

namespace Boss_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            BossPanel First = new BossPanel();
            BossPanel First2 = new BossPanel();
            BossPanel First3 = new BossPanel();
            BossPanel First4 = new BossPanel();
            BossPanel First5 = new BossPanel();
            BossPanel[] bosses = new BossPanel[] { First, First2, First3, First4, First5 };
            string bossName = "";
            
            InitializeComponent();
            this.Width = Int32.Parse(ConfigurationManager.AppSettings["form1sizeX"]);
            this.Height = Int32.Parse(ConfigurationManager.AppSettings["form1sizeY"]);


            
            for (int i = 0; i < bosses.Length; i++)
            {
                if (bosses[i] == First) bossName = "ancientArcherCD";
                else if (bosses[i] == First2) bossName = "slimeCD";
                else if (bosses[i] == First3) bossName = "steelguardCD";
                else if (bosses[i] == First4) bossName = "ancientArcherCD";
                else if (bosses[i] == First5) bossName = "ancientArcherCD";
                bosses[i].InstantiatePanel(flowLayoutPanel1, 0, 0, bossName);
                bosses[i].CreateEventHandlers();
            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm(this);
            settingsForm.Show();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["form1sizeX"].Value = Convert.ToString(this.Width);
            configuration.AppSettings.Settings["form1sizeY"].Value = Convert.ToString(this.Height);
            configuration.Save(ConfigurationSaveMode.Minimal, true);
            ConfigurationManager.RefreshSection("appSettings");
        }
    }
}
