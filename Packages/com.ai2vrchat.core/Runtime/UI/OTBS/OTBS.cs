using AIToVRChat.Platform.Generics.UI.OTBS;

namespace AIToVRChat.UI.OTBS
{
    public abstract class OTBS<TOTBS> where TOTBS : IOTBS
    {
        public MainOTBS MainTab;
        public AIOTBS AITab;
        public SteamOTBS SteamTab;
        public VRChatOTBS VRChatTab;
    }
}