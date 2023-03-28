using dawmTema1.Dtos;
using dawmTema1.Entities;

namespace dawmTema1.Mapping
{
    public static class SessionsMappingExtensions
    {
        public static List<SessionsDto> ToSessionDtos(this List<Session> session)
        {
            var results = session.Select(e => e.ToSessionDto()).ToList();

            return results;
        }

        public static SessionsDto ToSessionDto(this Session session)
        {
            if (session == null) return null;

            var result = new SessionsDto();
            result.NumberOfSessions = session.NumberOfSessions;
            result.Procedure = session.Procedure;

            return result;
        }
    }
}
