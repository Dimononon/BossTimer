using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace Boss_Timer
{
    internal class BossCDBar : ProgressBar
    {
        private Color channelColor = Color.LightSteelBlue;
        private Color sliderColor = Color.RoyalBlue;
        private int channelHeight = 10;
        private int sliderHeight = 10;

        private bool paintedBack = false;
        private bool stopPainting = false;

        //Constructor
        public BossCDBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.ForeColor = Color.White;
        }

        public Color ChannelColor
        {
            get
            {
                return channelColor;
            }
            set
            {
                channelColor = value;
                this.Invalidate();
            }
        }
        [Browsable(true)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public override Font Font { get => base.Font; set => base.Font = value; }
        //-> Paint the background & channel
        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (stopPainting == false)
            {
                if (paintedBack == false)
                {
                    //Fields
                    Graphics graph = pevent.Graphics;
                    Rectangle rectChannel = new Rectangle(0, 0, this.Width, channelHeight);
                    using (var brushChannel = new SolidBrush(channelColor))
                    {
                        if (channelHeight >= sliderHeight)
                            rectChannel.Y = this.Height - channelHeight;
                        else rectChannel.Y = this.Height - ((channelHeight + sliderHeight) / 2);

                        //Painting
                        graph.Clear(this.Parent.BackColor);//Surface
                        graph.FillRectangle(brushChannel, rectChannel);//Channel

                        //Stop painting the back & Channel
                        //if (this.DesignMode == false)
                        //    paintedBack = true;
                    }
                }
                //Reset painting the back & channel
                //if (this.Value == this.Maximum || this.Value == this.Minimum)
                //    paintedBack = false;
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (stopPainting == false)
            {
                //Fields
                Graphics graph = e.Graphics;
                double scaleFactor = (((double)this.Value - this.Minimum) / ((double)this.Maximum - this.Minimum));
                int sliderWidth = (int)(this.Width * scaleFactor);
                Rectangle rectSlider = new Rectangle(0, 0, sliderWidth, sliderHeight);
                using (var brushSlider = new SolidBrush(sliderColor))
                {
                    if (sliderHeight >= channelHeight)
                        rectSlider.Y = this.Height - sliderHeight;
                    else rectSlider.Y = this.Height - ((sliderHeight + channelHeight) / 2);
                    //Painting
                    if (sliderWidth > 1) //Slider
                        graph.FillRectangle(brushSlider, rectSlider);
                    //if (showValue != TextPosition.None) //Text
                    //    DrawValueText(graph, sliderWidth, rectSlider);
                }
                if (this.Value <= 150)
                {
                    sliderColor = Color.Red;
                }
                else if (this.Value <= 600)
                {
                    sliderColor = Color.Yellow;

                }
                else
                {
                    sliderColor = Color.Green;

                }
            }
            if (this.Value == Maximum) stopPainting = true;//Stop painting
            else stopPainting = false; //Keep painting
        }
    }
}
