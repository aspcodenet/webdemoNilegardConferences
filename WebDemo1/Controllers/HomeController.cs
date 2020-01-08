using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebDemo1.Models;

namespace WebDemo1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Register()
        {
            var model = new RegisterModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Register(RegisterModel model)
        {
            var cardNo = model.CardNo;
            var namn = model.Name;
            var email = model.Email;

            var fee = CalculateFee();
            BillCard(cardNo,fee);
            SaveToDb(namn,email,fee);
            SendConfirmationEmail(email);
            model.Registered = true;
            return View(model);
        }

        private void SendConfirmationEmail(string email)
        {
            //Npot implemented. But we send an confirmation email
        }

        private void SaveToDb(string namn, string email, decimal fee)
        {
            //Not implemented but you get the idea
            //lets say we use some ADO here!
        }

        private void BillCard(string cardNo, decimal fee)
        {
            //Not implemented...but you get the idea
        }

        private decimal CalculateFee()
        {
            if ((new DateTime(2020, 3, 30, 0, 0, 0) - DateTime.Now).TotalDays > 100)
                return 5000;
            return 10000;
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}