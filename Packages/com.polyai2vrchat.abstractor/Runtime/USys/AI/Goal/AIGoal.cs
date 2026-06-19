using PolyBuzzToVRChat.Platform.Generics.AI.Goal;

namespace PolyBuzzToVRChat.AI.Goal
{
    public abstract class AbstractAIGoal<TAbstractAIGoal> where TAbstractAIGoal : IAIGoal
    {
        public bool Achived {get; }
        public string Goal {get; set; }
        public void Achieve()
        {
            
        }  
        
    }
}