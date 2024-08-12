using System.Collections.Generic;

namespace PetHelper.Domain.Models
{
    public class Volunteer
    {
        private Volunteer(string fullName, string description, int ageExperience, int petsFoundHomeQuantity,
                          int numberOfPetsLookingForHome, int numberOfPetsTreated, string phoneNumber,
                          List<SocialNetwork> socialNetworks, List<Requisites> requisites, List<Pet> petsOwnedVolunteer) 
        {
            FullName = fullName;
            Description = description;
            AgeExperience = ageExperience;
            PetsFoundHomeQuantity = petsFoundHomeQuantity;
            NumberOfPetsLookingForHome = numberOfPetsLookingForHome;
            NumberOfPetsTreated = numberOfPetsTreated;
            PhoneNumber = phoneNumber;
            SocialNetworks = socialNetworks;
            Requisites = requisites;
            PetsOwnedVolunteer = petsOwnedVolunteer;
        }
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

        public static Volunteer Create(string fullName, string description, int ageExperience, int petsFoundHomeQuantity,
                          int numberOfPetsLookingForHome, int numberOfPetsTreated, string phoneNumber,
                          List<SocialNetwork> socialNetworks, List<Requisites> requisites, List<Pet> petsOwnedVolunteer)
        {
            return new Volunteer(fullName, description, ageExperience, petsFoundHomeQuantity,
                                 numberOfPetsLookingForHome, numberOfPetsTreated, phoneNumber,
                                 socialNetworks, requisites, petsOwnedVolunteer);
        }
    }
}
