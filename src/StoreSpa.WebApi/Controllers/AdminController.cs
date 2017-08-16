using Microsoft.AspNetCore.Mvc;

namespace StoreSpa.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpPost]
        public string Login(string pwd, string uname)
        {
            return "logged in!";
        }

        [HttpPost]
        public string Logout(string uname)
        {
            return "logged out";
        }
    }
}
