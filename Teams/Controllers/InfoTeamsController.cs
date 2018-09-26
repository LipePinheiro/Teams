using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Teams.Data;
using Teams.Models;

namespace Teams.Controllers
{
    public class InfoTeamsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public InfoTeamsController(ApplicationDbContext context)
        {
            _context = context;
        }

   
        // GET: InfoTeams
        public async Task<IActionResult> Index(string equipas, string searchBy)
        {
            if (searchBy == "NameTeam")
            {
                return View(await _context.infoTeams.Where(x => x.Team_name.Contains(equipas) || equipas == null).ToListAsync());
            }
            else
            {
                return View(await _context.infoTeams.Where(x => x.Coach_name.Contains(equipas) || equipas == null).ToListAsync());
            }
            //var result = _context.infoTeams.Where(a => a.Team_name.ToString() == equipas);
            
        }

       

        // GET: InfoTeams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoTeams = await _context.infoTeams
                .FirstOrDefaultAsync(m => m.Team_Id == id);
            if (infoTeams == null)
            {
                return NotFound();
            }

            return View(infoTeams);
        }


        // GET: InfoTeams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InfoTeams/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Team_Id,Team_name,Coach_name,Maches_Played,Maches_Lost,Maches_Won")] InfoTeams infoTeams)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infoTeams);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infoTeams);
        }



        // GET: InfoTeams/Edit/id
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoTeams = await _context.infoTeams.FindAsync(id);
            if (infoTeams == null)
            {
                return NotFound();
            }
            return View(infoTeams);
        }

        // POST: InfoTeams/Edit/id
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Team_Id,Team_name,Coach_name,Maches_Played,Maches_Lost,Maches_Won")] InfoTeams infoTeams)
        {
            if (id != infoTeams.Team_Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoTeams);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoTeamsExists(infoTeams.Team_Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(infoTeams);
        }

        // GET: InfoTeams/Delete/id
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoTeams = await _context.infoTeams
                .FirstOrDefaultAsync(m => m.Team_Id == id);
            if (infoTeams == null)
            {
                return NotFound();
            }

            return View(infoTeams);
        }

        // POST: InfoTeams/Delete/id
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var infoTeams = await _context.infoTeams.FindAsync(id);
            _context.infoTeams.Remove(infoTeams);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoTeamsExists(int id)
        {
            return _context.infoTeams.Any(e => e.Team_Id == id);
        }
    }
}
