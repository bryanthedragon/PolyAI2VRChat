using UnityEngine;

namespace PolyBuzzToVRChat.Platform.Generics.UI.OTBS.AI
{
    public class AIOTBSs : IOTBS
    {
        public GameObject AITab;

        public void ClosePanel()
        {
            AITab.SetActive(false);
        }

        public void OpenPanel()
        {
            AITab.SetActive(true);
        }

        public class PolyBuzzOTBS : AIOTBSs
        {
            public GameObject PolyBuzzTab;

            public new void OpenPanel()
            {
                PolyBuzzTab.SetActive(true);
            }

            public new void ClosePanel()
            {
                PolyBuzzTab.SetActive(false);
            }

            public class PersonaOTBS : PolyBuzzOTBS
            {
                public GameObject PersonaTab;

                public new void OpenPanel()
                {
                    PersonaTab.SetActive(true);
                }

                public new void ClosePanel()
                {
                    PersonaTab.SetActive(false);
                }
            }
            public class AccountOTBS : PolyBuzzOTBS
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
        }
    }
}