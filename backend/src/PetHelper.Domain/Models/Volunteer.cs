namespace PetHelper.Domain.Models
{
    public class Volunteer
    {
        public Guid Id { get; private set; }
        public string FullName { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public int AgeExperience { get; private set; }
        public int PetsFoundHomeQuantity { get; private set; }  
        public int NumberOfPetsLookingForHome { get; private set; }
        public int NumberOfPetsTreated { get; private set; } 
        public string PhoneNumber { get; private set; } = string.Empty;
        public List<SocialNetwork> SocialNetworks { get; private set; } = [];
        public List<Requisites> Requisites { get; private set; } = [];
        public List<Pet> PetsOwnedVolunteer { get; private set; } = [];
    }
}
