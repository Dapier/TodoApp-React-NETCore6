using Microsoft.AspNetCore.Mvc;

namespace reactapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        //context instance


        //GET Request
        //[HttpGet]
        //[Route("List")]

        //public async Task<IActionResult> List()
        //{
        //    List<Models.Task> task = _dbcontext.Tasks.OrderByDescending(t => t.IdTask).ThenBy(t => t.RegisterDate).ToList();

        //    Response.StatusCode = StatusCodes.Status200OK;
        //    return StatusCode(Response.StatusCode, task);
        //}

        //[HttpPost]
        //[Route("Save")]
        //public async Task<IActionResult> Save([FromBody] Task req)
        //{
        //    await _dbcontext.Tasks.AddAsync(req);
        //    await _dbcontext.SaveChangesAsync();

        //    return StatusCode(Response.StatusCode, "ok");
        //}


        //[HttpPost]
        //[Route("Close/{id:int}")]
        //public async Task<IActionResult> CloseTask(int id)
        //{
        //    Task task = _dbcontext.Tasks.Find(id);
        //    _dbcontext.Tasks.Remove(task);

        //    await _dbcontext.SaveChangesAsync();
        //    return StatusCode(Response.StatusCode, "ok");
        //}



    }

}
