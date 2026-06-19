using PolyBuzzToVRChat.Platform.Generics.UI.Tab;
using PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI;
using PolyBuzzToVRChat.UI.Tabs;

namespace PolyBuzzToVRChat.UI.PolyBuzz.Tab
{
    public class PolyBuzzTabUI : Tab<PolyBuzzTabs>
    {
        /// <summary>
        /// Opens the PolyBuzz Tab.
        /// </summary>
        public void OpenWindow()
        {
            Open();
            // Open the PolyBuzz Tab
        }
        
        /// <summary>
        /// Closes the PolyBuzz Tab.
        /// </summary>
        public void CloseWindow()
        {
            Close();
            // Close the PolyBuzz Tab
        }
        protected class Persona : Tab<PersonaTab>
        {
            /// <summary>
            /// Opens the Persona Tab.
            /// </summary>
            public void OpenWindow()
            {
                Open();
                // Open the Persona Tab
            }
            
            /// <summary>
            /// Closes the Persona Tab.
            /// </summary>
            public void CloseWindow()
            {
                Close();
                // Close the Persona Tab
            }
        }
        protected class Account : Tab<PolyBuzzTabs.AccountTab>
        {
            /// <summary>
            /// Opens the Account Tab.
            /// </summary>
            public void OpenWindow()
            {
                Open();
                // Open the Account Tab
            }
            
            /// <summary>
            /// Closes the Account Tab.
            /// </summary>
            public void CloseWindow()
            {
                Close();
                // Close the Account Tab
            }
        }
    }
}