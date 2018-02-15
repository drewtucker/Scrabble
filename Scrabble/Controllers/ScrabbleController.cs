using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using ScrabbleApp.Models;

namespace ScrabbleApp.Controllers
{
  public class ScrabbleAppController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/scrabble/form")]
    public ActionResult Form()
    {
      return View();
    }

    [HttpPost("/scrabble/display")]
    public ActionResult Display()
    {
      Scrabble.DeleteAll();
      string userInput = (Request.Form["scrabbleInput"]);
      int result = Scrabble.ScrabbleCalc(userInput);
      return View("Index", result);
    }



  }
}
