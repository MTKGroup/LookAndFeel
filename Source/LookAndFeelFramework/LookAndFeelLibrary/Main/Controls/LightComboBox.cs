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
    public class LightComboBox : ComboBox, IControl
    {
        public LightComboBox()
        {

        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new LightComboBox();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            //Font font = new System.Drawing.Font("Arial", 9);
            //e.Graphics.Clear(Color.Transparent);
            //e.Graphics.DrawString(this.Text, font, Brushes.LightBlue, 0, 0);
        }
    }
}
