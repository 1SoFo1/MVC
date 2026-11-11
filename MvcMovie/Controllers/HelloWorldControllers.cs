using  Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers;

public class HelloWorldControllers : Controller
{
    public string Index()
    {
        return "This is my defaut action...";
    }
    
    public string Welcome()
    {
        return " This is the Welcome action method....";

    }


}
