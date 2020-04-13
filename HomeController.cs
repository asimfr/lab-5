using JSon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JSon.Controllers
{
    public class HomeController : Controller
    {
        public static Student[] empList = new Student[]
{
new Student() {Name="Muhammad Ahmad", Regno="bse173099" , Cgpa=3.9 },
new Student() {Name="Usman khan", Regno="bse173097" , Cgpa=3.0 },
new Student() {Name="Asfand ali", Regno="bse173092" , Cgpa=2.3 },
new Student() {Name="Hamza farooq",Regno="bse173093" , Cgpa=3.5 },
};


        public JsonResult GetEmpData()
        {
            return Json(empList);
        }
    }
}