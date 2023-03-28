using dawmTema1.Entities;

namespace dawmTema1.Dtos
{
    public class ClientDto
    {
        public int Id { get; set; }
        public string FullName { get; set; } 
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<SessionsDto> Sessions { get; set; }
    }
}
