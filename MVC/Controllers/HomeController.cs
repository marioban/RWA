using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Login()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return View();
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Login(Korisnik k)
        {
            if (ModelState.IsValid)
            {
                if (Repository.ProvjeraUspjesnostiLogiranja(k))
                {
                    Session["Uspjeh"] = "Uspjeh";
                    return RedirectToAction("Index");
                }
                else
                {
                    ViewBag.poruka = "Netočna kombinacija emaila i lozinke!";
                    return View();
                }
            }
            else
            {
                ViewBag.poruka = "Netočna kombinacija emaila i lozinke!";
                return View();
            }
        }

        public ActionResult Odjava()
        {
            Session["Uspjeh"] = "";

            return RedirectToAction("Login");

        }

        public ActionResult Index()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.kupacCount = Repository.GetKupciCount();
            return View(Repository.GetKupci());
        }

        [HttpGet]
        public ActionResult Uredi(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.gradovi = Repository.GetGradovi();
            return View(Repository.GetKupac(id));
        }

        [HttpPost]
        public ActionResult Uredi(Kupac k)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                Repository.UpdateKupac(k);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.gradovi = Repository.GetGradovi();
                return View(k);
            }
        }

        [HttpGet]
        public ActionResult Dodaj()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.gradovi = Repository.GetGradovi();
            return View();
        }

        [HttpPost]
        public ActionResult Dodaj(Kupac k)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                Repository.InsertKupac(k);
                return View("Potvrda", k);
            }
            else
            {
                ViewBag.gradovi = Repository.GetGradovi();
                return View(k);
            }
        }

        public ActionResult Racuni()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View();
        }


        public ActionResult DetaljiRacuna(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View(Repository.GetSviPodaciRacuna(id));
        }

        public ActionResult Proizvodi()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View(Repository.GetProizvodi());
        }

        public ActionResult Potkategorije()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View(Repository.GetPotkategorije());
        }

        public ActionResult Kategorije()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View(Repository.GetKategorije());
        }

        [HttpGet]
        public ActionResult UrediKategoriju(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View(Repository.GetKategorijaById(id));
        }

        [HttpPost]
        public ActionResult UrediKategoriju(Kategorija k)
        {

            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }
            if (ModelState.IsValid)
            {
                Repository.UpdateKategorija(k);
                return RedirectToAction("Kategorije");
            }
            else
            {
                return View(k);
            }
        }



        [HttpGet]
        public ActionResult UrediPotkategoriju(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.kategorije = Repository.GetKategorije();
            return View(Repository.GetPotkategorijaById(id));
        }

        [HttpPost]
        public ActionResult UrediPotkategoriju(Potkategorija pk)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }
            Repository.UpdatePotkategorija(pk);
            return RedirectToAction("Potkategorije");

        }

        [HttpGet]
        public ActionResult UrediProizvod(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.potkategorije = Repository.GetPotkategorije();
            return View(Repository.GetProizvodById(id));
        }

        [HttpPost]
        public ActionResult UrediProizvod(Proizvod p)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            Repository.UpdateProizvod(p);
            return RedirectToAction("Proizvodi");

        }

        [HttpGet]
        public ActionResult DodajKategoriju()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            return View();
        }

        [HttpPost]
        public ActionResult DodajKategoriju(Kategorija k)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            if (ModelState.IsValid)
            {
                Repository.CreateKategorija(k);
                return View("KategorijaPotvrda", k);
            }
            else
            {
                return View(k);
            }
        }

        [HttpGet]
        public ActionResult DodajPotkategoriju()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.kategorije = Repository.GetKategorije();
            return View();
        }

        [HttpPost]
        public ActionResult DodajPotkategoriju(Potkategorija pk)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            Repository.CreatePotkategorija(pk);
            return View("PotkategorijaPotvrda", pk);

        }

        [HttpGet]
        public ActionResult DodajProizvod()
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            ViewBag.potkategorije = Repository.GetPotkategorije();
            return View();
        }

        [HttpPost]
        public ActionResult DodajProizvod(Proizvod p)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            Repository.CreateProizvod(p);
            return View("ProizvodPotvrda", p);

        }


        public ActionResult DeleteKategorija(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            Repository.DeleteKategorija(id);
            return View("BrisanjeKategorija");
        }

        public ActionResult DeletePotkategorija(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            Repository.DeletePotkategorija(id);
            return View("BrisanjePotkategorija");
        }
        public ActionResult DeleteProizvod(int id)
        {
            if ((string)Session["Uspjeh"] != "Uspjeh")
            {
                return RedirectToAction("Login");
            }

            Repository.DeleteProizvod(id);
            return View("BrisanjeProizvoda");
        }


        public ActionResult DohvatiRacune(int id)
        {
            var racuni = Repository.GetRacuniKupca(id);
            return PartialView("RacuniKupca", racuni);
        }

        public ActionResult DohvatiSvePodatkeRacuna(int id)
        {
            var racuni = Repository.GetSviPodaciRacuna(id);
            return PartialView("PrikaziRacune", racuni);
        }

    }
}