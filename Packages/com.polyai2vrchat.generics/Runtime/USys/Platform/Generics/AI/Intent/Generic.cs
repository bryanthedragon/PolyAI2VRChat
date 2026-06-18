namespace PolyBuzzToVRChat.Platform.Generics.AI.Intent
{
    public interface IAIIntent
    {
        abstract bool isExecuted { get; set; }
        abstract bool isFinished { get; set; }
        bool isFailed { get; set; }
        bool isInProgress { get; set; }
        bool isViolated { get; set; }
        bool isEmotional { get; set; }

        public void Think();
        public void GetEmotion();
        public void Violate();
        public void Execute();
        public void Finish();
        public void Fail();
        public void Progress();
    }
}