using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcFinal.Models;

namespace MvcFinal.Controllers
{
    public class CADonerController : Controller
    {
        //
        // GET: /CAEmployee/

        public ActionResult Index()
        {
            CommunityAssistEntities cad = new CommunityAssistEntities();
            var doners = from d in cad.Donations
                            orderby d.Person.PersonLastName
                            select new
                            {
                                d.Person.PersonLastName,
                                d.Person.PersonFirstName,
                                d.Person.Donations,
                                d.DonationAmount,
                                d.Person.PersonUsername

                            };
            List<CADoner> donerList = new List<CADoner>();
            foreach (var x in doners)
            {
                CADoner don = new CADoner();
                don.LastName = x.PersonLastName;
                don.FirstName = x.PersonFirstName;
                don.Email = x.PersonUsername;
                don.Donation = x.DonationAmount.ToString();

                donerList.Add(don);
            }

            return View(donerList);
        }

    }

    public class CADoner
    {
        public string LastName { set; get; }
        public string FirstName { set; get; }
        public string Email { set; get; }
        public string Donation { set; get; }
    }
}
