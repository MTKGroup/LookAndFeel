
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Controls
{
    public class LightTextBox : TextBox, IControl
    {
        public LightTextBox(){
            this.BackColor = Color.LightBlue;
            this.Width = 100;
            this.Height = 30;
            
        }



        public override Components.IComponent clone(ComponentInfo info)
        {
            var newControl = new LightTextBox();

            //set info for newControl
            //....

            return newControl;

        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            Font font = new System.Drawing.Font("Arial", 9);
            e.Graphics.Clear(Color.LightBlue);
            e.Graphics.DrawString(this.Text, font, Brushes.White, 0, 0);


        }
  
  
    }

       
}
