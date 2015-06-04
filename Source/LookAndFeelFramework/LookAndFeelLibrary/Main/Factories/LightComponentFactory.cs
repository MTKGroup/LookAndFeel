
using LookAndFeel.Controls;
using LookAndFeel.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LookAndFeel.Factories{
    /**
     * 
     */
    public class LightComponentFactory : ComponentFactory {

 
        /**
         * You need add component  samples  in here
         */
        public LightComponentFactory() {
            this.samples.Add(new LightButton());
            this.samples.Add(new LightForm());
        }

    }
}