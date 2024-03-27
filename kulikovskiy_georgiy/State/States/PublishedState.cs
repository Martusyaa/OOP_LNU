namespace State
{
    public class PublishedState : State
    {
        public PublishedState(Document document)
            : base(document) { }

        public override string onNext()
        {
            return Document.Published();
        }

        public override string onPrevious()
        {
            Document.CurrentState = new DraftState(Document);
            return Document.PublicationExpired();
        }
    }
}
