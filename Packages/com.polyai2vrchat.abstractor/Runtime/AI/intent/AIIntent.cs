using PolyBuzzToVRChat.Platform.Generics.AI.Intent;

namespace PolyBuzzToVRChat.AI.Intent
{
    public abstract class AbstractAIIntent<TAIIntent> where TAIIntent : IAIIntent
    {
        public string Intent { get; set; }
    }    

}
