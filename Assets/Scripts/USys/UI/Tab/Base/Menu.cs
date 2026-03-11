using PolyBuzzToVRChat.Platform.Generics.UI.Tab;

namespace PolyBuzzToVRChat.UI.Base.Tabs
{
    public class Tab<TTabs> where TTabs : ITabs
    {
        public bool isOpen;
        public bool isClosed;

        /// <summary>
        /// Opens the Tab.
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
        /// Closes the Tab.
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