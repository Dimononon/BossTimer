using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boss_Timer
{
    public partial class SettingsForm : Form
    {
        bool[] bosses = new bool[43];
        string activeBosses;
        Form1 form1;

        public SettingsForm()
        {
            InitializeComponent();
            numericUpDown1.Value = Int32.Parse(ConfigurationManager.AppSettings["msInSec"]);
            

        }
        public SettingsForm(Form1 f)
        {
            InitializeComponent();
            numericUpDown1.Value = Int32.Parse(ConfigurationManager.AppSettings["msInSec"]);
            string[] activeBossesStr = ConfigurationManager.AppSettings["bosses"].Split(',');
            bool[] checking = new bool[43];
            for (int i = 0; i < activeBossesStr.Length; i++)
            {
                checking[i] = Convert.ToBoolean(activeBossesStr[i]);
            }
            CheckingCheckingboxes(checking);
            form1 = f;
        }
        public void RefreshConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }
        public void SaveSettings()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings["msInSec"].Value = Convert.ToString(numericUpDown1.Value);
            configuration.Save(ConfigurationSaveMode.Minimal, true);
            ConfigurationManager.RefreshSection("appSettings");


            for (int i = 0; i < bosses.Length; i++)
            {
                bosses[i] = false;
            }
            if (checkBox1.Checked) bosses[0] = true;
            if (checkBox2.Checked) bosses[1] = true;
            if (checkBox3.Checked) bosses[2] = true;
            if (checkBox4.Checked) bosses[3] = true;
            if (checkBox5.Checked) bosses[4] = true;
            if (checkBox6.Checked) bosses[5] = true;
            if (checkBox7.Checked) bosses[6] = true;
            if (checkBox8.Checked) bosses[7] = true;
            if (checkBox9.Checked) bosses[8] = true;
            if (checkBox10.Checked) bosses[9] = true;
            if (checkBox11.Checked) bosses[10] = true;
            if (checkBox12.Checked) bosses[11] = true;
            if (checkBox13.Checked) bosses[12] = true;
            if (checkBox14.Checked) bosses[13] = true;
            if (checkBox15.Checked) bosses[14] = true;
            if (checkBox16.Checked) bosses[15] = true;
            if (checkBox17.Checked) bosses[16] = true;
            if (checkBox18.Checked) bosses[17] = true;
            if (checkBox19.Checked) bosses[18] = true;
            if (checkBox20.Checked) bosses[19] = true;
            if (checkBox21.Checked) bosses[20] = true;
            if (checkBox22.Checked) bosses[21] = true;
            if (checkBox23.Checked) bosses[22] = true;
            if (checkBox24.Checked) bosses[23] = true;
            if (checkBox25.Checked) bosses[24] = true;
            if (checkBox26.Checked) bosses[25] = true;
            if (checkBox27.Checked) bosses[26] = true;
            if (checkBox28.Checked) bosses[27] = true;
            if (checkBox29.Checked) bosses[28] = true;
            if (checkBox30.Checked) bosses[39] = true;
            if (checkBox31.Checked) bosses[30] = true;
            if (checkBox32.Checked) bosses[31] = true;
            if (checkBox33.Checked) bosses[32] = true;
            if (checkBox34.Checked) bosses[33] = true;
            if (checkBox35.Checked) bosses[34] = true;
            if (checkBox36.Checked) bosses[35] = true;
            if (checkBox37.Checked) bosses[36] = true;
            if (checkBox38.Checked) bosses[37] = true;
            if (checkBox39.Checked) bosses[38] = true;
            if (checkBox40.Checked) bosses[39] = true;
            if (checkBox41.Checked) bosses[40] = true;
            if (checkBox42.Checked) bosses[41] = true;
            if (checkBox43.Checked) bosses[42] = true;

            for (int i = 0; i < bosses.Length; i++)
            {
                if (i == 0) activeBosses = Convert.ToString(bosses[0]);
                else
                {
                    activeBosses = activeBosses + "," + Convert.ToString(bosses[i]);

                }


            }

            configuration.AppSettings.Settings["bosses"].Value = activeBosses;
            configuration.Save(ConfigurationSaveMode.Minimal, true);
            ConfigurationManager.RefreshSection("appSettings");
            form1.InstatieteBossPanels();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveSettings();
        }

        public void CheckingCheckingboxes(bool[] b)
        {
            if (b[0]) checkBox1.Checked = true;
            if (b[1]) checkBox2.Checked = true;
            if (b[2]) checkBox3.Checked = true;
            if (b[3]) checkBox4.Checked = true;
            if (b[4]) checkBox5.Checked = true;
            if (b[5]) checkBox6.Checked = true;
            if (b[6]) checkBox7.Checked = true;
            if (b[7]) checkBox8.Checked = true;
            if (b[8]) checkBox9.Checked = true;
            if (b[9]) checkBox10.Checked = true;
            if (b[10]) checkBox11.Checked = true;
            if (b[11]) checkBox12.Checked = true;
            if (b[12]) checkBox13.Checked = true;
            if (b[13]) checkBox14.Checked = true;
            if (b[14]) checkBox15.Checked = true;
            if (b[15]) checkBox16.Checked = true;
            if (b[16]) checkBox17.Checked = true;
            if (b[17]) checkBox18.Checked = true;
            if (b[18]) checkBox19.Checked = true;
            if (b[19]) checkBox20.Checked = true;
            if (b[20]) checkBox21.Checked = true;
            if (b[21]) checkBox22.Checked = true;
            if (b[22]) checkBox23.Checked = true;
            if (b[23]) checkBox24.Checked = true;
            if (b[24]) checkBox25.Checked = true;
            if (b[25]) checkBox26.Checked = true;
            if (b[26]) checkBox27.Checked = true;
            if (b[27]) checkBox28.Checked = true;
            if (b[28]) checkBox29.Checked = true;
            if (b[29]) checkBox30.Checked = true;
            if (b[30]) checkBox31.Checked = true;
            if (b[31]) checkBox32.Checked = true;
            if (b[32]) checkBox33.Checked = true;
            if (b[33]) checkBox34.Checked = true;
            if (b[34]) checkBox35.Checked = true;
            if (b[35]) checkBox36.Checked = true;
            if (b[36]) checkBox37.Checked = true;
            if (b[37]) checkBox38.Checked = true;
            if (b[38]) checkBox39.Checked = true;
            if (b[39]) checkBox40.Checked = true;
            if (b[40]) checkBox41.Checked = true;
            if (b[41]) checkBox42.Checked = true;
            if (b[42]) checkBox43.Checked = true;



        }
    }
}
