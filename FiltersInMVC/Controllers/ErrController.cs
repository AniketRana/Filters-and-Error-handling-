using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FiltersInMVC.Controllers
{
    [HandleError]
    public class ErrController : Controller
    {
        public ActionResult Index()
        {
            throw new Exception("This is a error");
        }
        public ActionResult About() 
        {
            throw new Exception("This is a error");
        }
    }
}