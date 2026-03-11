using PolyBuzzToVRChat.Platform.Generics.UI.Tab;
using PolyBuzzToVRChat.UI.Base.Tabs;
using static PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI.AITabs.PolyBuzzTab;

namespace PolyBuzzToVRChat.UI.PolyBuzz.Tab
{
    public class PolyBuzzTabUI : Tab<AITab>
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
    }
}