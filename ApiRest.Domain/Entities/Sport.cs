using System.Text.Json.Serialization;

namespace ApiRest.Domain.Entities
{
    public class Sport
    {
        public int Id { get; set; }
        public string? Name { get; set; } = null;
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }

        [JsonIgnore]
        public List<Sport> Sports { get; set; } = new();
    }
}
