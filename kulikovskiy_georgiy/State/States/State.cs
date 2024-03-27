namespace State
{
    public abstract class State
    {
        public Document Document { get; set; }

        public State(Document document)
        {
            Document = document;
        }

        public abstract string onNext();
        public abstract string onPrevious();
    }
}
