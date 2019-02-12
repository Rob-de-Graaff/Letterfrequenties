using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Letterfrequenties
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool fileLoaded = false;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonImportFile_Click(object sender, RoutedEventArgs e)
        {
            textboxSearchResults.Clear();
            OpenFileDialog();
        }

        private void ButtonSearch_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(textboxSearchResults.Text))
            {
                string searchBar = textboxSearchBar.Text;
                string searchResults = textboxSearchResults.Text;
                char myChar = searchBar[0];

                textboxResult.Clear();
                textboxResult.AppendText("Results : ");
                if (checkboxCapitalLetter.IsChecked == true)
                {
                    //Solution 1 - remove the character, and compare its length.
                    int result1 = searchResults.Length - searchResults.Replace(searchBar, "").Length;
                    textboxResult.AppendText(result1.ToString());

                    //Solution 2 - split the string into an array using the character as a delimiter
                    int result2 = searchResults.Split(myChar).Length - 1;
                    textboxResult.AppendText(result2.ToString());

                    //Solution 3 - use the LINQ 'Count' extension method
                    int result3 = searchResults.ToCharArray().Count(c => c == myChar);
                    textboxResult.AppendText(result3.ToString());
                }
                else
                {
                    searchBar = searchBar.ToUpper();
                    searchResults = searchResults.ToUpper();
                    myChar = searchBar[0];

                    //Solution 4 - remove the character, and compare its length.
                    int result4 = searchResults.Length - searchResults.Replace(searchBar, "").Length;
                    textboxResult.AppendText(result4.ToString());

                    //Solution 5 - split the string into an array using the character as a delimiter
                    int result5 = searchResults.Split(myChar).Length - 1;
                    textboxResult.AppendText(result5.ToString());

                    //Solution 6 - use the LINQ 'Count' extension method
                    int result6 = searchResults.ToCharArray().Count(c => c == myChar);
                    textboxResult.AppendText(result6.ToString());
                }
            }
            else
            {
                MessageBox.Show("There is no text imported");
            }
        }

        private void OpenFileDialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog.Filter = "Text Files | *.txt";

            if (openFileDialog.ShowDialog() == true)
            {
                try
                {
                    using (StreamReader reader = File.OpenText(openFileDialog.FileName))
                    {
                        string importedtext = reader.ReadToEnd();
                        textboxSearchResults.AppendText(importedtext);
                    }
                }
                catch (IOException IOex)
                {
                    MessageBox.Show(IOex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                fileLoaded = true;
                labelSearchResults.Content = openFileDialog.SafeFileName;
            }

        }
    }
}
