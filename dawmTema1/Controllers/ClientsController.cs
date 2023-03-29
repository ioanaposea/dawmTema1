using Microsoft.AspNetCore.Mvc;
using dawmTema1.Services;
using dawmTema1.Entities;
using dawmTema1.Dtos;

namespace dawmTema1.Controllers
{
    [ApiController]
    [Route("api/clients")]
    public class ClientsController : ControllerBase
    {
        private ClientService clientService { get; set; }


        public ClientsController(ClientService clientService)
        {
            this.clientService = clientService;
        }

        [HttpGet("/get-all-clients")]
        public ActionResult<List<Client>> GetAll()
        {
            var results = clientService.GetAll();

            return Ok(results);
        }

        [HttpGet("/get/{clientId}")]
        public ActionResult<Client> GetById(int clientId)
        {
            var result = clientService.GetById(clientId);

            if (result == null)
            {
                return BadRequest("Client not fount");
            }

            return Ok(result);
        }

        [HttpPatch("edit-client-name")]
        public ActionResult<bool> GetById([FromBody] ClientUpdateDto clientUpdateModel)
        {
            var result = clientService.EditName(clientUpdateModel);

            if (!result)
            {
                return BadRequest("Client could not be updated.");
            }

            return result;
        }

        [HttpDelete("delete-client/{clientId}")]
        public bool DeleteById(int clientId)
        {
            try
            {
                var clientToDelete = clientService.GetById(clientId);

                if (clientToDelete == null)
                {
                    return false;
                }

                clientService.DeleteById(clientId);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}