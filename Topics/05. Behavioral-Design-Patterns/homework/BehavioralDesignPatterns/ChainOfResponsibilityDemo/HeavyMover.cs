namespace ChainOfResponsibilityDemo
{
    public abstract class HeavyMover
    {
        protected HeavyMover Successor { get; set; }

        public void SetSuccessor(HeavyMover successor)
        {
            this.Successor = successor;
        }

        public abstract void MoveStone(Stone purchase);
    }
}
