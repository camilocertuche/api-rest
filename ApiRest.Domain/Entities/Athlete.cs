using System.Text.Json.Serialization;

namespace ApiRest.Domain.Entities
{
    public class Athlete
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDay { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public int SportId { get; set; }

        [JsonIgnore]
        public Sport? Sport { get; set; }

    }
}