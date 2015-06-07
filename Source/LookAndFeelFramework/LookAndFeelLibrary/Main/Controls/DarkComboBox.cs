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
    public class DarkComboBox : ComboBox, IControl
    {
        public DarkComboBox()
        {
            this.ForeColor = Color.DarkGray;
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkComboBox();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.DarkGray, 0, 0, this.Width, this.Height);
        }
    }
}
