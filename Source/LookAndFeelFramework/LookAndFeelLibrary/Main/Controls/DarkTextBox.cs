using LookAndFeel.Components;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LookAndFeel.Controls
{
    public class DarkTextBox : TextBox
    {

        public DarkTextBox()
        {


        }

        public DarkTextBox(ComponentInfo info) : base(info)
        {
            BackColor = Color.FromArgb(228, 241, 254); 
            ForeColor = Color.Red;
            FontSize = MetroFramework.MetroTextBoxSize.Medium;
            UseCustomBackColor = true;
            UseCustomForeColor = true;
            Style = MetroFramework.MetroColorStyle.White;
            this.ForeColor = Color.FromArgb(34, 49, 63);
        }

        public override IComponent clone(ComponentInfo info)
        {
            var newControl = new DarkTextBox(info);


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


        }


        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            //this.ForeColor = Color.DarkGray;
        }

        protected override void OnForeColorChanged(EventArgs e)
        {
            base.OnForeColorChanged(e);  

        }

       
    }
}
