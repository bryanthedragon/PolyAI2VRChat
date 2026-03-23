using PolyBuzzToVRChat.Accounting.Base;
using PolyBuzzToVRChat.Persona.Base;
using PolyBuzzToVRChat.Avatar.Base;
using PolyBuzzToVRChat.Platform.Generics.Persona;
using PolyBuzzToVRChat.Platform.Generics.Accounts;
using PolyBuzzToVRChat.Platform.Generics.Avatars;

namespace PolyBuzzToVRChat.Integrator.PolyBuzz
{
    public class PolyBuzzIntegrator
    {
        public void Integrate()
        {
            // Integration logic goes here
        }

        private class AccountIntegrator : Account<PolyBuzzPlatform>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }

        private class PersonaIntegrator : Persona<PolyBuzzPersona>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
        
        private class AvatarIntegrator : Avatar<PolyBuzzAvatar>
        {
            public void GetDisplayInfo() 
            {
                DisplayInfo();
            }
        }
    }
}