using PolyBuzzToVRChat.Platform.Generics.AI.Goal;
using PolyBuzzToVRChat.Platform.Generics.AI.Intent;

namespace PolyBuzzToVRChat.Platform.Generics.AI
{
    public interface IAI
    {
        public IAIIntent Intent { get; set; }
        public IAIGoal Goal { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsRunning { get; set; }
        public bool IsPaused { get; set; }
        public bool IsFinished { get; set; }
        public bool IsKilled { get; set; }
        public bool IsThinking { get; set; }
        public bool IsProcessing { get; set; }
        public bool IsDeciding { get; set; }
        public bool IsExecuting { get; set; }
        public bool IsDecided { get; set; }
        public bool IsExecuted { get; set; }
        public void Start()
        {
            IsEnabled = true;
            IsRunning = true;
            IsPaused = false;
            IsFinished = false;
            IsKilled = false;
        }

        public void Reset()
        {
            IsEnabled = false;
            IsRunning = false;
            IsPaused = false;
            IsFinished = false;
            IsKilled = false;
        }
        public void Pause()
        {
            if (IsRunning)
            {
                IsPaused = true;
                IsRunning = false;
                IsKilled = false;
            }
        }
        public void Resume()
        {
            if (IsPaused)
            {
                IsPaused = false;
                IsRunning = true;
                IsKilled = false;
            }
        }

        public void Finish()
        {
            IsRunning = false;
            IsPaused = false;
            IsFinished = true;
            IsKilled = false;
        }

        public void Think()
        {
            // AI thinking logic goes here
        }

        public void FinishTask()
        {
            IsRunning = false;
            IsPaused = false;
            IsFinished = true;
            IsKilled = false;
            if(IsProcessing != false)
            {
                IsProcessing = true;
            }
            if(IsThinking != false)
            {
                IsThinking = true;
            }
            if(Intent != null)
            {
                Intent.Execute();
            }
            if(Goal != null)
            {
                Goal.Achieve();
            }
            if(IsDeciding != false)
            {
                IsDeciding = true;
            }
            if(IsExecuting != false)
            {
                IsExecuting = true;
            }
            if(IsDecided != false)
            {
                IsDecided = true;
            }
            if(IsExecuted != false)
            {
                IsExecuted = true;
            }
            if(IsProcessing != false)
            {
                IsProcessing = false;
            }
        }
    }

    public sealed class AIProperties : IAI
    {
        public IAIIntent Intent { get; set; }
        public IAIGoal Goal { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsRunning { get; set; }
        public bool IsPaused { get; set; }
        public bool IsFinished { get; set; }
        public bool IsKilled { get; set; }
        public bool IsThinking { get; set; }
        public bool IsProcessing { get; set; }
        public bool IsDeciding { get; set; }
        public bool IsExecuting { get; set; }
        public bool IsDecided { get; set; }
        public bool IsExecuted { get; set; }
        
        public AIProperties(IAIIntent intent, IAIGoal goal)
        {
            Intent = intent;
            Goal = goal;
        }
    }
}