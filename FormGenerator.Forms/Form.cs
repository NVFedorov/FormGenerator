using FormGenerator.Forms.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms
{
    internal class Form
    {
        internal Form()
        {
            this.Items = new List<IControl>();
        }

        internal string Name { get; set; }
        internal List<IControl> Items { get; set; }
        internal string Postmessage { get; set; }
    }
}
