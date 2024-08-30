using System.Collections;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Project3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Queue queue;
        
        public MainWindow()
        {
            InitializeComponent();
            queue = new Queue();


        }

        private void btntoken_Click(object sender, RoutedEventArgs e)
        {   
            queue.Enqueue(txtname.Text);
            StringBuilder sb = new StringBuilder();

            foreach (var item in queue)
            {
               sb.Append(queue);
            }

           

            for (int i = 1; i <= queue.Count; i++)
            {
                
                txtno.Text= i.ToString();
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string tkname = queue.Peek().ToString();
            //for (int i = 0; i <= queue.Count; i++)
            //{
            //    txttkname.Text = tkname;
            //}
           
           
            if (queue.Count > 1)
            {
            
                queue.Dequeue();
                txttkname.Text = queue.Peek().ToString(); 
            }
            else
            {
                MessageBox.Show("List Completed");
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            if (queue.Count > 1)
            { 
                string text = queue.Peek().ToString();
                txttkname.Text = text;
            }
            else
            {
                MessageBox.Show("No Patient");
            }
           
            
               
        }
    }
}