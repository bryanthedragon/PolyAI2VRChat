namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab.Steam
{
    public class SteamTabs : ITabs
    {
        public bool isActive { get; set; }
        public bool isVisible { get; set; }
        public bool isHovered { get; set; }
        public bool isFocused { get; set; }

        public void Close()
        {
            isActive = false;   
        }

        public void Open()
        {
            isActive = true;   
        }
        public class AccountTab : SteamTabs
        {
            public new void Close()
            {
                isActive = false;   
            }

            public new void Open()
            {
                isActive = true;   
            }
        }
    }
}