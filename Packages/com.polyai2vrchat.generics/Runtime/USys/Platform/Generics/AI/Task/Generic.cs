using PolyBuzzToVRChat.Platform.Generics.AI.Task.Type.Action;
using PolyBuzzToVRChat.Platform.Generics.AI.Task.Type.Group;
using PolyBuzzToVRChat.Platform.Generics.AI.Task.Type;

namespace PolyBuzzToVRChat.Platform.Generics.AI.Task
{
    public interface IAITask
    {
        public TaskBaseType getTaskType();

        public TaskGroupType getTaskGroupType();

        public TaskActionType GetTaskActionType();

        public abstract string Task { get; set; }
        
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
        
        public abstract void ExecuteTask();

        public abstract void TaskKill();

        public abstract void FinishTask();
    }
}