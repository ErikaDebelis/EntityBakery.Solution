using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
  public class CategoriesContoller : Controllers
  {
    private readonly BakeryContext _db;
    
    public CategoriesContoller(BakeryContext db)
    {
      _db = db;
    }

    // public ActionResult Index()
    // {
    //   List<Category model = _db.Categories
    //     .Include(category => JointEntities)
    //     .ThenInclude(join => join.Product)
    //     .ToList();
    //   return View(model);
    // }

    // public ActionResult Create()
    // {
    //   return View();
    // }


  }
}