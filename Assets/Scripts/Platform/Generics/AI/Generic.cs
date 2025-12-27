using PolyBuzzToVRChat.Platform.Generics.AI.Emotion;
using PolyBuzzToVRChat.Platform.Generics.AI.Goal;
using PolyBuzzToVRChat.Platform.Generics.AI.Intent;
using PolyBuzzToVRChat.Platform.Generics.AI.Task;

namespace PolyBuzzToVRChat.Platform.Generics.AI
{
    public interface IAI
    {
        public IAIIntent Intent { get; set; }
        public IAIGoal Goal { get; set; }
        public IAIEmotion Emotion { get; set; }
        public IAITask Task { get; set; }
        
        public void Start()
        {
            Task.IsEnabled = true;
            Task.IsRunning = true;
            Task.IsPaused = false;
            Task.IsFinished = false;
            Task.IsKilled = false;
        }

        public void Reset()
        {
            Task.IsEnabled = false;
            Task.IsRunning = false;
            Task.IsPaused = false;
            Task.IsFinished = false;
            Task.IsKilled = false;
        }
        public void Pause()
        {
            if (Task.IsRunning)
            {
                Task.IsPaused = true;
                Task.IsRunning = false;
                Task.IsKilled = false;
            }
        }
        public void Resume()
        {
            if (Task.IsPaused)
            {
                Task.IsPaused = false;
                Task.IsRunning = true;
                Task.IsKilled = false;
            }
        }
    }

    public sealed class AIProperties : IAI
    {
        public IAIIntent Intent { get; set; }
        public IAIGoal Goal { get; set; }
        public IAIEmotion Emotion { get; set; }
        public IAITask Task { get; set; }

        public AIProperties(IAIIntent intent, IAIGoal goal, IAIEmotion emotion)
        {
            Intent = intent;
            Goal = goal;
            Emotion = emotion;
        }
    }
}