namespace Vet_website.Models
{
    public class Procedure
    {
        public int id { get; set; }
        public string Name { get; set; } = null;
        public string Description { get; set; } = null;
        public DateTime Date { get; set; }
        public float price { get; set; }

        public Procedure()
        {
            
        }

    }
}