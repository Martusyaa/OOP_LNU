namespace State
{
    public class Document
    {
        public State CurrentState { get; set; }

        public Document()
        {
            CurrentState = new DraftState(this);
        }

        public string requestNext()
        {
            return CurrentState.onNext();
        }

        public string requestPrevious()
        {
            return CurrentState.onPrevious();
        }

        public string Draft()
        {
            return "Document published by user";
        }

        public string Moderation()
        {
            return "Document approved by admin";
        }

        public string Published()
        {
            return "Current state - published";
        }

        public string DraftIdle()
        {
            return "Document still is in a draft state";
        }

        public string FailedModeration()
        {
            return "Review failed";
        }

        public string PublicationExpired()
        {
            return "Document expired";
        }
    }
}
