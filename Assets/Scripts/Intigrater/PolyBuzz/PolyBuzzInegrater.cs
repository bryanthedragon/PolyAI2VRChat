using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Avatar.Base;
using PolyBuzzToVRChat.Persona.Base;
using PolyBuzzToVRChat.Platform.Generics.Avatars;
using PolyBuzzToVRChat.Platform.Generics.Persona;
using PolyBuzzToVRChat.Platform.Generics.Accounts;

namespace PolyBuzzToVRChat.Integrator.PolyBuzz
{
    public class PolyBuzzIntegrator
    {
        public void Integrate()
        {
            // Integration logic goes here
        }

        private class Account : Account<PolyBuzzPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        class Persona : Persona<PolyBuzzPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        class Avatar : Avatar<PolyBuzzAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}