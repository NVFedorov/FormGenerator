using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms.Controls
{
    internal class TextControl : DataControlAbstract
    {
        public override string GenerateHtml()
        {
            var props = this.GenerateProperties();
            string html = $"{props.Label}<p/><input type=\'text\' {props.Properties}/>";
            return this.GenerateControl(html);
        }
    }
}
