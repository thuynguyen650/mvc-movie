﻿using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public string Index()
    {
        return "This is my default action...";
    }

    public string Welcome(string name, int id = 1)
    {
        return HtmlEncoder.Default.Encode($"Hello World: {name}, NumTimes is {id}");
    }
}
