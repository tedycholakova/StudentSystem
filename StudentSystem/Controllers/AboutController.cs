using Microsoft.AspNetCore.Mvc;

namespace StudentSystem.Controllers
{
   [Route("[controller]/[action]")]
    public class AboutController : Controller
    {
        public string Phone()
        {
            return "1111-11-11";
        }

        public string Address()
        {
            return "Sofia";
        }
    }
}
