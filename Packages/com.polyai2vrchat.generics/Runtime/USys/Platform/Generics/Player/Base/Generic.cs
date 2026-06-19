using PolyBuzzToVRChat.Platform.Generics.Player.Intent;

namespace PolyBuzzToVRChat.Platform.Generics.Player
{
    public interface IPlayer
    {
        
    }
    public sealed class PlayerProperties : IPlayer
    {
        public IPlayerIntent Intent { get; set; }
    }
}