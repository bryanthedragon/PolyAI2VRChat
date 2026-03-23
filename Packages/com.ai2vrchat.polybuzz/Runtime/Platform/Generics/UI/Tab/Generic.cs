using PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI;

namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab
{
    public interface ITabs : IMenu
    {
        bool isActive { get; set; }
        bool isVisible { get; set; }
        bool isHovered { get; set; }
        bool isFocused { get; set; }      
    }
    public sealed class AITab : AITabs
    {
        public PolyBuzzTab PolyBuzz { get; set; }
    }
}
