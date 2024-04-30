using System.Linq;
using System.Web.Mvc;
using ProjetC_MVCSalleSport.Models;

namespace ProjetC_MVCSalleSport.Controllers
{
    public class CoachController : Controller
    {
        private readonly ContexteDeBaseDeDonnees _context;

        public CoachController()
        {
            _context = new ContexteDeBaseDeDonnees();
        }

        [HttpGet]
        public ActionResult ListeCoaches()
        {
            var coaches = _context.Coaches.ToList();
            return View("ListeCoaches", coaches);
        }

        [HttpGet]
        public ActionResult Ajouter()
        {
            return View("AjouterCoach");
        }

        [HttpPost]
        public ActionResult AjouterCoach(Coach coach)
        {
            if (ModelState.IsValid)
            {
                _context.Coaches.Add(coach);
                _context.SaveChanges();
                return RedirectToAction("ListeCoaches");
            }
            return View(coach);
        }
    }
}
