using AIToVRChat.Persona.Base;
using AIToVRChat.Platform.Generics.Persona;

namespace AIToVRChat.Persona.Steam
{
    public class Steam : Persona<SteamPersona>
    {
        public new string DisplayInfo()
        {
            return base.DisplayInfo();
        }
    }
}