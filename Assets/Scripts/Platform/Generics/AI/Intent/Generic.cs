namespace PolyBuzzToVRChat.Platform.Generics.AI.Intent
{
    public interface IAIIntent
    {
        public bool isExecuting { get; set; }
        public bool isExecuted { get; set; }
        public bool isFailed { get; set; }
        public bool isFinished { get; set; }
        public bool isInProgress { get; set; }
        public bool isViolated { get; set; }
        public bool isComforting { get; set; }
        public bool isComforted { get; set; }

        public void GetEmotion();
        public void Comfort();
        public void Comforted();
        public void Violate();
        public void Execute();
        public void Finish();
        public void Fail();
        public void Progress();

    }
}