using Microsoft.AspNetCore.Mvc;
using dawmTema1.Services;
using dawmTema1.Entities;
using dawmTema1.Dtos;

namespace dawmTema1.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class ClientsController : ControllerBase
    {
        private ClientService clientService { get; set; }


        public ClientsController(ClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet("/get-all")]
        public ActionResult<List<Client>> GetAll()
        {
            var results = clientService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{studentId}")]
        public ActionResult<Client> GetById(int studentId)
        {
            var result = clientService.GetById(studentId);

            if (result == null)
            {
                return BadRequest("Student not fount");
            }

            return Ok(result);
        }

        [HttpPatch("edit-name")]
        public ActionResult<bool> GetById([FromBody] ClientUpdateDto studentUpdateModel)
        {
            var result = clientService.EditName(studentUpdateModel);

            if (!result)
            {
                return BadRequest("Student could not be updated.");
            }

            return result;
        }

        //[HttpPost("grades-by-course")]
        //public ActionResult<SessionsByClient> Get_CourseGrades_ByStudentId([FromBody] ClientSessionsRequest request)
        //{
        //    var result = clientService.GetGradesById(request.ClientId, request.Procedure);
        //    return Ok(result);
        //}

    }
}