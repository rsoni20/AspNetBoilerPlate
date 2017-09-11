using ME.Controllers;
using Microsoft.AspNetCore.Antiforgery;

namespace ME.Web.Host.Controllers
{
    public class AntiForgeryController : MEControllerBase
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