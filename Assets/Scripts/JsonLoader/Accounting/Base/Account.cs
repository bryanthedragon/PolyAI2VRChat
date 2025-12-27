namespace PolyBuzzToVRChat.Accounting.Base
{
    public abstract class AccountJsonLoader<TPlatform> where TPlatform : IPlatform
    {
        public string Name { get; set; }
        
        public string Bio { get; set; }
        
        public string Gender { get; set; }
        
        public string Id { get; set; }
        
        public string Customization { get; set; }
        
        public string[] Tags { get; set; }
        
        public string[] FriendsList { get; set; }
        
        protected long AccountLink { get; set; }
    }
}