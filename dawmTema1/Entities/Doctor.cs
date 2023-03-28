namespace dawmTema1.Entities
{
    public class Doctor
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public List<Client> Clients { get; set; }
    }
}
