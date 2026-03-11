using PolyBuzzToVRChat.Platform.Generics.Player.Base;
using PolyBuzzToVRChat.Platform.Generics.Player.Intent.Base;

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