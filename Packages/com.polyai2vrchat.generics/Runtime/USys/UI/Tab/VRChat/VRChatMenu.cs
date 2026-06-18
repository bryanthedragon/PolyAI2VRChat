using PolyBuzzToVRChat.Platform.Generics.UI.Tab;
using PolyBuzzToVRChat.UI.Base.Tabs;

namespace PolyBuzzToVRChat.UI.VRChat.Tab
{
    public class VRChatTabUI : Tab<VRChatTab>
    {
        /// <summary>
        /// Opens the VRChat Tab.
        /// </summary>
        public void OpenWindow()
        {
            Open();
            // Open the VRChat Tab
        }
        
        /// <summary>
        /// Closes the VRChat Tab.
        /// </summary>
        public void CloseWindow()
        {
            Close();
            // Close the VRChat Tab
        }
        protected class Avatar : Tab<VRChatTab.AccountTab>
        {
            public void OpenWindow()
            {
                Open();
                // Open the Avatar Tab
            }
            
            public void CloseWindow()
            {
                Close();
                // Close the Avatar Tab
            }
        }
    }
}