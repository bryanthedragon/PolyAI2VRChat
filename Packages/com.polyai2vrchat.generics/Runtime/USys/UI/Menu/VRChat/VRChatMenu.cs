using PolyBuzzToVRChat.Abstractor.UI.Menu;
using PolyBuzzToVRChat.Platform.Generics.UI.Menu;

namespace PolyBuzzToVRChat.UI.VRChat.Menu
{
    public class VRChatUI : Menu<VRChatMenu>
    {
        /// <summary>
        /// Opens the VRChat menu.
        /// </summary>
        public void OpenWindow()
        {
            base.Open();
            // Open the VRChat menu
        }
        
        /// <summary>
        /// Closes the VRChat menu.
        /// </summary>
        public void CloseWindow()
        {
            base.Close();
            // Close the VRChat menu
        }
    }
}