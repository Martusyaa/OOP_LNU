namespace State
{
    public class DraftState : State
    {
        public DraftState(Document document)
            : base(document) { }

        public override string onNext()
        {
            this.Document.CurrentState = new ModerationState(this.Document);
            return this.Document.Draft();
        }

        public override string onPrevious()
        {
            return this.Document.DraftIdle();
        }
    }
}
