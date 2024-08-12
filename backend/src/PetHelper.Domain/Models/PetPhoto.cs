namespace PetHelper.Domain.Models
{
    public class PetPhoto
    {
        private PetPhoto(string storagePath, bool isMain)
        {
            StoragePath = storagePath;
            IsMain = isMain;

        }
        public Guid Id { get; private set; }
        public string StoragePath { get; private set; } = default!;
        public bool IsMain { get; private set; }

        public static PetPhoto Create(string storagePath, bool isMain)
        {
            return new PetPhoto(storagePath, isMain);
        }
    }
}
