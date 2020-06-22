using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelloASPDotNET.Controllers
{
    [Route("/helloworld")]    
    public class HelloController : Controller
    {
        
        [HttpGet]        
        public IActionResult Index()
        {
            string html = "<form method='post' action='/helloworld/'>" +
               "<input type='text' name='name' />" +

               "<label for='Language'></label>"+
                   "<select name='lang' id='Language'>" +
                       "<option value=''>--Please choose a Language--</option>"+
                       "<option value='english'>English</option>" +
                       "<option value='spanish'>Spanish</option>" +
                       "<option value='french'>French</option>" +
                       "<option value='german'>German</option>" +
                       "<option value='italian'>Italian</option>" +
                       "<option value='hindi'>Hindi</option>" +
                    "</select>" +
                 "<input type='submit' value='Greet Me!' />" +
               "</form>";

            return Content(html, "text/html");
        }

        //[HttpGet("welcome/{name?}")]
        //[HttpPost]
        //public IActionResult Welcome(string name = "World")
        //{
        //    return Content("<h1>Welcome to my app, " + name + "!</h1>", "text/html");
        //}

        [HttpGet("welcome/{language?}")]
        [HttpPost]
        public IActionResult CreateMessage(string lang, string name = " ")
        {
            if (lang == "english")
            {
                return Content("<h1>Hi, " + name + "!</h1>", "text/html");
            }
            else if (lang == "french")
            {
                return Content("<h1>BonJour, " + name + "!</h1>", "text/html");
            }
            else if (lang == "italian")
            {
                return Content("<h1>Ciao, " + name + "!</h1>", "text/html");
            }
            else if (lang == "german")
            {
                return Content("<h1>Hallo, " + name + "!</h1>", "text/html");
            }
            else if(lang == "spanish")
            {
                return Content("<h1>Hola, " + name + "!</h1>", "text/html");
            }
            else if (lang == "hindi")
            {
                return Content("<h1>Namaste, " + name + "!</h1>", "text/html");
            }
            return Content("<h1>Hello, " + name + "!</h1>", "text/html");
        }
    }
}
