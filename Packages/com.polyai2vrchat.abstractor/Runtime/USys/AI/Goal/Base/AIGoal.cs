using PolyBuzzToVRChat.Platform.Generics.AI.Goal;

namespace PolyBuzzToVRChat.AI.Goal.Base
{
    public abstract class AIGoal<TAIGoal> where TAIGoal : IAIGoal
    {
        public void Achieve()
        {
            // Implementation of AI goal achievement logic 
        }
    }
}