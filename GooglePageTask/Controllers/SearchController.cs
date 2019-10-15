using HtmlAgilityPack;
using Microsoft.AspNetCore.Mvc;

namespace GooglePageTask.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        [HttpGet("{searchQuery}")]

        public ActionResult<string> Crawler(string searchQuery)
        {
            var url = "https://www.google.com/search?q="+searchQuery;
            var web = new HtmlWeb();
            var doc = web.Load(url);
            return doc.ToString();
        }
    }
}