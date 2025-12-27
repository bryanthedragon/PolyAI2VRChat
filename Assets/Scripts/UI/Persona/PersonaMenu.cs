using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Base;

namespace PolyBuzzToVRChat.UI.Persona
{
        public class Persona : Menu<PersonaMenu>
    {
        public void OpenWindow()
        {
            base.Open();
            // Open the Persona menu
        }
        
        public void CloseWindow()
        {
            base.Close();
            // Close the Persona menu
        }
    }
}