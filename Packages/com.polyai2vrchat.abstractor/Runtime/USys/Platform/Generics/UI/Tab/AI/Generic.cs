namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI
{
    public class AITabs : ITabs
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

        public class PolyBuzzTab : AITabs
        {
            public new void Close()
            {
                isActive()= false;   
            }

            public new void Open()
            {
                isActive() = true;
            }
            public class PersonaTab : PolyBuzzTab
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
}