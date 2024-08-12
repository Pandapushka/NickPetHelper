namespace PetHelper.Domain.Models
{
    public class SocialNetwork
    {
        public SocialNetwork(string link, string name)
        {
            Link = link;
            Name = name;
        }
        public Guid Id { get; set; }
        public string Link { get; private set; } = string.Empty;
        public string Name { get; private set; } = string.Empty;

        public SocialNetwork Create(string link, string name)
        {
            return new SocialNetwork(link, name);
        }
    }
}
