using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using loanApp.Models;
using System.Web.Mvc;
using System.Data.SqlClient;


namespace loanApp.Models
{
    public class appelController : Controller
    {
        // GET: appel
        public ActionResult Index()
        {
            return View();
        }
    }
}