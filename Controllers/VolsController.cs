using FlyApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlyApp.Controllers
{
    public class VolsController : Controller
    {
        public IActionResult AddVols()
        {
            var userContext = new DAL.flyapp_DBEntities();
            IQueryable<DAL.User> IQ_user = userContext.Set<DAL.User>();
            ViewData["list_user"] = new List<DAL.User>(IQ_user);
            var avionContext = new DAL.flyapp_DBEntities();
            IQueryable<DAL.avion> IQ_avion = avionContext.Set<DAL.avion>();
            ViewData["list_avion"] = new List<DAL.avion>(IQ_avion);
            var AeroportContext = new DAL.flyapp_DBEntities();
            IQueryable<DAL.aeroport> IQ_aeroport = AeroportContext.Set<DAL.aeroport>();
            ViewData["list_aero_dep"] = new List<DAL.aeroport>(IQ_aeroport);
            ViewData["list_aero_arri"] = new List<DAL.aeroport>(IQ_aeroport);
            return View();

        }
        public ActionResult AddVolsRequest(DAL.User Id_aero_arri, String Username)
        {
            var i = Id_aero_arri.Id_user;
            return Content(Username);
        }
       /* public IActionResult Addvols(int Id_user)
        {
           /* IHtmlHelper htmlHelperSelectExtensions;
            SelectListItem selectListItem;
            int r = selectListItem.Selected;
            var volsContext = new DAL.flyapp_DBEntities();
            DAL.vols v = new DAL.vols()
            {
                id_user = Id_user,
                id_avion = Id_avion,
                id_aero_arri = Aero_arri,
                id_aero_dep = Aero_dep
            };
            var x = volsContext.vols.Add(v);
            volsContext.SaveChanges();
            return View();
        }*/
    }
    /*List<DAL.vols> GetVols()
        {
            var volsContext = new DAL.flyapp_DBEntities();
            IQueryable<DAL.vols> IQ_vols = volsContext.Set<DAL.vols>();
            List<DAL.vols> list_vols = new List<DAL.vols>(IQ_vols);
            return list_vols;
        }*/
       
       
      
}

