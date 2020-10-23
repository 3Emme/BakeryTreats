using Microsoft.AspNetCore.Mvc;
using BakeryTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace BakeryTreats.Controllers
{
  public class FlavorsController : Controller
  {
    private readonly BakeryTreatsContext _db;
    public FlavorsController(BakeryTreatsContext db)
    {
      _db = db ;
    }
    public ActionResult Index()
    {
      return View(_db.Flavors.ToList());
    }
  }
}