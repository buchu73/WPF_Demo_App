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

namespace WpfDemoApp
{
    /// <summary>
    /// Interaction logic for CustomCard.xaml
    /// </summary>
    public partial class CustomCard : UserControl
    {
        // Dependency Properties pour permettre le binding depuis XAML

        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(string), typeof(CustomCard),
                new PropertyMetadata("Titre par défaut"));

        public static readonly DependencyProperty DescriptionProperty =
            DependencyProperty.Register("Description", typeof(string), typeof(CustomCard),
                new PropertyMetadata("Description par défaut"));

        public static readonly DependencyProperty IconTextProperty =
            DependencyProperty.Register("IconText", typeof(string), typeof(CustomCard),
                new PropertyMetadata("★"));

        public static readonly DependencyProperty CardColorProperty =
            DependencyProperty.Register("CardColor", typeof(Brush), typeof(CustomCard),
                new PropertyMetadata(new SolidColorBrush(Color.FromRgb(33, 150, 243))));

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }

        public string Description
        {
            get { return (string)GetValue(DescriptionProperty); }
            set { SetValue(DescriptionProperty, value); }
        }

        public string IconText
        {
            get { return (string)GetValue(IconTextProperty); }
            set { SetValue(IconTextProperty, value); }
        }

        public Brush CardColor
        {
            get { return (Brush)GetValue(CardColorProperty); }
            set { SetValue(CardColorProperty, value); }
        }


        public CustomCard()
        {
            InitializeComponent();
        }

        private void ActionButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Action sur la carte : {Title}",
                          "UserControl personnalisé",
                          MessageBoxButton.OK,
                          MessageBoxImage.Information);
        }
    }
}
