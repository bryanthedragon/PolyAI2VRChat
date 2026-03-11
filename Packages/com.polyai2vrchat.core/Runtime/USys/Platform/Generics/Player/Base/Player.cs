using PolyBuzzToVRChat.Platform.Generics.Player.Intent.Base;

namespace PolyBuzzToVRChat.Platform.Generics.Player.Base
{
    public interface IPlayer
    {
        
    }
    public sealed class PlayerProperties : IPlayer
    {
        public IPlayerIntent Intent { get; set; }
    }
}