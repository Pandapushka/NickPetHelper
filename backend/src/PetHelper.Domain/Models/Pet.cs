using PetHelper.Domain.Enums;
using System.Collections.Generic;

namespace PetHelper.Domain.Models
{
    public class Pet
    {
        public Pet(string name, string type, string description, string breed, string color,
                    string healthInfo, string address, double weight, double height, string phoneNumber,
                    bool isCastrated, DateOnly dateOfBirth, bool isVaccinated, Status status,
                    List<Requisites> requisites, DateTime createdDate, List<PetPhoto> photos)
        {
            Name = name;
            Type = type;
            Description = description;
            Breed = breed;
            Color = color;
            HealthInfo = healthInfo;
            Address = address;
            Weight = weight;
            Height = height;
            PhoneNumber = phoneNumber;
            IsCastrated = isCastrated;
            DateOfBirth = dateOfBirth;
            IsVaccinated  = isVaccinated;
            Status = status;
            Requisites = requisites;
            CreatedDate = createdDate;
            Photos = photos;      
        }
        public Guid Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Type { get; private set; } = string.Empty;
        public string Description { get; private set; } = string.Empty;
        public string Breed { get; private set; } = string.Empty;
        public string Color { get; private set; } = string.Empty;
        public string HealthInfo { get; private set; } = string.Empty;
        public string Address { get; private set; } = string.Empty;
        public double Weight { get; private set; }
        public double Height { get; private set; }
        public string PhoneNumber { get; private set; } = string.Empty;
        public bool IsCastrated { get; private set; } = false;
        public DateOnly DateOfBirth { get; private set; } = DateOnly.MinValue;
        public bool IsVaccinated { get; private set; } = false;
        public Status Status { get; private set; } = new Status();
        public List<Requisites> Requisites { get; private set; } = [];
        public DateTime CreatedDate { get; private set; } = DateTime.Now;
        public List<PetPhoto> Photos { get; private set; } = [];

        public static Pet Create(string name, string type, string description, string breed, string color,
                    string healthInfo, string address, double weight, double height, string phoneNumber,
                    bool isCastrated, DateOnly dateOfBirth, bool isVaccinated, Status status,
                    List<Requisites> requisites, DateTime createdDate, List<PetPhoto> photos)
        {
            return new Pet(name,  type,  description,  breed,  color,
                           healthInfo,  address,  weight,  height,  phoneNumber,
                           isCastrated, dateOfBirth,  isVaccinated, status,
                           requisites, createdDate, photos);
        }
    }
}
