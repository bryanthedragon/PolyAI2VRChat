using PolyBuzzToVRChat.Platform.Generics.AI.Task.Type.Base;

namespace PolyBuzzToVRChat.Platform.Generics.AI.Task
{
    public interface IAITask
    {
        public TaskBaseType getTaskType();

        public TaskBaseType getTaskGroupType();

        public TaskBaseType GetTaskActionType();

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
        
        public void ExecuteTask();

        public void TaskKill();

        public void FinishTask();
    }
}