using Blog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            Random rd = new Random();

            var data = new List<Person>(){
                new Person () {Name="Jimmy", UrlDote="https://dotblogs.com.tw/jimmynotes", UrlImg="~/content/img/lufe.jpeg"},
                new Person () {Name="Miles", UrlDote="https://dotblogs.com.tw/mileslin", UrlImg="~/content/img/solon.jpeg"}
            }.OrderBy(o=> rd.Next()).ToList();
            
            return View(data);
        }
    }
}