using PolyBuzzToVRChat.Persona.Base;
using PolyBuzzToVRChat.Platform.Generics.Persona;

namespace PolyBuzzToVRChat.Persona.VRChat
{
    public class VRChat : Persona<VRChatPersona>
    {
        public new string DisplayInfo()
        {
            return base.DisplayInfo();
        }
    }
}