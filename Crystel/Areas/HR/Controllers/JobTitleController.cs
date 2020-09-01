using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using DataAccsess.Entity;
using System.Net.Http;
using Newtonsoft.Json;

namespace Crystel.Areas.HR.Controllers
{
    public class JobTitleController : Controller
    {
        // GET: HR/JobTitle
        public ActionResult NewJobTitle()
        {
            return View();
        }
        public async Task<ActionResult> JobTitlelist()
        {
            vmJob vm = new vmJob();
            List<Job_Title> JobList = new List<Job_Title>();
            string ApiUrl = "http://localhost/CrystelWebApi/api/JobTitle/MainJob";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(ApiUrl);
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await client.GetAsync(ApiUrl);
            if (responseMessage.IsSuccessStatusCode)
            {
                var responseData = responseMessage.Content.ReadAsStringAsync().Result;
                JobList = JsonConvert.DeserializeObject<List<Job_Title>>(responseData);
            }
            vm.jobs = JobList;
            return View("JobTitlelist", vm);
        }
        public ActionResult Update(int id)
        {
            ViewData["Id"] = id;
            return View("NewJobTitle");
        }
    }
}