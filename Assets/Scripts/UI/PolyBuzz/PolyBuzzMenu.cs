using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Base;

namespace PolyBuzzToVRChat.UI.PolyBuzz
{
    public class PolyBuzz : Menu<PolyBuzzMenu>
    {
        public void OpenWindow()
        {
            base.Open();
             // Open the PolyBuzz menu
        }
        
        public void CloseWindow()
        {
            base.Close();
            // Close the PolyBuzz menu
        }
    }
}