using Microsoft.AspNetCore.Mvc;
using BakeryTreats.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace BakeryTreats.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryTreatsContext _db;
    public HomeController(BakeryTreatsContext db)
    {
      _db = db ;
    }
    [HttpGet("/")]
    public ActionResult Index()
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      List<Treat> treatsModel = _db.Treats.ToList();
      List<Flavor> flavorsModel = _db.Flavors.ToList();
      model.Add("treats", treatsModel);
      model.Add("flavors", flavorsModel);
      return View(model);
    }
  }
}
