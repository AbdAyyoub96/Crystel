using DataAccsess.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Crystel.Areas.HR.Controllers
{
    public class ProjectController : Controller
    {
        // GET: HR/Project
        public ActionResult ProjectName()
        {
            return View();
        }
        public async Task<ActionResult> ProjectList()
        {
            vmProject vm = new vmProject();
            List<ProjectName> ProjectList = new List<ProjectName>();
            string ApiUrl = "http://localhost/CrystelWebApi/api/Project/MainProject";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(ApiUrl);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                ProjectList = JsonConvert.DeserializeObject<List<ProjectName>>(responseData);
            }
            vm.projects = ProjectList;
            return View("ProjectList", vm);
        }
    }
}