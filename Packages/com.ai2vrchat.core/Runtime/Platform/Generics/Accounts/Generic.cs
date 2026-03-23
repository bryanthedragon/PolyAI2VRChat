namespace AIToVRChat.Platform.Generics.Accounts
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
        
        /// <summary>
        /// Displays the avatar information.
        /// </summary>
        /// <remarks>
        /// Outputs the avatar information to the console.
        /// </remarks>
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

    public sealed class CharacterPlatform : IPlatform
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

    public sealed class CHAI_Platform : IPlatform
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

    public sealed class BlushPlatform : IPlatform
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

    public sealed class XMatePlatform : IPlatform
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

    public sealed class EmochiPlatform : IPlatform
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

    public sealed class SoulON_Platform : IPlatform
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

    public sealed class SenkaiPlatform : IPlatform
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

    public sealed class SukaPlatform : IPlatform
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

    public sealed class FantasiaPlatform : IPlatform
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

    public sealed class SoulLinkPlatform : IPlatform
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

    public sealed class KindroidPlatform : IPlatform
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

    public sealed class RubiiPlatform : IPlatform
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

    public sealed class ZetaPlatform : IPlatform
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

    public sealed class MatePlatform : IPlatform
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

    public sealed class DreamMatePlatform : IPlatform
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

    public sealed class SaylaPlatform : IPlatform
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

    public sealed class LustPlatform : IPlatform
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

    public sealed class SparkPlatform : IPlatform
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

    public sealed class MiraiMindPlatform : IPlatform
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

    public sealed class BimoBimoPlatform : IPlatform
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
    
    public sealed class MeMePlatform : IPlatform
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

    public sealed class LinkyPlatform : IPlatform
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

    public sealed class KeilyPlatform : IPlatform
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
    
    public sealed class CrushPlatform : IPlatform
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
    
    public sealed class BALA_Platform : IPlatform
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
    
    public sealed class CrushiePlatform : IPlatform
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

    public sealed class ChatoraPlatform : IPlatform
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
    public sealed class FluffyTalkPlatform : IPlatform
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
    
    public sealed class JupiPlatform : IPlatform
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
    public sealed class DootchiPlatform : IPlatform
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
    public sealed class CyclePlatform : IPlatform
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

    public sealed class SnapMatePlatform : IPlatform
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

    public sealed class HanaPlatform : IPlatform
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

    public sealed class AnnaPlatform : IPlatform
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

    public sealed class EvaPlatform : IPlatform
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

    public sealed class janitorPlatform : IPlatform
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
    
    public sealed class UnknownPlatform : IPlatform
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