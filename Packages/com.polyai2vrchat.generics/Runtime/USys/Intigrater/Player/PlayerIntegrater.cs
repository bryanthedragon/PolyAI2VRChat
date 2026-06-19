using PolyBuzzToVRChat.Platform.Generics.Player;
using PolyBuzzToVRChat.Platform.Generics.Player.Intent;

namespace PolyBuzzToVRChat.Player.Integrater
{
    public class PlayerIntegrater
    {
        public void Integrate()
        {
            // Integration logic goes here
        }
        public class Intent : IPlayerIntent
        {
            public void Execute()
            {
                // Intent execution logic goes here
            }
        }
        public class Properties : IPlayer
        {
            public IPlayerIntent Intent { get; set; }
        }
    }
}