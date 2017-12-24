using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using FormGenerator.Models;

namespace FormGenerator.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var model = new RawFormModel { Json = "{\"form\":{\"name\":\"two\",\"items\":[{\"type\":\"filler\",\"message\":\"<h2>Письмо.</h2>\"},{\"type\":\"text\",\"name\":\"name\",\"placeholder\":\"\",\"required\":true,\"validationRules\":{\"type\":\"text\"},\"value\":\"\",\"label\":\"ФИО:\",\"class\":\"\",\"disabled\":false},{\"type\":\"text\",\"name\":\"tel\",\"placeholder\":\"\",\"required\":true,\"validationRules\":{\"type\":\"tel\"},\"value\":\"\",\"label\":\"Телефон:\",\"class\":\"\",\"disabled\":false},{\"type\":\"text\",\"name\":\"email\",\"placeholder\":\"\",\"required\":true,\"validationRules\":{\"type\":\"email\"},\"value\":\"\",\"label\":\"Email:\",\"class\":\"\",\"disabled\":false},{\"type\":\"select\",\"name\":\"select\",\"placeholder\":\"\",\"required\":true,\"validationRules\":{\"type\":\"select\"},\"label\":\"Должность:\",\"class\":\"\",\"disabled\":false,\"options\":[{\"value\":\"\",\"text\":\"\",\"selected\":true},{\"value\":\"1\",\"text\":\"Руководитель\",\"selected\":false},{\"value\":\"2\",\"text\":\"Аналитик\",\"selected\":false},{\"value\":\"3\",\"text\":\"ИТ-специалист\",\"selected\":false},{\"value\":\"25\",\"text\":\"ИТ-руководитель\",\"selected\":false},{\"value\":\"125\",\"text\":\"Пользователь\",\"selected\":false}]},{\"type\":\"filler\",\"message\":\"<p>Какой напиток предпочитаете во время презентации?</p>\",\"class\":\"\"},{\"type\":\"radio\",\"name\":\"radio\",\"placeholder\":\"\",\"required\":true,\"validationRules\":{\"type\":\"radio\"},\"disabled\":false,\"class\":\"\",\"items\":[{\"value\":\"1\",\"label\":\"Чай\",\"checked\":false},{\"value\":\"2\",\"label\":\"Кофе\",\"checked\":false},{\"value\":\"0\",\"label\":\"Вода\",\"checked\":false}]},{\"type\":\"button\",\"text\":\"Отправить\",\"class\":\"\"}],\"postmessage\":\"<p>Благодарим Вас за проявленный интерес, в течении рабочего дня с Вами свяжется наш сотрудник.</p>\"}}" };
            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return this.View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return this.View();
        }
    }
}