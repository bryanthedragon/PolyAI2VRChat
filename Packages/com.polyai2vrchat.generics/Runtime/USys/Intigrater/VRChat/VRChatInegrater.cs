using PolyBuzzToVRChat.Accounting;
using PolyBuzzToVRChat.Avatar;
using PolyBuzzToVRChat.Persona;
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

        private class Account : AbstractAccount<VRChatPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        private class Persona : AbstractPersona<VRChatPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        private class Avatar : AbstractAvatar<VRChatAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}