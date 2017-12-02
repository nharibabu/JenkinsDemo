using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsDemo.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			string s = Server.MapPath("~");
			DirectoryInfo info = new DirectoryInfo(s);
			ViewBag.Title = string.Format("Home Page - {0} - {1}", info.LastWriteTimeUtc.ToLongDateString(), info.LastWriteTimeUtc.ToLongTimeString());
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
