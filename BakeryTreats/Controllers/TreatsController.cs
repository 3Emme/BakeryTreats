using Microsoft.AspNetCore.Mvc;
using BakeryTreats.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
namespace BakeryTreats.Controllers
{
  public class TreatsController : Controller
  {
    private readonly BakeryTreatsContext _db;
    public TreatsController(BakeryTreatsContext db)
    {
      _db = db ;
    }
    public ActionResult Index()
    {
      List<Treat> model = _db.Treats.ToList();
      return View(model);
    }
  }
}