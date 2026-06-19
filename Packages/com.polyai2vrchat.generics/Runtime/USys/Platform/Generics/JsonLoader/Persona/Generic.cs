namespace PolyBuzzToVRChat.Platform.Generics.JsonLoader.Persona
{
    public interface IPersonaJsonLoader
    {
        
    }

    namespace VRChat
    {
        public sealed class VRChatPersonaJsonLoader : IPersonaJsonLoader
        {

        }
    }

    namespace PolyBuzz
    {
        public sealed class PolyBuzzPersonaJsonLoader : IPersonaJsonLoader
        {

        }
    }

    namespace Steam
    {
        public sealed class SteamPersonaJsonLoader : IPersonaJsonLoader
        {

        }
    }
}