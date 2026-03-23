namespace AIToVRChat.Platform.Generics.UI.Tab.Steam
{
    public class SteamTabs : ITabs
    {
        public bool isActive { get; set; }
        public bool isVisible { get; set; }
        public bool isHovered { get; set; }
        public bool isFocused { get; set; }

        public virtual void Close()
        {
            isActive = false;   
        }

        public virtual void Open()
        {
            isActive = true;   
        }
        
        public class AccountTab : SteamTabs
        {
            public override void Close()
            {
                isActive = false;   
            }

            public override void Open()
            {
                isActive = true;   
            }
        }
    }
}