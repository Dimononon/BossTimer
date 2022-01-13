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
        public SettingsForm()
        {
            InitializeComponent();
        }
        public SettingsForm(Form1 f)
        {
            InitializeComponent();
            textBox1.Text = ConfigurationManager.AppSettings["msInSec"];
        }
        public void RefreshConfig()
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.Save(ConfigurationSaveMode.Minimal);
            ConfigurationManager.RefreshSection("appSettings");
            ConfigurationManager.RefreshSection(config.AppSettings.SectionInformation.Name);
        }

    }
}
