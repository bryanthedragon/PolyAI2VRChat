using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Base;

namespace PolyBuzzToVRChat.UI.Persona.Menu
{
        public class PersonaUI : Menu<PersonaMenu>
    {
        /// <summary>
        /// Opens the Persona menu.
        /// </summary>
        public void OpenWindow()
        {
            base.Open();
            // Open the Persona menu
        }
        
        /// <summary>
        /// Closes the Persona menu.
        /// </summary>
        public void CloseWindow()
        {
            base.Close();
            // Close the Persona menu
        }
    }
}