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
using System.Windows.Shapes;
using MovementGame.Core;

namespace MovementGame.UI
{
    /// <summary>
    /// Interaction logic for SetKeyBindings.xaml
    /// </summary>
    public partial class SetKeyBindings : Window
    {
        public SetKeyBindings()
        {
            InitializeComponent();

            var bindings = KeyBindings.GetKeyBindings("TopDown");

            int y = 0;
            foreach (var binding in bindings)
            {
                Grid_Main.Children.Add(new Label()
                {
                    Margin = new Thickness(0, y, 0, 0),
                    VerticalAlignment = VerticalAlignment.Top,
                    Content = binding.Key
                });
                y += 40;
            }
        }
    }
}
