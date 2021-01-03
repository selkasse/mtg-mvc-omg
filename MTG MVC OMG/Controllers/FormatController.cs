using Microsoft.AspNetCore.Mvc;
using MTG_MVC_OMG.Data;
using MTG_MVC_OMG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_MVC_OMG.Controllers
{
    public class FormatController : Controller
    {
        private readonly ApplicationDbContext _db;

        public FormatController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
             IEnumerable<Format> formats = _db.Formats;

           return View(formats);
        }
    }
}
