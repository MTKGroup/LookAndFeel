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
            this.ForeColor = Color.LightBlue;
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

           
            e.Graphics.DrawRectangle(Pens.LightBlue, 0, 0, this.Width, this.Height);
        
        }
    }
}