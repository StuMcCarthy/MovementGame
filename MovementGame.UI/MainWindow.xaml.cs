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
        readonly GameInstance Game = new GameInstance();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            Canvas_Level.Height = Game.Level.Size.Y;
            Canvas_Level.Width = Game.Level.Size.X;
        }

        private async Task PlayGame(PlayerCharacterActor actor)
        {
            Game.StartGame();
            while (true)
            {
                Canvas.SetLeft(Ellipse_Character, actor.Location.X);
                Canvas.SetBottom(Ellipse_Character, actor.Location.Y);
                await Task.Delay(10);
            }
        }

        private async void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            await PlayGame(Game.PlayerCharacter);
        }

        private void MenuItem_UserPreferences_Click(object sender, RoutedEventArgs e)
        {
            SetKeyBindings setKeyBindings = new SetKeyBindings();
            setKeyBindings.ShowDialog();
        }
    }
}
