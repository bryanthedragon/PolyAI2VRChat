using AIToVRChat.Platform.Generics.UI.Tab;
using PolyBuzzToVRChat.UI.Base.Tabs;
namespace PolyBuzzToVRChat.UI.PolyBuzz.Tab
{
    public class PolyBuzzTabUI : Tab<IAITab>
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
        protected class Persona : PolyBuzzTabUI
        {
            /// <summary>
            /// Opens the Persona Tab.
            /// </summary>
            public new void OpenWindow()
            {
                Open();
                // Open the Persona Tab
            }
            
            /// <summary>
            /// Closes the Persona Tab.
            /// </summary>
            public new void CloseWindow()
            {
                Close();
                // Close the Persona Tab
            }
        }
    }
}