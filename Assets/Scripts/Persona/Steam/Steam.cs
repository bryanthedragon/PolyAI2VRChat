using PolyBuzzToVRChat.Persona.Base;
using PolyBuzzToVRChat.Platform.Generics.Persona;

namespace PolyBuzzToVRChat.Persona.Steam
{
    public class Steam : Persona<SteamPersona>
    {
        public new string DisplayInfo()
        {
            return base.DisplayInfo();
        }
    }
}