namespace Vet_website.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; } = null;
        public string Species { get; set; } = null;
        public DateTime DateOfBirth { get; set; }

        public ICollection<Procedure> Procedures { get; set; } = null;

        public Pet()
        {
            
        }
    }
}
