using AIToVRChat.Platform.Generics.AI;

namespace AI2VRChat.AI.Platform
{
    public abstract class AIPlatform : IAIPlatform
    {
        public abstract string GetName();
    }
}