using AIToVRChat.Platform.Generics.AI.Intent;

namespace AIToVRChat.AI.Intent.Base
{
    public abstract class AIIntent<TAIIntent> where TAIIntent : IAIIntent
    {
        public void Execute()
        {
            // Implementation of AI intent execution logic 
        }
    }
}