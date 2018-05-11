using System;
using System.Collections.Generic;

namespace TextAnalyzerWPF
{
   public class Model
    {
        public static Dictionary<string,WordCharacters> CreateDictionary(string[] inputWordsArray)
        {
            Context context = new Context(null);
            Dictionary<string, WordCharacters> WordsDictionary = new Dictionary<string, WordCharacters>();
            String[] wordsArray = inputWordsArray;  

            //Строим 'parse tree'            
            List<Expression> tree = new List<Expression>
            {
                new TypeOfExpression()
            };

            //Интерпретатор
            foreach (Expression exp in tree)
            {
                foreach (var word in wordsArray)
                {
                    context = new Context(word);
                    exp.Interpret(context);
                    if (WordsDictionary.ContainsKey(word)) WordsDictionary[word].QuantityInText++;//если слово уже есть в словаря, то увеличиваем количество его появлений в тексте
                    else WordsDictionary.Add(word, new WordCharacters { TypeOfWord = context.Output, QuantityInText = 1 });//если слова в словаре еще нет, то добавляем
                }
            }
            return WordsDictionary;            
        }
       
        public class WordCharacters
        {
            public string TypeOfWord;
            public int QuantityInText;
        }
    }    
}
