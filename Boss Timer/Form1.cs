using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boss_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            BossPanel First = new BossPanel();

            First.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
            First.CreateEventHandlers();

            {
                BossPanel First2 = new BossPanel();
                First2.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First2.CreateEventHandlers();
                BossPanel First3 = new BossPanel();
                First3.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First3.CreateEventHandlers();
                BossPanel First4 = new BossPanel();
                First4.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First4.CreateEventHandlers();
                BossPanel First5 = new BossPanel();
                First5.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First5.CreateEventHandlers();
                BossPanel First6 = new BossPanel();
                First6.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First6.CreateEventHandlers();
                BossPanel First7 = new BossPanel();
                First7.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First7.CreateEventHandlers();
                BossPanel First8 = new BossPanel();
                First8.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First8.CreateEventHandlers();
                BossPanel First9 = new BossPanel();
                First9.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First9.CreateEventHandlers();
                BossPanel First10 = new BossPanel();
                First10.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First10.CreateEventHandlers();
                BossPanel First11 = new BossPanel();
                First11.InstantiatePanel(flowLayoutPanel1, 0, 0, "AncientArcher");
                First11.CreateEventHandlers();

            }
        }
    }
}
