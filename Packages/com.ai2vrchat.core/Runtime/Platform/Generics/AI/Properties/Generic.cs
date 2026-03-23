using AIToVRChat.Platform.Generics.AI.Emotion;
using AIToVRChat.Platform.Generics.AI.Goal;
using AIToVRChat.Platform.Generics.AI.Intent;
using AIToVRChat.Platform.Generics.AI.Personality;
using AIToVRChat.Platform.Generics.AI.Task;

namespace AIToVRChat.Platform.Generics.AI
{
    public interface IAI
    {
        public IAIIntent Intent { get; set; }

        public IAIGoal Goal { get; set; }

        public IAIEmotion Emotion { get; set; }

        public IAITask Task { get; set; }

        public IAIPersonality Personality { get; set; }
        
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