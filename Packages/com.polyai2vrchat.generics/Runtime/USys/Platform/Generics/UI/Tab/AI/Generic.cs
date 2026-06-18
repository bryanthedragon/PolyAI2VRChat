namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI
{
    public class AITabs : ITabs
    {
        public bool isActive { get; set; }
        public bool isVisible { get; set; }
        public bool isHovered { get; set; }
        public bool isFocused { get; set; }

        public void Close()
        {
            isActive = false;
        }

        public void Open()
        {
            isActive = true;
        }

        public class PolyBuzzTab : AITabs
        {
            public new void Close()
            {
                isActive = false;
            }

            public new void Open()
            {
                isActive = true;
            }
            public class PersonaTab : PolyBuzzTab
            {
                public new void Close()
                {
                    isActive = false;
                }

                public new void Open()
                {
                    isActive = true;
                }
            }
        }
    }
}