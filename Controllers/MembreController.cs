using ProjetC_MVCSalleSport.Models;
using System.Linq;
using System.Web.Mvc;

namespace ProjetC_MVCSalleSport.Controllers
{
    public class MembreController : Controller
    {
        private readonly ContexteDeBaseDeDonnees _context;

        public MembreController()
        {
            _context = new ContexteDeBaseDeDonnees();
        }

        [HttpGet]
        public ActionResult ListeMembres()
        {
            var membres = _context.Membres.ToList();
            return View("listeMembres", membres);
        }


        [HttpGet]
        public ActionResult Ajouter()
        {
            return View("AjouterMembre");
        }


        [HttpPost]
        public ActionResult AjouterMembre(Membre membre)
        {
            if (ModelState.IsValid)
            {
                _context.Membres.Add(membre);
                _context.SaveChanges();
                return RedirectToAction("ListeMembres");
            }
            return View(membre);
        }
    }
}
