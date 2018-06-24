namespace Expression_tree
{
    public abstract class Expression : ICalculable, ISymbol
    {
        public abstract bool IsOperand { get; }

        public abstract bool IsFunction { get; }

        public abstract double Calculate();
    }
}
