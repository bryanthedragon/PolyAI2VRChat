namespace PolyBuzzToVRChat.Platform.Generics.UI
{
    public interface IMenu
    {
        void Open();
        void Close();
    }
    public class PolyBuzzMenu : IMenu
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
    public class VRChatMenu : IMenu
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
    public class PersonaMenu : IMenu
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