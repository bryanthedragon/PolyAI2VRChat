using AIToVRChat.Platform.Generics.Player.Intent.Base;

namespace AIToVRChat.Platform.Generics.Player.Base
{
    public interface IPlayer
    {
        
    }
    public sealed class PlayerProperties : IPlayer
    {
        public IPlayerIntent Intent { get; set; }
    }
}