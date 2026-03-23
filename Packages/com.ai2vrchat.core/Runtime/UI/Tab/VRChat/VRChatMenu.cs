using AIToVRChat.Platform.Generics.UI.Tab;
using AIToVRChat.UI.Base.Tabs;

namespace AIToVRChat.UI.VRChat.Tab
{
    public class VRChatTabUI : Tab<IVRChatTab>
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
        protected class Avatar : VRChatTabUI
        {
            public new void OpenWindow()
            {
                Open();
                // Open the Avatar Tab
            }
            
            public new void CloseWindow()
            {
                Close();
                // Close the Avatar Tab
            }
        }
    }
}