using System.Windows;
using TreeNotes.Core;
using System.Collections.Generic;

namespace TreeNotes
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            _treePresenter.Items.Add(new Branch("Wallop")
            {
                Childs = new List<TreeElement>()
                {
                    new Leaf<string>("Spike")
                    {
                        Content = "SpikerMazafucker"
                    }
                }
            });
        }

        private void CreateNewElement(object sender, RoutedEventArgs e)
        {

        }
    }
}
