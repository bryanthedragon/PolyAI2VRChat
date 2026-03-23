using PolyBuzzToVRChat.Platform.Generics.UI.OTBS.AI;
using PolyBuzzToVRChat.UI.OTBS.Main;

namespace PolyBuzzToVRChat.Platform.Generics.UI.OTBS
{

    public interface IOTBS
    {
        void OpenPanel();
        void ClosePanel();   
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
        
    public sealed class MainOTBS : MainOTBSs
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