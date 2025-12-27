using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Base;

namespace PolyBuzzToVRChat.UI.VRChat
{
    public class VRChat : Menu<VRChatMenu>
    {
        public void OpenWindow()
        {
            base.Open();
            // Open the VRChat menu
        }
        
        public void CloseWindow()
        {
            base.Close();
            // Close the VRChat menu
        }
    }
}