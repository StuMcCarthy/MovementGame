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
using MovementGame.Core;

namespace MovementGame.UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        PlayerCharacterActor actor = new PlayerCharacterActor();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private async Task PlayGame(PlayerCharacterActor actor)
        {
            actor.SpawnActor();
            while (true)
            {
                Canvas.SetLeft(shape, actor.Location.X);
                Canvas.SetBottom(shape, actor.Location.Y);
                await Task.Delay(5);
            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await PlayGame(actor);
        }
    }
}
