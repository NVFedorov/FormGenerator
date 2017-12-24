using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms.Controls
{
    internal class ButtonControl : IControl
    {
        public string Class { get; set; }
        public string Text { get; set; }

        public string GenerateHtml()
        {
            var html = $"<div><p><button class=\'{this.Class}\' onclick=\'send();\'>{this.Text}</button></p></div>";
            return html;
        }
    }
}
