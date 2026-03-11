using UnityEngine;

namespace PolyBuzzToVRChat.Platform.Generics.UI.OTBS.Steam
{

    public class SteamOTBSs : IOTBS
    {
        public GameObject SteamTab;

        public void ClosePanel()
        {
            
        }

        public void OpenPanel()
        {
            
        }

        public class AccountOTBS : IOTBS
        {
            public GameObject AccountTab;
            public void OpenPanel() {
                AccountTab.SetActive(true);
            }

            public void ClosePanel() {
                AccountTab.SetActive(false);
            }
        }
    }
}