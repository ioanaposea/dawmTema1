namespace dawmTema1.Entities
{
    public class Session
    {
        public int Id { get; set; }
        public int NumberOfSessions { get; set; }
        public Procedure Procedure { get; set; }

        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
