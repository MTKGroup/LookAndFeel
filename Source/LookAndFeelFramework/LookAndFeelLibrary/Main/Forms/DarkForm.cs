
using LookAndFeel.Components;
using LookAndFeel.Factories;
using LookAndFeelLibrary.Main.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LookAndFeel.Forms{
    /**
     * 
     */
    public class DarkForm : Form {

        /**
         * 
         */
        public DarkForm() {
            this.BackColor = Color.Black;

            
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //cheat window button
            //List<System.Windows.Forms.Button> btns = new List<System.Windows.Forms.Button>();
            foreach (System.Windows.Forms.Control b in this.Controls)
            {

                if (b.GetType().Name.Equals("MetroFormButton"))
                {

                    var g = b.CreateGraphics();
                    g.Clear(Color.Transparent);
                    

                }



                //Console.WriteLine(b.GetType().Name);
            }
        }

        void b_Invalidated(object sender, System.Windows.Forms.InvalidateEventArgs e)
        {
            var g = ((System.Windows.Forms.Control)sender).CreateGraphics();
            g.Clear(Color.Transparent);
            
        }


        protected override void OnPaintBackground(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaintBackground(e);

        }

        protected override void OnPaint(System.Windows.Forms.PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.Clear(Color.FromArgb(0, 255, 1, 1));
            //Pen p = new Pen(Color.Fuchsia, 8);
            //g.DrawLine(p, 0, 0, Width, 0);

           

        }

        

        /**
         * @return
         */
        public override IComponent clone(ComponentInfo info)
        {
            return new DarkForm();
        }

    }
}

