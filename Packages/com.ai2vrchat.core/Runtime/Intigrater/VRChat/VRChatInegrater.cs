using AIToVRChat.Accounting.Base;
using AIToVRChat.Avatar.Base;
using AIToVRChat.Persona.Base;
using AIToVRChat.Platform.Generics.Accounts;
using AIToVRChat.Platform.Generics.Avatars;
using AIToVRChat.Platform.Generics.Persona;

namespace VRChatToVRChat.Integrator.VRChat
{
    public class VRChatIntegrator
    {
        public void Integrate()
        {
            // Integration logic goes here
        }

        private class AccountIntegrator : Account<VRChatPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        private class PersonaIntegrator : Persona<VRChatPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        private class AvatarIntegrator : Avatar<VRChatAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}