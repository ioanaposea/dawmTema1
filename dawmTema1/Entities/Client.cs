using System.Diagnostics;
using System.Security.Claims;

namespace dawmTema1.Entities
{
    public class Client
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public List<Session> Sessions { get; set; }

    }
}
