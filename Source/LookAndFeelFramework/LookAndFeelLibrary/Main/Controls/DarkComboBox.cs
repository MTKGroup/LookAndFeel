using LookAndFeel.Components;
using LookAndFeel.Controls;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public class DarkComboBox : ComboBox
    {
        private ComponentInfo info;

        public DarkComboBox()
        {
        }

        public DarkComboBox(ComponentInfo info)
        {
            // TODO: Complete member initialization
            this.info = new ComponentInfo();
            this.info.x = info.x;
            this.info.y = info.y;
            this.info.width = info.width;
            this.info.height = info.height;

        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkComboBox(info);


            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);

            foreach (var handler in this.clickHandlers)
            {
                handler(this);
            }
        }


        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            Pen pen = new Pen(Color.DarkGray, 4);

            e.Graphics.DrawRectangle(pen, 0, 0, this.Width, this.Height);
        }
    }
}
