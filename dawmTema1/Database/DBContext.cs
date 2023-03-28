using dawmTema1.Entities;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Security.Claims;

namespace dawmTema1.Database
{
    public static class DBContext
    {
        public static List<Doctor> Doctors = new List<Doctor>
        {
            new Doctor
            {
                Id = 1,
                FirstName = "Consuelo",
                LastName = "Ramirez",
                Clients = new List<Client>
                {
                    new Client
                    {
                        Id = 1,
                        FirstName = "Andrei",
                        LastName = "Popescu",
                        DoctorId = 1,
                        Sessions = new List<Session>
                        {
                            new Session
                            {
                                Id = 1,
                                NumberOfSessions = 8,
                                Procedure = Procedure.Microneedling,
                                ClientId = 1
                            },
                            new Session
                            {
                                Id = 2,
                                NumberOfSessions = 2,
                                Procedure = Procedure.WonderPrestige,
                                ClientId = 1
                            },
                               new Session
                            {
                                Id = 3,
                                NumberOfSessions = 12,
                                Procedure = Procedure.Morpheus,
                                ClientId = 1
                            },
                        }
                    },
                    new Client
                    {
                        Id = 2,
                        FirstName = "Ioana",
                        LastName = "Popa",
                        DoctorId = 1,
                        Sessions = new List<Session>
                        {
                            new Session
                            {
                                Id = 4,
                                NumberOfSessions = 2,
                                Procedure = Procedure.Morpheus,
                                ClientId = 2
                            },
                            new Session
                            {
                                Id = 5,
                                NumberOfSessions = 7,
                                Procedure = Procedure.HydraBeauty,
                                ClientId = 2
                            },
                               new Session
                            {
                                Id = 6,
                                NumberOfSessions = 5,
                                Procedure = Procedure.WonderPrestige,
                                ClientId = 2
                            },
                            new Session
                            {
                                Id = 7,
                                NumberOfSessions = 6,
                                Procedure = Procedure.LymphaticDrainage,
                                ClientId = 2
                            },
                        }
                    },
                    new Client
                    {
                        Id = 3,
                        FirstName = "Marian",
                        LastName = "Ciobanu",
                        DoctorId = 1,
                        Sessions = new List<Session>
                        {
                            new Session
                            {
                                Id = 8,
                                NumberOfSessions = 2,
                                Procedure = Procedure.LymphaticDrainage,
                                ClientId = 3
                            },
                        }
                    },
                    new Client
                    {
                        Id = 4,
                        FirstName = "Paul",
                        LastName = "Sandu",
                        DoctorId = 1,
                        Sessions = new List<Session>()
                    },
                    new Client
                    {
                        Id = 5,
                        FirstName = "Sonia",
                        LastName = "Balan",
                        DoctorId = 1,
                        Sessions = new List<Session>()
                    },
                }
            },
            new Doctor
            {
                Id = 2,
                FirstName = "Sanda",
                LastName = "Iordan",
                Clients = new List<Client>
                {
                    new Client
                    {
                        Id = 6,
                        FirstName = "Matei",
                        LastName = "Cristea",
                        DoctorId = 2,
                        Sessions = new List<Session>()
                    },
                    new Client
                    {
                        Id = 7,
                        FirstName = "Mara",
                        LastName = "Oprea",
                        DoctorId = 2,
                        Sessions = new List<Session>()
                    },
                    new Client
                    {
                        Id = 8,
                        FirstName = "Clara",
                        LastName = "Dinu",
                        DoctorId = 2,
                        Sessions = new List<Session>()
                    },
                    new Client
                    {
                        Id = 9,
                        FirstName = "Iustin",
                        LastName = "Danu",
                        DoctorId = 2,
                        Sessions = new List<Session>()
                    },
                    new Client
                    {
                        Id = 10,
                        FirstName = "Iulian",
                        LastName = "Ciobanu",
                        DoctorId = 2,
                        Sessions = new List<Session>()
                    },
                }
            }
        };

        public static List<Client> Clients = Doctors.SelectMany(x => x.Clients).ToList();

        public static List<Session> Sessions = Doctors.SelectMany(x => x.Clients.SelectMany(x => x.Sessions)).ToList();

    }
}
