using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Avatar.Base;
using PolyBuzzToVRChat.Persona.Base;
using PolyBuzzToVRChat.Platform.Generics.Accounts;
using PolyBuzzToVRChat.Platform.Generics.Avatars;
using PolyBuzzToVRChat.Platform.Generics.Persona;

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