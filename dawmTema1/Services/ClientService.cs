using dawmTema1.Dtos;
using dawmTema1.Entities;
using dawmTema1.Mapping;
using dawmTema1.Repositories;

namespace dawmTema1.Services
{
    public class ClientService
    {
        private ClientsRepository clientsRepository { get; set; }

        public ClientService(ClientsRepository clientsRepository)
        {
            this.clientsRepository = clientsRepository;
        }

        public List<Client> GetAll()
        {
            var results = clientsRepository.GetAll();

            return results;
        }

        public ClientDto GetById(int clientId)
        {
            var client = clientsRepository.GetById(clientId);

            var result = client.ToClientDto();

            return result;
        }

        public bool EditName(ClientUpdateDto payload)
        {
            if (payload == null || payload.FirstName == null || payload.LastName == null)
            {
                return false;
            }

            var result = clientsRepository.GetById(payload.Id);
            if (result == null) return false;

            result.FirstName = payload.FirstName;
            result.LastName = payload.LastName;

            return true;
        }

        //public SessionsByClient GetSessionsById(int clientId, Procedure procedure)
        //{
        //    var clientWithGrades = clientsRepository.GetByIdWithSessions(clientId, procedure);

        //    var result = new SessionsByClient(clientWithGrades);

        //    return result;
        //}
    }
}