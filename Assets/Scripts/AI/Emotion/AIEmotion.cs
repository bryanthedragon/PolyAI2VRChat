using PolyBuzzToVRChat.Platform.Generics.AI.Emotion;

namespace PolyBuzzToVRChat.AI.Emotions
{
    public class AIEmotion<TEmotion> where TEmotion : IAIEmotion
    {
        public bool isHappy { get; set; }
        public bool isSad { get; set; }
        public bool isAngry { get; set; }
        public bool isFearful { get; set; }
        public bool isDisgusted { get; set; }
        public bool isSurprised { get; set; }
        public bool isNeutral { get; set; }

        public void Express()
        {
            // Implementation of AI emotion expression logic
        }
    }
}