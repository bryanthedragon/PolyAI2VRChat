namespace PolyBuzzToVRChat.Platform.Generics.JsonLoader.Avatar
{
    public interface IAvatarJsonLoader
    {
        
    }

    namespace VRChat
    {
        public sealed class VRChatAvatarJsonLoader : IAvatarJsonLoader
        {

        }
    }

    namespace PolyBuzz
    {
        public sealed class PolyBuzzAvatarJsonLoader : IAvatarJsonLoader
        {

        }
    }

    namespace Steam
    {
        public sealed class SteamAvatarJsonLoader : IAvatarJsonLoader
        {

        }
    }
}