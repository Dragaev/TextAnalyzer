namespace TextAnalyzerWPF
{
    abstract class Expression
    {
        int lenghtOfPreposition = 3;
        public void Interpret(Context context)
        {
            if (context.Input.Length == 0)
                return;

            if (context.Input.EndsWith(firstEndOfVerb()) || context.Input.EndsWith(secondEndOfVerb()) || context.Input.EndsWith(thirdEndOfVerb()))
                context.Output += "глагол";
            
            else if (context.Input.EndsWith(firstEndOfAdjective()) || context.Input.EndsWith(secondEndOfAdjective()) || context.Input.EndsWith(thirdEndOfAdjective()))
                context.Output += "прилагательное";
            
            else if (context.Input.Length < lenghtOfPreposition)
                context.Output += "предлог";            

            else context.Output += "другое";
        }
        public abstract string firstEndOfAdjective();
        public abstract string secondEndOfAdjective();
        public abstract string thirdEndOfAdjective();
        public abstract string firstEndOfVerb();
        public abstract string secondEndOfVerb();
        public abstract string thirdEndOfVerb();
    }
}
