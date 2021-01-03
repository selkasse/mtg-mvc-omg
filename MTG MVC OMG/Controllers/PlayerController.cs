using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MTG_MVC_OMG.Data;
using MTG_MVC_OMG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG_MVC_OMG.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PlayerController(ApplicationDbContext db)
        {
            _db = db;
        }
        //public async Task<IActionResult> Index()
        //{
        //    var players = _db.Players.Include(p => p.PreferredFormat).Include(p => p.PreferredColor).AsNoTracking();


        //    return View(await players.ToListAsync());
        //}

        public IActionResult Index()
        {
            IEnumerable<Player> players = _db.Players;
            return View(players);
        }
        public IActionResult Create()
        {
            //ViewBag.Formats = from m in _db.Formats select m.Name;
            ViewBag.Formats = new SelectList(_db.Formats, "Id", "Name");
            ViewBag.Colors = new SelectList(_db.Colors, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Player player)
        {

            //ViewBag.Colors = from m in _db.Colors select m;
            //ViewBag.Formats = from m in _db.Formats select m;
            //player.PreferredColor = (Color)_db.Colors.Where(c => c.Id == player.PreferredColorId);
            //player.PreferredFormat = (Format)_db.Formats.Where(f=> f.Id == player.PreferredFormatId);
            //var selectedFormat = from format in _db.Formats where format.Id == player.PreferredFormatId select format;
            int formatId = player.PreferredFormatId;
            var format = _db.Formats.Find(formatId);
            player.PreferredFormat = format.Name;

            int colorId = player.PreferredColorId;
            var color = _db.Colors.Find(colorId);
            player.PreferredColor = color.Name;

            ViewBag.Formats = new SelectList(_db.Formats, "Id", "Name");
            ViewBag.Colors = new SelectList(_db.Colors, "Id", "Name");
            if (ModelState.IsValid)
            {

                _db.Players.Add(player);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(player);
            }
        }

        public IActionResult Edit(int? id)
        {

            ViewBag.Formats = new SelectList(_db.Formats, "Id", "Name");
            ViewBag.Colors = new SelectList(_db.Colors, "Id", "Name");
            if (id == null || id == 0)
            {
                return NotFound();
            }

            var player = _db.Players.Find(id);

            if (player == null)
            {
                return NotFound();
            }

            return View(player);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditPlayer(Player player)
        {
            int formatId = player.PreferredFormatId;
            var format = _db.Formats.Find(formatId);
            player.PreferredFormat = format.Name;

            int colorId = player.PreferredColorId;
            var color = _db.Colors.Find(colorId);
            player.PreferredColor = color.Name;

            if (ModelState.IsValid)
            {

                _db.Players.Update(player);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(player);
            }
        }

    }
}
