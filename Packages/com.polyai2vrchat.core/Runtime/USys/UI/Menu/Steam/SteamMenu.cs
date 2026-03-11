using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Base;

namespace PolyBuzzToVRChat.UI.Steam.Menu
{
    public class SteamUI : Menu<SteamMenu>
    {
        /// <summary>
        /// Opens the SteamMenu menu.
        /// </summary>
        public void OpenWindow()
        {
            base.Open();
            // Open the SteamMenu menu
        }
        
        /// <summary>
        /// Closes the SteamMenu menu.
        /// </summary>
        public void CloseWindow()
        {
            base.Close();
            // Close the SteamMenu menu
        }
    }
}