using Microsoft.AspNetCore.Mvc;

namespace demo_mvc.Controllers
{
    public class MoviesController : Controller
    {
       
        public string Index()
        {
            return "hello from index";
        }
        public IActionResult GetMovie(int id) //IActionResult all classes implent this interface
        {
            ContentResult result = new ContentResult();
            if (id < 10) 
                return BadRequest();
            if(id==100) return NotFound();
            
            return Content($"the id of movie {id}","text/html");
        }
    }
}
