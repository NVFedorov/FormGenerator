using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms.Controls
{
    internal class FillerControl : IControl
    {
        public string Class { get; set; }
        internal string Message { get; set; }

        public string GenerateHtml()
        {
            string html = $"<div>{this.Message}</div>";
            return html;
        }
    }
}
