using dawmTema1.Entities;

namespace dawmTema1.Dtos
{
    public class SessionsByClient
    {
        public int? ClientId { get; set; }
        public string ClientCompleteName { get; set; }

        public List<SessionsDto> Sessions { get; set; } = new();

        public SessionsByClient(Client client)
        {

            ClientId = client?.Id;
            ClientCompleteName = client?.FirstName + " " + client?.LastName;

            if (client?.Sessions != null)
            {
                Sessions = client.Sessions
                    .Select(g => new SessionsDto
                    {
                        NumberOfSessions = g.NumberOfSessions,
                        Procedure = g.Procedure
                    })
                    .ToList();
            }
        }
    }
}