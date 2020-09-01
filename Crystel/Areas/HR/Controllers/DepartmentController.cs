using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using DataAccsess.Entity;
using Newtonsoft.Json;

namespace Crystel.Areas.HR.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: HR/Department
        public ActionResult NewDepartment()
        {
            return View();
        }
        public async Task<ActionResult> DepartmentList()
        {
            vmDepartment vm = new vmDepartment();
            List<Department> DeptList = new List<Department>();
            string ApiUrl = "http://localhost/CrystelWebApi/api/Department/MainDept";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(ApiUrl);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                DeptList = JsonConvert.DeserializeObject<List<Department>>(responseData);
            }
            vm.Dept = DeptList;
            return View("DepartmentList",vm);
            
        }
        public ActionResult Update(int id)
        {
            ViewData["Id"] = id;
            return View("NewDepartment");
        }
    }
}