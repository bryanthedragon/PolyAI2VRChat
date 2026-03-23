using System;
using AIToVRChat.Platform.Generics.AI.Task.Type.Action;
using AIToVRChat.Platform.Generics.AI.Task.Type.Group;

namespace AIToVRChat.Platform.Generics.AI.Task.Type.Base
{
    public class TaskBaseType
    {
        public TaskActionType GetTaskActionType()
        { 
            return TaskActionType.None; 
        }
        public TaskGroupType GetTaskGroupType()
        { 
            return TaskGroupType.None; 
        }

        public static explicit operator TaskBaseType(TaskGroupType v)
        {
            return (TaskBaseType) v;
        }

        public static explicit operator TaskBaseType(TaskActionType v)
        {
            return (TaskBaseType) v;
        }
    }
}