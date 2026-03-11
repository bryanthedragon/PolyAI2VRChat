namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab.VRChat
{
    public class VRChatTabs : ITabs
    {
        bool ITabs.isActive  { get; set; }
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

        public class AvatarTab : VRChatTabs
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
        
        public class AccountTab : VRChatTabs
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

        public class FriendsTab : VRChatTabs  
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
        
        public class ChatTab : VRChatTabs
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
        
        public class SettingsTab : VRChatTabs
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
        
        public class WorldTab : VRChatTabs
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
        
        public class InventoryTab : VRChatTabs
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

        public class ShopTab : VRChatTabs
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
        
        public class MarketplaceTab : VRChatTabs
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

        public class HelpTab : VRChatTabs
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
        
        public class ProfileTab : VRChatTabs
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

        public class AboutTab : VRChatTabs
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
        
        public class NotificationsTab : VRChatTabs
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