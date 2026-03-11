using PolyBuzzToVRChat.Platform.Generics.UI;
using PolyBuzzToVRChat.UI.Steam.Menu;
using PolyBuzzToVRChat.UI.VRChat.Menu;
using PolyBuzzToVRChat.UI.PolyBuzz.Menu;

namespace PolyBuzzToVRChat.UI.Integrater
{
    public class UIIntegrater
    {
        class UIMenu : IMenu
        {
            PolyBuzzMenu PolyBuzzMenu;
            VRChatMenu VRChatMenu;
            SteamMenu SteamMenu;

            /// <summary>
            /// Initializes a new instance of the <see cref="UIMenu"/> class.
            /// </summary>
            /// <remarks>
            /// This constructor initializes a new <see cref="UIMenu"/> instance with the PolyBuzz, VRChat, and Steam menus.
            /// </remarks>
            public UIMenu()
            {
                PolyBuzzMenu = GetPolyBuzzMenu();
                VRChatMenu = GetVRChatMenu();
                SteamMenu = GetSteamMenu();
            }

            /// <summary>
            /// Gets a PolyBuzz menu.
            /// </summary>
            /// <returns>A PolyBuzz menu.</returns>
            private PolyBuzzMenu GetPolyBuzzMenu()
            {
                return new PolyBuzzMenu();
            }
            
            /// <summary>
            /// Gets the VRChat menu.
            /// </summary>
            /// <returns>The VRChat menu.</returns>
            private VRChatMenu GetVRChatMenu()
            {
                return new VRChatMenu();
            }

            /// <summary>
            /// Gets the Steam menu.
            /// </summary>
            /// <returns>The Steam menu.</returns>
            private SteamMenu GetSteamMenu()
            {
                return new SteamMenu();
            }
            
            /// <summary>
            /// Closes the currently open menu.
            /// </summary>
            /// <remarks>
            /// If the PolyBuzz menu is open, it will be closed. Otherwise, if the VRChat menu is open, it will be closed. Otherwise, the Steam menu will be closed.
            /// </remarks>
            public void Close()
            {
                if (PolyBuzzMenu.isOpen)
                {
                    PolyBuzzMenu.Close();
                }
                else if (VRChatMenu.isOpen)
                {
                    VRChatMenu.Close();
                }
                else if (SteamMenu.isOpen)
                {
                    SteamMenu.Close();
                }
            }

            /// <summary>
            /// Opens the currently selected menu.
            /// </summary>
            public void Open()
            {
                if (PolyBuzzMenu.isOpen)
                {
                    PolyBuzzMenu.Open();
                }
                else if (VRChatMenu.isOpen)
                {
                    VRChatMenu.Open();
                }
                else if (SteamMenu.isOpen)
                {
                    SteamMenu.Open();
                }
            }
        }
    }
}