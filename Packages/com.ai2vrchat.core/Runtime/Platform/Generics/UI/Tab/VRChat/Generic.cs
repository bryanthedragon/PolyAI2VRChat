namespace AIToVRChat.Platform.Generics.UI.Tab.VRChat
{
    public class VRChatTabs : ITabs
    {
        public bool isActive  { get; set; }
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

        public class AvatarTab : VRChatTabs
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
        
        public class AccountTab : VRChatTabs
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

        public class FriendsTab : VRChatTabs  
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
        
        public class ChatTab : VRChatTabs
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
        
        public class SettingsTab : VRChatTabs
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
        
        public class WorldTab : VRChatTabs
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
        
        public class InventoryTab : VRChatTabs
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

        public class ShopTab : VRChatTabs
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
        
        public class MarketplaceTab : VRChatTabs
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

        public class HelpTab : VRChatTabs
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
        
        public class ProfileTab : VRChatTabs
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

        public class AboutTab : VRChatTabs
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
        
        public class NotificationsTab : VRChatTabs
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