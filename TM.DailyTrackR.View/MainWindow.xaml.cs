namespace TM.DailyTrackR.View
{
    using System.Linq.Expressions;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Data;

    public partial class MainWindow : Window
  {

        private List<string> ListOfNumbers;
        public MainWindow()
        {
            InitializeComponent();
            //List<string> list = new List<string>
            //{
            //    "Ana are mere",
            //    "I need Jesus",
            //    "5 lei chilu la kartofi",
            //    "Bogdan Marcel!!!!"
            //};
            //List<Test> listOfTests = new List<Test>
            //{
            //    new Test("text1", true, list,"https://www.c-sharpcorner.com/UploadFile/mahesh/wpf-combobox/"),
            //    new Test("text2", false, list,"https://www.c-sharpcorner.com/UploadFile/mahesh/wpf-combobox/"),
            //    new Test("text3", true, list,"https://www.c-sharpcorner.com/UploadFile/mahesh/wpf-combobox/"),
            //    new Test("text4", false, list,"https://www.c-sharpcorner.com/UploadFile/mahesh/wpf-combobox/"),
            //};
        }

        //private void ApasaEvent(object sender, RoutedEventArgs e)
        //{
        //    BindingExpression bindingExpression = Textbox1.GetBindingExpression(TextBox.TextProperty);
        //    bindingExpression.UpdateSource();
        //}

        //private void  AddItemInDataGrid(List<Test> listOfTests)
        //{
        //    CEVA.ItemsSource = listOfTests;
        //}
    }
}
