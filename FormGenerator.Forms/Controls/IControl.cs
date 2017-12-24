using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms.Controls
{
    internal interface IControl
    {
        string Class { get; set; }
        string GenerateHtml();
    }
}
