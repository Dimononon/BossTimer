using System;
using System.Configuration;
using System.Windows.Forms;

namespace Boss_Timer
{
    public partial class Form1 : Form
    {

        public Form1()
        {

            InitializeComponent();
            ConfigurateForm();

        }
        public void ConfigurateForm()
        {

            BossPanel AncientArcher = new BossPanel();
            BossPanel Slime = new BossPanel();
            BossPanel SteelGuard = new BossPanel();
            BossPanel Nightmare = new BossPanel();
            BossPanel Twins = new BossPanel();
            BossPanel FireLord = new BossPanel();
            BossPanel Spider = new BossPanel();
            BossPanel Drowned = new BossPanel();
            BossPanel Wizard = new BossPanel();
            BossPanel Death = new BossPanel();
            BossPanel Rider = new BossPanel();
            BossPanel Pillager = new BossPanel();
            BossPanel LavaCube = new BossPanel();
            BossPanel GhostHunter = new BossPanel();
            BossPanel BlackDragon = new BossPanel();
            BossPanel Giant = new BossPanel();
            BossPanel SnowMonster = new BossPanel();
            BossPanel AccursedLegion = new BossPanel();
            BossPanel Monstr = new BossPanel();
            BossPanel Necromancer = new BossPanel();
            BossPanel EaterOfDarkness = new BossPanel();
            BossPanel Chudo = new BossPanel();
            BossPanel Blacksmith = new BossPanel();
            BossPanel MightyShulker = new BossPanel();
            BossPanel Caster = new BossPanel();
            BossPanel DeadHourseman = new BossPanel();
            BossPanel Samurai = new BossPanel();
            BossPanel DeadLord = new BossPanel();
            BossPanel ShadowLord = new BossPanel();
            BossPanel Goliath = new BossPanel();
            BossPanel Destroyer = new BossPanel();
            BossPanel Scream = new BossPanel();
            BossPanel SpectralCube = new BossPanel();
            BossPanel Shadow = new BossPanel();
            BossPanel HeraldOfHell = new BossPanel();
            BossPanel Blaze = new BossPanel();
            BossPanel Piglin = new BossPanel();
            BossPanel Hoglin = new BossPanel();
            BossPanel ZombiePiglin = new BossPanel();
            BossPanel BrutalPiglin = new BossPanel();
            BossPanel Magma = new BossPanel();
            BossPanel Zoglin = new BossPanel();
            BossPanel HellKnight = new BossPanel();


            BossPanel[] bosses = new BossPanel[] { AncientArcher, Slime, SteelGuard, Nightmare, Twins, FireLord, Spider, Drowned,
                Wizard, Death, Rider, Pillager, LavaCube, GhostHunter, BlackDragon,Giant,SnowMonster,AccursedLegion,Monstr,Necromancer,
                EaterOfDarkness,Chudo,Blacksmith,MightyShulker,Caster,DeadHourseman,Samurai,DeadLord,ShadowLord,Goliath,Destroyer,Scream,
                SpectralCube,Shadow,HeraldOfHell,Blaze,Piglin,Hoglin,ZombiePiglin,BrutalPiglin,Magma,Zoglin,HellKnight };


            string bossName = "";
            string[] activeBossesStr = ConfigurationManager.AppSettings["bosses"].Split(',');
            bool[] activeBosses = new bool[43];
            for (int i = 0; i < activeBossesStr.Length; i++)
            {
                activeBosses[i] = Convert.ToBoolean(activeBossesStr[i]);
            }
            this.Width = Int32.Parse(ConfigurationManager.AppSettings["form1sizeX"]);
            this.Height = Int32.Parse(ConfigurationManager.AppSettings["form1sizeY"]);

            for (int i = 0; i < bosses.Length; i++)
            {
                if (activeBosses[i])
                {
                    if (bosses[i] == AncientArcher) bossName = "ancientArcherCD";
                    else if (bosses[i] == Slime) bossName = "slimeCD";
                    else if (bosses[i] == SteelGuard) bossName = "steelguardCD";
                    else if (bosses[i] == Nightmare) bossName = "nightmareCD";
                    else if (bosses[i] == Twins) bossName = "twinsCD";
                    else if (bosses[i] == FireLord) bossName = "fireLordCD";
                    else if (bosses[i] == Spider) bossName = "spiderCD";
                    else if (bosses[i] == Drowned) bossName = "drownedCD";
                    else if (bosses[i] == Wizard) bossName = "wizardCD";
                    else if (bosses[i] == Death) bossName = "deathCD";
                    else if (bosses[i] == Rider) bossName = "riderCD";
                    else if (bosses[i] == Pillager) bossName = "pillagerCD";
                    else if (bosses[i] == LavaCube) bossName = "lavaCubeCD";
                    else if (bosses[i] == GhostHunter) bossName = "ghostHunterCD";
                    else if (bosses[i] == BlackDragon) bossName = "blackDragonCD";
                    else if (bosses[i] == Giant) bossName = "giantCD";
                    else if (bosses[i] == SnowMonster) bossName = "snowMonsterCD";
                    else if (bosses[i] == AccursedLegion) bossName = "accursedLegionCD";
                    else if (bosses[i] == Monstr) bossName = "monstrCD";
                    else if (bosses[i] == Necromancer) bossName = "necromancerCD";
                    else if (bosses[i] == EaterOfDarkness) bossName = "eaterOfDarknessCD";
                    else if (bosses[i] == Chudo) bossName = "chudoCD";
                    else if (bosses[i] == Blacksmith) bossName = "blacksmithCD";
                    else if (bosses[i] == MightyShulker) bossName = "mightyShulkerCD";
                    else if (bosses[i] == Caster) bossName = "casterCD";
                    else if (bosses[i] == DeadHourseman) bossName = "deadHoursemanCD";
                    else if (bosses[i] == Samurai) bossName = "samuraiCD";
                    else if (bosses[i] == DeadLord) bossName = "deadLordCD";
                    else if (bosses[i] == ShadowLord) bossName = "shadowLordCD";
                    else if (bosses[i] == Goliath) bossName = "goliathCD";
                    else if (bosses[i] == Destroyer) bossName = "destroyerCD";
                    else if (bosses[i] == Scream) bossName = "screamCD";
                    else if (bosses[i] == SpectralCube) bossName = "spectralCubeCD";
                    else if (bosses[i] == HeraldOfHell) bossName = "heraldOfHellCD";
                    else if (bosses[i] == Blaze) bossName = "blazeCD";
                    else if (bosses[i] == Piglin) bossName = "piglinCD";
                    else if (bosses[i] == Hoglin) bossName = "hoglinCD";
                    else if (bosses[i] == ZombiePiglin) bossName = "zombiePiglinCD";
                    else if (bosses[i] == BrutalPiglin) bossName = "brutalPiglinCD";
                    else if (bosses[i] == Magma) bossName = "magmaCD";
                    else if (bosses[i] == Zoglin) bossName = "zoglinCD";
                    else if (bosses[i] == HellKnight) bossName = "hellKnightCD";
                    bosses[i].InstantiatePanel(flowLayoutPanel1, 0, 0, bossName);
                    bosses[i].CreateEventHandlers();
                }
            }





        }
        private void InstatieteBossPanels(BossPanel[] bosses, bool[] activebosses)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();

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

