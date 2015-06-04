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
    public class DarkCheckBox : CheckBox, IControl
    {

        public DarkCheckBox()
        {
            
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkCheckBox();

            //set info for newControl
            //....

            return newControl;
        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            //Font font = new System.Drawing.Font("Arial", 9);
            //e.Graphics.Clear(Color.Transparent);
            System.Windows.Forms.TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point( 18, 7), Color.Red);
        }
    }
}
