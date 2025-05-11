namespace Vet_website.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Species { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public ICollection<Procedure>? Procedures { get; set; }

        public Pet()
        {
            
        }
    }
}
