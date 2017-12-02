using System;
using System.Reflection;
using System.Web.Mvc;

namespace JenkinsDemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			DateTime ceationTime = System.IO.File.GetCreationTime(Assembly.GetExecutingAssembly().Location);
			ViewBag.Title = string.Format("Home Page - {0}:{1}", ceationTime.ToLongDateString(), ceationTime.ToLongTimeString());
			return View();
		}

		public int Add(int a, int b)
		{
			return a + b;
		}

		public int Subtract(int a, int b)
		{
			return a - b;
		}
	}
}
