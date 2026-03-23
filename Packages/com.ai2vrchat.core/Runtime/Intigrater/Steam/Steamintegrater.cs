using AIToVRChat.Accounting.Base;
using AIToVRChat.Avatar.Base;
using AIToVRChat.Persona.Base;
using AIToVRChat.Platform.Generics.Accounts;
using AIToVRChat.Platform.Generics.Avatars;
using AIToVRChat.Platform.Generics.Persona;

namespace SteamToVRChat.Integrator.Steam
{
    public class SteamIntegrator
    {
        public void Integrate()
        {
            // Integration logic goes here
        }

        private class Account : Account<SteamPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        class Persona : Persona<SteamPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        class Avatar : Avatar<SteamAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}