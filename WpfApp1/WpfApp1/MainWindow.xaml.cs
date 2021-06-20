using System;
using System.Collections.Generic;
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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0&& richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <=0)
                    richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Left;
            }
           // richTextBox.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Left);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                    richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Center;
            }
            //richTextBox.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Center);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                    richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Right;
            }
           // richTextBox.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Right);
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                    richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Justify;
            }
            //richTextBox.Selection.ApplyPropertyValue(Paragraph.TextAlignmentProperty, TextAlignment.Justify);
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                {
                    if (richTextBox.Selection.GetPropertyValue(TextElement.FontWeightProperty).ToString() == "Bold")
                        richTextBox.Document.Blocks.ElementAt(i).FontWeight =FontWeights.Normal;
                    else
                richTextBox.Document.Blocks.ElementAt(i).FontWeight = FontWeights.Bold;
                    //richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Justify;
                }
            }
            //if (richTextBox.Selection.GetPropertyValue(TextElement.FontWeightProperty).ToString() == "Bold")
            //    richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Normal);
            //else
            //    richTextBox.Selection.ApplyPropertyValue(TextElement.FontWeightProperty, FontWeights.Bold);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                {
                    if (richTextBox.Selection.GetPropertyValue(TextElement.FontWeightProperty).ToString() == "Italic")
                        richTextBox.Document.Blocks.ElementAt(i).FontStyle = FontStyles.Normal;
                    else
                        richTextBox.Document.Blocks.ElementAt(i).FontStyle = FontStyles.Italic;
            //richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Justify;
        }
            }

            //if (richTextBox.Selection.GetPropertyValue(TextElement.FontStyleProperty).ToString() == "Italic")
            //    richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Normal);
            //else
            //    richTextBox.Selection.ApplyPropertyValue(TextElement.FontStyleProperty, FontStyles.Italic);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {

            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                {
                    TextRange selectionRange = new TextRange(richTextBox.Document.Blocks.ElementAt(i).ContentStart, richTextBox.Document.Blocks.ElementAt(i).ContentEnd);
                    if (selectionRange.GetPropertyValue(Inline.TextDecorationsProperty) == TextDecorations.Underline)
                        selectionRange.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
                       // richTextBox.Document.Blocks.ElementAt(i).Con
                    else
                        selectionRange.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
                    //richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Justify;
                }
            }


           // TextRange selectionRange = new TextRange(richTextBox.Selection.Start, richTextBox.Selection.End);

            //if (selectionRange.GetPropertyValue(Inline.TextDecorationsProperty) == TextDecorations.Underline)
            //{
            //    richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, null);
            //}
           
                
            //else
               
            //    richTextBox.Selection.ApplyPropertyValue(Inline.TextDecorationsProperty, TextDecorations.Underline);
            //richTextBox.Selection.Text = richTextBox.Selection.GetPropertyValue(Inline.TextDecorationsProperty).ToString();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                {
                    TextRange selectionRange = new TextRange(richTextBox.Document.Blocks.ElementAt(i).ContentStart, richTextBox.Document.Blocks.ElementAt(i).ContentEnd);
                   
                        selectionRange.ApplyPropertyValue(RichTextBox.FontSizeProperty, Double.Parse(((sender as ComboBox).SelectedItem as TextBlock).Text));
                    // richTextBox.Document.Blocks.ElementAt(i).Con
                    
                    //richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Justify;
                }
            }


           // TextRange selectionRange = new TextRange(richTextBox.Selection.Start, richTextBox.Selection.End);
           // richTextBox.Selection.ApplyPropertyValue(RichTextBox.FontSizeProperty, Double.Parse(((sender as ComboBox).SelectedItem as TextBlock).Text));
            // Int32.Parse(((sender as ComboBox).SelectedItem as TextBlock).Text));
        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            for (int i = 0; i < richTextBox.Document.Blocks.Count; i++)
            {
                if (richTextBox.Selection.Start.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentStart) >= 0 && richTextBox.Selection.End.CompareTo(richTextBox.Document.Blocks.ElementAt(i).ContentEnd) <= 0)
                {
                    TextRange selectionRange = new TextRange(richTextBox.Document.Blocks.ElementAt(i).ContentStart, richTextBox.Document.Blocks.ElementAt(i).ContentEnd);

                    selectionRange.ApplyPropertyValue(RichTextBox.FontFamilyProperty, (sender as ComboBox).SelectedItem);
                    // richTextBox.Document.Blocks.ElementAt(i).Con

                    //richTextBox.Document.Blocks.ElementAt(i).TextAlignment = TextAlignment.Justify;
                }
            }


           // richTextBox.Selection.ApplyPropertyValue(RichTextBox.FontFamilyProperty, (sender as ComboBox).SelectedItem );
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            // Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            // openFileDialog1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            // openFileDialog1.Multiselect = false;
            // openFileDialog1.FileName = "";
            // // Microsoft.Win32.DialogResult result = openFileDialog1.ShowDialog();
            // Nullable<bool> result =  openFileDialog1.ShowDialog();
            // //if (result == openFileDialog1.RE)
            // // {

            // Image img = new Image();
            // img.Source= new BitmapImage(new Uri(openFileDialog1.FileName));
            // img.Width = ActualWidth;
            //// Image.FromFile(openFileDialog1.FileName);
            //     Clipboard.SetImage(img.);
            //     richTextBox.Paste();
            //     richTextBox.Focus();
            //// }
            //// else
            //// {
            //     richTextBox.Focus();
            //}
            Microsoft.Win32.OpenFileDialog openFileDialog1 = new Microsoft.Win32.OpenFileDialog();
            openFileDialog1.Filter = "Images |*.bmp;*.jpg;*.png;*.gif;*.ico";
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "";
            // Microsoft.Win32.DialogResult result = openFileDialog1.ShowDialog();
            Nullable<bool> result = openFileDialog1.ShowDialog();
            


            var para = new Paragraph();
            BitmapImage bitmap = new BitmapImage(new Uri(openFileDialog1.FileName));
            Image image = new Image();
            image.Source = bitmap;
            image.Width = ActualWidth;
            para.Inlines.Add(image);

            //para.Inlines.Add(" text");
            flowdocument.Blocks.Add(para);

        }
    }
}
