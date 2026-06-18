using PolyBuzzToVRChat.Platform.Generics.AI.Emotion;
using PolyBuzzToVRChat.Platform.Generics.AI.Goal;
using PolyBuzzToVRChat.Platform.Generics.AI.Intent;
using PolyBuzzToVRChat.Platform.Generics.AI.Personality;
using PolyBuzzToVRChat.Platform.Generics.AI.Task;

namespace PolyBuzzToVRChat.Platform.Generics.AI
{
    public interface IAI
    {
        public abstract IAIIntent Intent { get; set; }

        public abstract IAIGoal Goal { get; set; }

        public abstract IAIEmotion Emotion { get; set; }

        public abstract IAITask Task { get; set; }

        public abstract IAIPersonality Personality { get; set; }
        
        /// <summary>
        /// Starts the task.
        /// </summary>
        public void Start()
        {
            Task.IsEnabled = true;
            Task.IsRunning = true;
            Task.IsPaused = false;
            Task.IsFinished = false;
            Task.IsKilled = false;
        }

        /// <summary>
        /// Resets the task to its initial state.
        /// </summary>
        public void Reset()
        {
            Task.IsEnabled = false;
            Task.IsRunning = false;
            Task.IsPaused = false;
            Task.IsFinished = false;
            Task.IsKilled = false;
        }
        
        /// <summary>
        /// Pauses the task if it is running.
        /// </summary>
        public void Pause()
        {
            if (Task.IsRunning)
            {
                Task.IsPaused = true;
                Task.IsRunning = false;
                Task.IsKilled = false;
            }
        }


        /// <summary>
        /// Resumes the task
        /// </summary>
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
}