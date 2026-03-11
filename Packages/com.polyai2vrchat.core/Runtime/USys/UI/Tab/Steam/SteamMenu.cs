using PolyBuzzToVRChat.Platform.Generics.UI.Tab;
using PolyBuzzToVRChat.Platform.Generics.UI.Tab.Steam;
using PolyBuzzToVRChat.UI.Base.Tabs;

namespace PolyBuzzToVRChat.UI.Steam.Tab
{
    public class SteamTabUI : Tab<SteamTab>
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
        protected class Account : Tab<SteamTabs.AccountTab>
        {
            /// <summary>
            /// Opens the Account Tab.
            /// </summary>
            public void OpenWindow()
            {
                Open();
                // Open the Account Tab
            }
            
            /// <summary>
            /// Closes the Account Tab.
            /// </summary>
            public void CloseWindow()
            {
                Close();
                // Close the Account Tab
            }
        }
    }
}