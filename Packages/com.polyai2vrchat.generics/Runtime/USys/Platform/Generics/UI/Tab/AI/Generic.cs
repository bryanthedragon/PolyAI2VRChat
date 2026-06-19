namespace PolyBuzzToVRChat.Platform.Generics.UI.Tab.AI
{
    public class PolyBuzzTabs : ITabs
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

        public class PersonaTab : PolyBuzzTabs
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

        public class AccountTab : PolyBuzzTabs
        {
            /// <summary>
            /// Closes the Account Tab.
            /// </summary>
            public new void Close()
            {
                isActive = false;
                // Close the Account Tab
            }

            /// <summary>
            /// Opens the Account Tab.
            /// </summary>
            public new void Open()
            {
                isActive = true;
                // Open the Account Tab
            }
        }
    }
}
