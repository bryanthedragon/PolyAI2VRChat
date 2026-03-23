using AIToVRChat.Persona.Base;
using AIToVRChat.Platform.Generics.Persona;

namespace AIToVRChat.Persona.VRChat
{
    public class VRChat : Persona<VRChatPersona>
    {
        public new string DisplayInfo()
        {
            return base.DisplayInfo();
        }
    }
}