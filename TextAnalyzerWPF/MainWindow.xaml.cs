using System.Linq;
using System.Windows;


namespace TextAnalyzerWPF
{
    public partial class MainWindow : Window
    {        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AnalyzeBtn_Click(object sender, RoutedEventArgs e)
        {
            string[] inputText = InputTextTB.Text.Split(new char[] { ' ' });
            LinesGrid.Items.Clear();//чищу содержимое DataGrid
            foreach (var value in Model.CreateDictionary(inputText).OrderBy(value=>value.Key))//вывожу элементы словаря, сортирую ключи по алфавиту
                LinesGrid.Items.Add(new Item() { Word = value.Key, Type = value.Value.TypeOfWord, Quantity = value.Value.QuantityInText });
        }
    }
}
