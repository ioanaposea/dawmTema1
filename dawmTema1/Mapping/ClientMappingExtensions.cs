using dawmTema1.Dtos;
using dawmTema1.Entities;

namespace dawmTema1.Mapping
{
    public static class ClientMappingExtensions
    {
        public static ClientDto ToClientDto(this Client client)
        {
            if (client == null) return null;

            var result = new ClientDto();
            result.Id = client.Id;
            result.FullName = client.FirstName + " " + client.LastName;
            result.DoctorId = client.DoctorId;
            result.Doctor.LastName = client.Doctor?.LastName;
            result.Doctor.FirstName = client.Doctor?.FirstName;
            result.Sessions = client.Sessions.ToSessionDtos();

            return result;
        }
    }
}
