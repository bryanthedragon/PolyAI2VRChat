using PolyBuzzToVRChat.Platform.Generics.AI;

namespace PolyBuzzToVRChat.AI.Base
{
    public abstract class AI<TAI> where TAI : IAI
    {
        public void Execute()
        {
            // Implementation of AI execution logic 
        }
    }
}