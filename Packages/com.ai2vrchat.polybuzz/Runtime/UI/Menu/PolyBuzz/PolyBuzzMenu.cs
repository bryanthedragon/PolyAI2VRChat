using AIToVRChat.Platform.Generics.UI;
using AIToVRChat.UI.Base.Menu;

namespace PolyBuzzToVRChat.UI.PolyBuzz.Menu
{
    public class PolyBuzzUI : Menu<PolyBuzzMenu>
    {
        /// <summary>
        /// Opens the PolyBuzz menu.
        /// </summary>
        public void OpenWindow()
        {
            base.Open();
             // Open the PolyBuzz menu
        }
        
        /// <summary>
        /// Closes the PolyBuzz menu.
        /// </summary>
        public void CloseWindow()
        {
            base.Close();
            // Close the PolyBuzz menu
        }

        public class PersonaUI : PolyBuzzUI
        {
            /// <summary>
            /// Opens the Persona menu.
            /// </summary>
            public new void OpenWindow()
            {
                base.Open();
                // Open the Persona menu
            }
            
            /// <summary>
            /// Closes the Persona menu.
            /// </summary>
            public new void CloseWindow()
            {
                base.Close();
                // Close the Persona menu
            }
        }
    }
}