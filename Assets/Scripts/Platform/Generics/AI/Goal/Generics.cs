namespace PolyBuzzToVRChat.Platform.Generics.AI.Goal
{
    public interface IAIGoal
    {
        public bool isAchieved { get; set; }
        public bool isFailed { get; set; }
        public bool isInProgress { get; set; }
        
        public void Achieve();
        public void Fail();
        public void Progress();
    }

    public class PolyBuzzAIGoal : IAIGoal
    {
        public bool isAchieved { get; set; }
        public bool isFailed { get; set; }
        public bool isInProgress { get; set; }

        public void Achieve()
        {
            // Goal achievement logic goes here
        }

        public void Fail()
        {
            // Fail Achievement logic goes here
        }

        public void Progress()
        {
            // Progress Achievement logic goes here
        }
    }

    public class VRChatAIGoal : IAIGoal
    {
        public bool isAchieved { get; set; }
        public bool isFailed { get; set; }
        public bool isInProgress { get; set; }

        public void Achieve()
        {
            // Goal achievement logic goes here
        }

        public void Fail()
        {
            // Fail Achievement logic goes here
        }

        public void Progress()
        {
            // Progress Achievement logic goes here
        }
    }

    public class PersonaAIGoal : IAIGoal
    {
        public bool isAchieved { get; set; }
        public bool isFailed { get; set; }
        public bool isInProgress { get; set; }

        public void Achieve()
        {
            // Goal achievement logic goes here
        }

        public void Fail()
        {
            // Fail Achievement logic goes here
        }

        public void Progress()
        {
            // Progress Achievement logic goes here
        }
    }
}