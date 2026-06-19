using UnityEngine;
namespace PolyBuzzToVRChat.Platform.Generics.UI.OTBS.VRChat
{
    public class VRChatOTBSs : IOTBS
    {
        public GameObject VRChatTab;

        public void ClosePanel()
        {
            VRChatTab.SetActive(false);
        }

        public void OpenPanel()
        {
            VRChatTab.SetActive(true);
        }

        public class AvatarOTBS : VRChatOTBSs
        {
            public GameObject AvatarTab;
            public new void OpenPanel()
            {
                AvatarTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                AvatarTab.SetActive(false);
            }
        }
        public class AccountOTBS : VRChatOTBSs
        {
            public GameObject AccountTab;
            public new void OpenPanel()
            {
                AccountTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                AccountTab.SetActive(false);
            }
        }
        
        public class FriendsOTBS : VRChatOTBSs  
        {
            public GameObject FriendsTab;
            public new void OpenPanel()
            {
                FriendsTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                FriendsTab.SetActive(false);
            }
        }
        
        public class ChatOTBS : VRChatOTBSs
        {
            public GameObject ChatTab;
            public new void OpenPanel()
            {
                ChatTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                ChatTab.SetActive(false);
            }
        }
        
        public class SettingsOTBS : VRChatOTBSs
        {
            public GameObject SettingsTab;
            public new void OpenPanel()
            {
                SettingsTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                SettingsTab.SetActive(false);
            }
        }
        
        public class WorldOTBS : VRChatOTBSs
        {
            public GameObject WorldTab;
            public new void OpenPanel()
            {
                WorldTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                WorldTab.SetActive(false);
            }
        }
        
        public class InventoryOTBS : VRChatOTBSs
        {
            public GameObject InventoryTab;
            public new void OpenPanel()
            {
                InventoryTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                InventoryTab.SetActive(false);
            }
        }

        public class ShopOTBS : VRChatOTBSs
        {
            public GameObject ShopTab;
            public new void OpenPanel()
            {
                ShopTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                ShopTab.SetActive(false);
            }
        }
        
        public class MarketplaceOTBS : VRChatOTBSs
        {
            public GameObject MarketplaceTab;
            public new void OpenPanel()
            {
                MarketplaceTab.SetActive(true);
            }
            public new void ClosePanel()
            {
               MarketplaceTab.SetActive(false);
            }
        }

        public class HelpOTBS : VRChatOTBSs
        {
            public GameObject HelpTab;
            public new void OpenPanel()
            {
                HelpTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                HelpTab.SetActive(false);
            }
        }
        
        public class ProfileOTBS : VRChatOTBSs
        {
            public GameObject ProfileTab;
            public new void OpenPanel()
            {
                ProfileTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                ProfileTab.SetActive(false);
            }
        }

        public class AboutOTBS : VRChatOTBSs
        {
            public GameObject AboutTab;
            public new void OpenPanel()
            {
                AboutTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                AboutTab.SetActive(false);
            }
        }
        
        public class NotificationsOTBS : VRChatOTBSs
        {
            public GameObject NotificationTab;
            public new void OpenPanel()
            {
                NotificationTab.SetActive(true);
            }
            public new void ClosePanel()
            {
                NotificationTab.SetActive(false);
            }
        }
    }
}
