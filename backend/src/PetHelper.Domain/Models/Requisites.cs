namespace PetHelper.Domain.Models
{
    public class Requisites
    {
        private Requisites(string name, string description) 
        {
            Name = name;
            Description = description;
        }
        public Guid Id { get; set; }
        public string Name { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;

        public static Requisites Create(string name, string description)
        {
            return new Requisites(name, description);

        }
    }
}
