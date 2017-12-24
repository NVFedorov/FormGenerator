using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms.Controls
{
    internal class CheckboxControl : DataControlAbstract
    {
        internal bool Checked { get; set; }

        public override string GenerateHtml()
        {
            var check = this.Checked ? "checked" : string.Empty;
            var props = this.GenerateProperties();
            string html = $"<input type=\'checkbox\' {props.Properties} {check}/>{props.Label}";
            return this.GenerateControl(html);
        }
    }
}
