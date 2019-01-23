using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Localization;


namespace D109.Controllers
{
    public class LanguageController : Controller
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public LanguageController(IHttpContextAccessor httpContextAccessor)
        {
            this._httpContextAccessor = httpContextAccessor;
        }

        public void changeLanguage1()
        {
            string cookie = _httpContextAccessor.HttpContext.Request.Cookies["Language"];
            if (cookie != null)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(cookie);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(cookie);
            }
                
        }

        static private string language = null;  
        // GET: Language
        public ActionResult Index()
        {
            return View();
        }

        static public void changeLanguage()
        {
            if (language != null)
            {
                System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo(language);
                System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo(language);
                //language = null;
            }
        }

        public IActionResult pl(string returnUrl)
        {
            Response.Cookies.Append("Language", "pl-PL");
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture: "pl-PL", uiCulture: "pl-PL")),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    IsEssential = true,  //critical settings to apply new culture
                    Path = "/",
                    HttpOnly = false,
                }
            );
            Console.WriteLine("Current Culture: {0}",
                              Request.Cookies[".AspNetCore.Culture"].ToString());
            language = "pl-PL";
            return LocalRedirect(returnUrl);

        }

        public IActionResult en(string returnUrl)
        {
            Response.Cookies.Append("Language", "en-US");
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture: "en-US", uiCulture: "en-US")),
                new CookieOptions
                {
                    Expires = DateTimeOffset.UtcNow.AddYears(1),
                    IsEssential = true,  //critical settings to apply new culture
                    Path = "/",
                    HttpOnly = false,
                }
            );
            language = "en-US";
            return LocalRedirect(returnUrl);

        }
    }
}