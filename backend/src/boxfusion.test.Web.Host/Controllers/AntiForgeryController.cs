using Microsoft.AspNetCore.Antiforgery;
using Shesha.Controllers;

namespace boxfusion.test.Web.Host.Controllers
{
    public class AntiForgeryController : SheshaControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
