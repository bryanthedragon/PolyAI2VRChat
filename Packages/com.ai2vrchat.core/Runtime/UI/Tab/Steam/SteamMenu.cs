using AIToVRChat.Platform.Generics.UI.Tab;
using AIToVRChat.Platform.Generics.UI.Tab.Steam;
using AIToVRChat.UI.Base.Tabs;

namespace AIToVRChat.UI.Steam.Tab
{
    public class SteamTabUI : Tab<ISteamTab>
    {
        /// <summary>
        /// Opens the SteamTab Tab.
        /// </summary>
        public void OpenWindow()
        {
            Open();
            // Open the SteamTab Tab
        }
        
        /// <summary>
        /// Closes the SteamTab Tab.
        /// </summary>
        public void CloseWindow()
        {
            Close();
            // Close the SteamTab Tab
        }
        protected class Account : SteamTabUI
        {
            /// <summary>
            /// Opens the Account Tab.
            /// </summary>
            public new void OpenWindow()
            {
                Open();
                // Open the Account Tab
            }
            
            /// <summary>
            /// Closes the Account Tab.
            /// </summary>
            public new void CloseWindow()
            {
                Close();
                // Close the Account Tab
            }
        }
    }
}