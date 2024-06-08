using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using WebApi.Models; using Microsoft.EntityFrameworkCore;
namespace FullStackApplication.Controllers
{

    public class WeatherForecastController : ControllerBase
    {
        private readonly TodoListContext dbContext;

        public WeatherForecastController(TodoListContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            var l =  this.dbContext.TaskTranslations.ToList();
            return  new OkObjectResult(l);
        }
       
    }
}