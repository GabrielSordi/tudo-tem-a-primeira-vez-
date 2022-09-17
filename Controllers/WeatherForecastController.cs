using Microsoft.AspNetCore.Mvc;
using static System.IO.File;

namespace tudo_tem_a_primeira_vez_.Controllers;

[ApiController]
[Route("test")]
public class TestController : ControllerBase
{
    
    [HttpGet("oi")]

    public ActionResult OutroTest()
    
        
        {
            return Content(
                 ReadAllText ("viws/index.html"),
                 "text/html");
            
           return Content (@"
           <marquee>
           <h1>
           Hello World
           </h1>
           </marquee>","text/html");
        }

    

    [HttpGet]
    public string Test ()
    {
        return "Meu Backend está rodando";
    }
}
