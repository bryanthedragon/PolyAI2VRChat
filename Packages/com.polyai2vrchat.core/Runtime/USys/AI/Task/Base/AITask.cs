using PolyBuzzToVRChat.Platform.Generics.AI.Emotion;
using PolyBuzzToVRChat.Platform.Generics.AI.Goal;
using PolyBuzzToVRChat.Platform.Generics.AI.Intent;
using PolyBuzzToVRChat.Platform.Generics.AI.Task;

namespace PolyBuzzToVRChat.AI.Task.Base
{
    public abstract class AITask<TTask> where TTask : IAITask
    {
        private IAIIntent Intent { get; set; }
        private IAIGoal Goal { get; set; }
        private IAIEmotion Emotion { get; set; }

        public string Task { get; set; }
        public bool TaskIsComplete { get; set; }
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

        /// <summary>
        /// Kills the task.
        /// </summary>
        public void TaskKill()
        {
            IsKilled = true;
            IsRunning = false;
            IsPaused = false;
            IsFinished = false;
        }

        /// <summary>
        /// FinishTask.
        ///
        /// Finishes the task.
        /// </summary>
        ///
        public void FinishTask()
        {
            IsRunning = false;
            IsPaused = false;
            IsFinished = false;
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
                IsProcessing = true;
            }
            if(TaskIsComplete != false)
            {
                IsFinished = true;
            }
        }
    }
}