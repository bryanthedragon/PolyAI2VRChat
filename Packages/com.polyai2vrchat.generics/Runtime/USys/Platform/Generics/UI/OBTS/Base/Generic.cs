using PolyBuzzToVRChat.Platform.Generics.UI.OTBS.VRChat;
using PolyBuzzToVRChat.Platform.Generics.UI.OTBS.AI;
using PolyBuzzToVRChat.Platform.Generics.UI.OTBS.Steam;
using static PolyBuzzToVRChat.Platform.Generics.UI.OTBS.VRChat.VRChatOTBSs;

namespace PolyBuzzToVRChat.Platform.Generics.UI.OTBS.Base
{
    public interface OTBS
    {
        public sealed class AIOTBS : AIOTBSs
        {
            public AIOTBS PolyBuzz { get; set; }
        }

        public class SteamOTBS : SteamOTBSs
        {
            public SteamOTBS Account { get; set; }
        }

        public class VRChatOTBS : VRChatOTBSs
        {
            public AccountOTBS Account { get; set; }
            public FriendsOTBS Friends { get; set; }
            public ChatOTBS Chat { get; set; }
            public SettingsOTBS Settings { get; set; }
            public WorldOTBS World { get; set; }
            public InventoryOTBS Inventory { get; set; } 
            public ShopOTBS Shop { get; set; }
            public MarketplaceOTBS Marketplace { get; set; }
            public HelpOTBS Help { get; set; }
            public ProfileOTBS Profile { get; set; }
            public AboutOTBS About { get; set; }
            public NotificationsOTBS Notifications { get; set; }
            public AvatarOTBS Avatar { get; set; }
        }
    }
}
