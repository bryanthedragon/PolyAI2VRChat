using PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI;
using PolyBuzzToVRChat.Platform.Generics.UI.Tab.Steam;
using PolyBuzzToVRChat.Platform.Generics.UI.Tab.VRChat;

namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab
{
    public interface ITabs : IMenu
    {
        public bool isActive { get; set; }
        public bool isVisible { get; set; }
        public bool isHovered { get; set; }
        public bool isFocused { get; set; }      
    }
    public sealed class AITab : AITabs
    {
        public PolyBuzzTab PolyBuzz { get; set; }
    }
    public class SteamTab : SteamTabs
    {
        public AccountTab Account { get; set; }
    }
    public class VRChatTab : VRChatTabs
    {
        public AccountTab Account { get; set; }
        public FriendsTab Friends { get; set; }
        public ChatTab Chat { get; set; }
        public SettingsTab Settings { get; set; }
        public WorldTab World { get; set; }
        public InventoryTab Inventory { get; set; } 
        public ShopTab Shop { get; set; }
        public MarketplaceTab Marketplace { get; set; }
        public HelpTab Help { get; set; }
        public ProfileTab Profile { get; set; }
        public AboutTab About { get; set; }
        public NotificationsTab Notifications { get; set; }
        public AvatarTab Avatar { get; set; }
    }
}
