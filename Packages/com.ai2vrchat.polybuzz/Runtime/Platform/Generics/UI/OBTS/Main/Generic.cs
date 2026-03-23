using PolyBuzzToVRChat.Platform.Generics.UI.OTBS;
using UnityEngine;

namespace PolyBuzzToVRChat.UI.OTBS.Main
{
    public class MainOTBSs : IOTBS
    {
        public GameObject MainTab;

        public void ClosePanel()
        {
            MainTab.SetActive(false);
        }

        public void OpenPanel()
        {
            MainTab.SetActive(true);
        }

        public class SettingsOTBS : MainOTBSs
        {
            public GameObject SettingsTab;
            public new void ClosePanel()
            {
                SettingsTab.SetActive(false);
            }

            public new void OpenPanel()
            {
                SettingsTab.SetActive(true);
            }
        }

        public class ConfigOTBS : MainOTBSs
        {
            public GameObject ConfigTab;
            public new void ClosePanel()
            {
                ConfigTab.SetActive(false);
            }

            public new void OpenPanel()
            {
                ConfigTab.SetActive(true);
            }   
        }
        
        public class AccountOTBS : MainOTBSs
        {
            public GameObject AccountTab;
            public new void ClosePanel()
            {
                AccountTab.SetActive(false);
            }           

            public new void OpenPanel()
            {
                AccountTab.SetActive(true);
            }
        }
    }
}