using steelcm.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace steelcm.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Index()
        {
            var contactModel = new ContactModel();
            return View(contactModel);
        }

        [HttpPost]
        public  ActionResult Index(ContactModel contactModel)
        {
            return (ModelState.IsValid)
                ? Index() : View(contactModel);
        }
	}
}