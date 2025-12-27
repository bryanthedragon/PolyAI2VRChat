using PolyBuzzToVRChat.Platform.Generics.Avatars;

namespace PolyBuzzToVRChat.Avatar.Base
{
    public abstract class Avatar<TAvatar> where TAvatar : IAvatar
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Id { get; set; }
        public string Customization { get; set; }
        public string[] Tags { get; set; }
        public string[] FriendsList { get; set; }

        public virtual string DisplayInfo()
        {
            return $"Name: {Name}, Description: {Description}, Id: {Id}, Customization: {Customization}, Tags: {string.Join(", ", Tags)}, FriendsList: {string.Join(", ", FriendsList)}";
        }
    }
}