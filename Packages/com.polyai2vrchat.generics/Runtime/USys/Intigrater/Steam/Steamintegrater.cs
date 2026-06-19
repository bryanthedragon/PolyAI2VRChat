using PolyBuzzToVRChat.Accounting;
using PolyBuzzToVRChat.Avatar;
using PolyBuzzToVRChat.Persona;
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

        private class Account : AbstractAccount<SteamPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        private class Avatar : AbstractAvatar<SteamAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        private class Persona : AbstractPersona<SteamPersona>
        {
            public void GetDisplayInfo()
            {
                DisplayInfo();   
            }
        }
    }
}