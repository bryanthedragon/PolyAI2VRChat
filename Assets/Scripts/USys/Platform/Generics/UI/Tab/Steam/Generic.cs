namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab.Steam
{
    public class SteamTabs : ITabs
    {
        bool ITabs.isActive { get; set; }
        bool ITabs.isVisible { get; set; }
        bool ITabs.isHovered { get; set; }
        bool ITabs.isFocused { get; set; }

        public void Close()
        {
            isActive()= false;   
        }

        public void Open()
        {
            isActive() = true;   
        }
        public class AccountTab : SteamTabs
        {
            public new void Close()
            {
                isActive()= false;   
            }

            public new void Open()
            {
                isActive() = true;   
            }
        }
    }
}