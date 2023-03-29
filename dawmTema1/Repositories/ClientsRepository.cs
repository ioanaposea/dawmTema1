using dawmTema1.Database;
using dawmTema1.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace dawmTema1.Repositories
{
    public class ClientsRepository
    {
        public List<Client> GetAll()
        {
            var results = DBContext.Clients;

            return results;
        }

        public Client GetById(int clientId)
        {
            var result = DBContext.Clients
                .Where(e => e.Id == clientId)
                .FirstOrDefault();

            return result;
        }

        public Client DeleteClient(int clientId)
        {
            var result = DBContext.Clients
           .FirstOrDefault(e => e.Id == clientId);
            if (result != null)
            {
                DBContext.Clients.Remove(result);
                return result;
            }

            return null;
        }
    }
}
