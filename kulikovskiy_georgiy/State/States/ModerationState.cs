namespace State
{
    public class ModerationState : State
    {
        public ModerationState(Document document)
            : base(document) { }

        public override string onNext()
        {
            this.Document.CurrentState = new PublishedState(Document);
            return this.Document.Moderation();
        }

        public override string onPrevious()
        {
            this.Document.CurrentState = new DraftState(this.Document);
            return this.Document.FailedModeration();
        }
    }
}
