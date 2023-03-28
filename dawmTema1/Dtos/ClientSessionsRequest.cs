using dawmTema1.Entities;
using System.ComponentModel.DataAnnotations;

namespace dawmTema1.Dtos
{
    public class ClientSessionsRequest
    {
        [Required]
        public int ClientId { get; set; }

        [Required]
        public Procedure Procedure { get; set; }
    }
}