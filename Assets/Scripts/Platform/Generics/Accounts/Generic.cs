namespace PolyBuzzToVRChat.Platform.Generics.Accounts
{
    public interface IPlatform
    {
        public string Name { get; set; }
        
        public string Bio { get; set; }
        
        public string Gender { get; set; }
        
        public string Id { get; set; }
        
        public string Customization { get; set; }
        
        public string[] Tags { get; set; }
        
        public string[] FriendsList { get; set; }
        
        protected long AccountLink { get; set; }
        
        public void DisplayInfo()
        {
            // Logic to display avatar information
            System.Console.WriteLine($"Name: {Name}, Bio: {Bio}, Id: {Id}, Customization: {Customization}, Tags: {string.Join(", ", Tags)}, FriendsList: {string.Join(", ", FriendsList)}");
        }
    }

    public sealed class VRChatPlatform : IPlatform
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public string Id { get; set; }
        public string Customization { get; set; }
        public string[] Tags { get; set; }
        public string[] FriendsList { get; set; }
        long IPlatform.AccountLink { get; set; }
    }

    public sealed class PolyBuzzPlatform : IPlatform
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public string Id { get; set; }
        public string Customization { get; set; }
        public string[] Tags { get; set; }
        public string[] FriendsList { get; set; }
        long IPlatform.AccountLink { get; set; }
    }

    public sealed class SteamPlatform : IPlatform
    {
        public string Name { get; set; }
        public string Bio { get; set; }
        public string Gender { get; set; }
        public string Id { get; set; }
        public string Customization { get; set; }
        public string[] Tags { get; set; }
        public string[] FriendsList { get; set; }
        long IPlatform.AccountLink { get; set; }
    }
}