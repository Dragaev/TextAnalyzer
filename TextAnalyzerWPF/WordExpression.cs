namespace TextAnalyzerWPF
{
    class WordExpression:Expression
    {
        public override string firstEndOfAdjective() { return "ой"; }
        public override string secondEndOfAdjective() { return "ый"; }
        public override string thirdEndOfAdjective() { return "ие"; }
        public override string firstEndOfVerb() { return "тся"; }
        public override string secondEndOfVerb() { return "лся"; }
        public override string thirdEndOfVerb() { return "ть"; }        
    }
}
