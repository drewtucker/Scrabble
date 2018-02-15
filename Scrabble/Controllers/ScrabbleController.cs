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
      // List<int> newCoinList = Coin.GetAll();
      return View();
    }


  }
}
