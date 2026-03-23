using AIToVRChat.Platform.Generics.UI.OTBS.AI;
using AIToVRChat.Platform.Generics.UI.OTBS.Steam;
using AIToVRChat.Platform.Generics.UI.OTBS.VRChat;
using AIToVRChat.UI.OTBS.Main;

namespace AIToVRChat.Platform.Generics.UI.OTBS
{

    public interface IOTBS
    {
        void OpenPanel();
        void ClosePanel();   
    }

    public sealed class VRChatOTBS : VRChatOTBSs
    {

        public new void OpenPanel()
        {
            VRChatTab.SetActive(true);
        }

        public new void ClosePanel()
        {
            VRChatTab.SetActive(false);
        }
    }
    
    public sealed class AIOTBS : AIOTBSs
    {

        public new void OpenPanel()
        {
            AITab.SetActive(true);
        }

        public new void ClosePanel()
        {
            AITab.SetActive(false);
        }
    }
    
    public sealed class SteamOTBS : SteamOTBSs
    {

        public new void OpenPanel()
        {
            SteamTab.SetActive(true);
        }

        public new void ClosePanel()
        {
            SteamTab.SetActive(false);
        }
    }    
    
    public sealed class MainOTBS : MainOBTSs
    {
        public new void OpenPanel()
        {
            MainTab.SetActive(true);
        }

        public new void ClosePanel()
        {
            MainTab.SetActive(false);
        }
    }
}