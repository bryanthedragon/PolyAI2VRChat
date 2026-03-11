using PolyBuzzToVRChat.Platform.Generics.AI.Intent;

namespace PolyBuzzToVRChat.AI.Intent.Base
{
    public abstract class AIIntent<TAIIntent> where TAIIntent : IAIIntent
    {
        public void Execute()
        {
            // Implementation of AI intent execution logic 
        }
    }
}