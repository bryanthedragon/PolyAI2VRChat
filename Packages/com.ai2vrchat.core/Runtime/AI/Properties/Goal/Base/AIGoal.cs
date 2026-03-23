using AIToVRChat.Platform.Generics.AI.Goal;

namespace AIToVRChat.AI.Goal.Base
{
    public abstract class AIGoal<TAIGoal> where TAIGoal : IAIGoal
    {
        public void Achieve()
        {
            // Implementation of AI goal achievement logic 
        }
    }
}