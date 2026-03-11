using PolyBuzzToVRChat.Platform.Generics.UI.OTBS;

namespace PolyBuzzToVRChat.UI.OTBS
{
    public abstract class OTBS<TOTBS> where TOTBS : IOTBS
    {
        public MainOTBS MainTab;
        public AIOTBS AITab;
        public SteamOTBS SteamTab;
        public VRChatOTBS VRChatTab;
        public PolyBuzzOTBS PolyBuzzTab;
    }
}