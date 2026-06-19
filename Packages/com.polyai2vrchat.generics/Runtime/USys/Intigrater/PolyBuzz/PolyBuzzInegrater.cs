using PolyBuzzToVRChat.Accounting;
using PolyBuzzToVRChat.Avatar;
using PolyBuzzToVRChat.Persona;
using PolyBuzzToVRChat.Platform.Generics.Accounts;
using PolyBuzzToVRChat.Platform.Generics.Avatars;
using PolyBuzzToVRChat.Platform.Generics.Persona;

namespace PolyBuzzToVRChat.Integrator.PolyBuzz
{
    public class PolyBuzzIntegrator
    {
        public void Integrate()
        {
            // Integration logic goes here
        }

        private class Account : AbstractAccount<PolyBuzzPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        class Persona : AbstractPersona<PolyBuzzPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        class Avatar : AbstractAvatar<PolyBuzzAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}