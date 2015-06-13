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
            this.Width = 100;
            this.ForeColor = Color.LightBlue;
            
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


        }

        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);
            this.BackColor = Color.White;
            e.Graphics.FillRectangle(Brushes.LightBlue, 0, 0, this.Width, this.Height);
        }
  
  
    }

       
}