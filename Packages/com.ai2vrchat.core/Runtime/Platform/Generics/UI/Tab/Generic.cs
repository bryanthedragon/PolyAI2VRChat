using AIToVRChat.Platform.Generics.UI.Tab.AI;
using AIToVRChat.Platform.Generics.UI.Tab.Steam;
using AIToVRChat.Platform.Generics.UI.Tab.VRChat;

namespace AIToVRChat.Platform.Generics.UI.Tab
{
    public interface ITabs : IMenu
    {
        public bool isActive { get; set; }
        public bool isVisible { get; set; }
        public bool isHovered { get; set; }
        public bool isFocused { get; set; }   
    }

    public sealed class IAITab : AITabs
    {
        public PolyBuzzTab PolyBuzz { get; set; }
    }

    public class ISteamTab : SteamTabs
    {
        
    }

    public class IVRChatTab : VRChatTabs
    {
        
    }
}
