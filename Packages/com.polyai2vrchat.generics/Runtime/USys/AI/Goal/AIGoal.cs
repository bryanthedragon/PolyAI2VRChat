using PolyBuzzToVRChat.Platform.Generics.AI.Goal;

namespace PolyBuzzToVRChat.AI.Goal
{
    public interface IAIGoal
    {
        public bool Achived {get; }
        public string Goal {get; set; }
        public void Achieve();    
        
    }
}