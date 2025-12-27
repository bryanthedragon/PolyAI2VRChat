using PolyBuzzToVRChat.Platform.Generics.UI;

namespace PolyBuzzToVRChat.UI.Base
{
    public class Menu<TMenu> where TMenu : IMenu
    {
        public bool isOpen;
        public bool isClosed;

        public void Open()
        {
            isOpen = true;
            isClosed = false;
        }
        
        public void Close()
        {
            isOpen = false;
            isClosed = true;
        }
    }
}