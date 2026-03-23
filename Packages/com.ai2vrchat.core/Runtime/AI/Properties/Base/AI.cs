using AIToVRChat.Platform.Generics.AI;

namespace AIToVRChat.AI.Base
{
    public abstract class AI<TAI> where TAI : IAI
    {
        public void Execute()
        {
            // Implementation of AI execution logic 
        }
    }
}