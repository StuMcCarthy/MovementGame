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
        Key pressedKey;
        PlayerCharacterActor actor = new PlayerCharacterActor();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private async Task PlayGame(PlayerCharacterActor actor)
        {
            while (true)
            {
                switch (pressedKey)
                {
                    case Key.A:
                        actor.MoveActor(new System.Numerics.Vector3(-5, 0, 0));
                        break;
                    case Key.D:
                        actor.MoveActor(new System.Numerics.Vector3(5, 0, 0));
                        break;
                    case Key.W:
                        actor.MoveActor(new System.Numerics.Vector3(0, 5, 0));
                        break;
                    case Key.S:
                        actor.MoveActor(new System.Numerics.Vector3(0, -5, 0));
                        break;
                    default:
                        break;
                }
                pressedKey = Key.Enter;
                Canvas.SetLeft(shape, actor.Location.X);
                Canvas.SetBottom(shape, actor.Location.Y);
                await Task.Delay(5);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            pressedKey = e.Key;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await PlayGame(actor);
        }
    }
}
