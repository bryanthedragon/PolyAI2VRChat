using PolyBuzzToVRChat.Abstractor.UI.Menu;
using PolyBuzzToVRChat.Platform.Generics.UI.Menu;

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
    }
}