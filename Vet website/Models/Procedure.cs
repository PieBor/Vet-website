namespace Vet_website.Models
{
    public class Procedure
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? Date { get; set; }
        public float? Price { get; set; }

        public Procedure()
        {
            
        }

    }
}