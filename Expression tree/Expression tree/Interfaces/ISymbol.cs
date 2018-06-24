namespace Expression_tree
{
    interface ISymbol
    {
        bool IsOperand { get; }
        bool IsFunction { get; }
    }
}
