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

namespace game
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Player1Name.Content = character.Name;
            Player1HP.Content = character.HP;
            EnemyName.Content = character2.Name;
            EnemyHP.Content = character2.HP;
            Player1Special.Content = character.SpecialBar.ToString() + "/100";


        }

        ACharacter character = new Warrior()
        {
            Name = "Dejvík",
            HP = 100,
            SpecialBar = 0

        };

        ACharacter character2 = new Warrior()
        {
            Name = "Target Dummy",
            HP = 500,
            SpecialBar = 0

        };


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            character.UseAbility1(character2);
            EnemyHP.Content = character2.HP;
            Player1Special.Content = character.SpecialBar.ToString() + "/100";
        }
    }
}
