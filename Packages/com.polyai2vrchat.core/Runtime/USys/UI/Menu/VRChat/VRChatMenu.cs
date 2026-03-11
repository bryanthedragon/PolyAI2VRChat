using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Base;

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