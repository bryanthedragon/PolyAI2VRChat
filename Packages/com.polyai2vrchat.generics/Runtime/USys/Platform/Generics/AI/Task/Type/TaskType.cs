using PolyBuzzToVRChat.Platform.Generics.AI.Task.Type.Action;
using PolyBuzzToVRChat.Platform.Generics.AI.Task.Type.Group;

namespace PolyBuzzToVRChat.Platform.Generics.AI.Task.Type
{
    public interface IAITaskType
    {
        public virtual TaskBaseType BaseType => TaskBaseType.None;
        public virtual TaskGroupType GroupType => TaskGroupType.None;
        public virtual TaskActionType ActionType => TaskActionType.None;
    }

    public class IntentTask : IAITaskType
    {
        public TaskGroupType GroupType => TaskGroupType.None;
        public TaskActionType ActionType => TaskActionType.None;
        public TaskBaseType BaseType => TaskBaseType.Intent;
    }
    public class PersonalityTask : IAITaskType
    {
        public TaskGroupType GroupType => TaskGroupType.None;
        public TaskActionType ActionType => TaskActionType.None;
        public TaskBaseType BaseType => TaskBaseType.Personality;
    }
    public class GoalTask : IAITaskType
    {
        public TaskGroupType GroupType => TaskGroupType.None;
        public TaskActionType ActionType => TaskActionType.None;
        public TaskBaseType BaseType => TaskBaseType.Goal;
    }
    public class EmotionTask : IAITaskType
    {
        public TaskGroupType GroupType => TaskGroupType.None;
        public TaskActionType ActionType => TaskActionType.None;
        public TaskBaseType BaseType => TaskBaseType.Emotion;
    }
    public class GroupTask : IAITaskType
    {
        public TaskGroupType GroupType => TaskGroupType.Group;
        public TaskActionType ActionType => TaskActionType.None;
        public TaskBaseType BaseType => TaskBaseType.None;
    }
    public class ActionTask : IAITaskType
    {
        public TaskGroupType GroupType => TaskGroupType.None;
        public TaskActionType ActionType => TaskActionType.Action;
        public TaskBaseType BaseType => TaskBaseType.None;
    }
}