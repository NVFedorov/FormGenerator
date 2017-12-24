using FormGenerator.Forms.Controls;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormGenerator.Forms
{
    public static class Generator
    {
        public static string CreateForm(string json)
        {
            var form = new Form();
            dynamic d = JObject.Parse(json);
            form.Name = d.form.name;
            form.Postmessage = d.form.postmessage;

            foreach(dynamic item in d.form.items)
            {
                form.Items.Add(ControlFactory.Create(item));
            }

            return Generator.GenerateHtml(form);
        }

        private static string GenerateHtml(Form form)
        {
            var html = string.Empty;
            foreach(var item in form.Items)
            {
                if (item != null)
                {
                    html += item.GenerateHtml();
                }
            }

            html += $"<div id=\'postMsg\' style=\'display: none;\'>{form.Postmessage}</div>";
            var postMsg = "<script src=\"/FormGenerator/Scripts/FormScript.js\"></script>";

            return html + postMsg;
            //return $"<form onsubmit=\'send(); return false;\'>{html + postMsg}</form>";
        }
    }
}
