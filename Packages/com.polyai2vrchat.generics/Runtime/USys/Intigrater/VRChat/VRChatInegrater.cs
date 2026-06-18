using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Avatar.Base;
using PolyBuzzToVRChat.Persona.Base;
using PolyBuzzToVRChat.Platform.Generics.Accounts;
using PolyBuzzToVRChat.Platform.Generics.Avatars;
using PolyBuzzToVRChat.Platform.Generics.Persona;

namespace VRChatToVRChat.Integrator.VRChat
{
    public class VRChatIntegrator
    {
        public void Integrate()
        {
            // Integration logic goes here
        }

        private class Account : Account<VRChatPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        private class Persona : Persona<VRChatPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        private class Avatar : Avatar<VRChatAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}