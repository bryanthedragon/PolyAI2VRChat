using PolyBuzzToVRChat.Platform.Generics.UI;

namespace PolyBuzzToVRChat.UI.Base.Menu
{
    public class Menu<TMenu> where TMenu : IMenu
    {
        public bool isOpen;
        public bool isClosed;

        /// <summary>
        /// Opens the menu.
        /// </summary>
        /// <remarks>
        /// Sets <see cref="isClosed"/> to false and <see cref="isOpen"/> to true.
        /// </remarks>
        public void Open()
        {
            isOpen = true;
            isClosed = false;
        }
        
        /// <summary>
        /// Closes the menu.
        /// </summary>
        /// <remarks>
        /// Sets <see cref="isOpen"/> to false and <see cref="isClosed"/> to true.
        /// </remarks>
        public void Close()
        {
            isOpen = false;
            isClosed = true;
        }
    }
}