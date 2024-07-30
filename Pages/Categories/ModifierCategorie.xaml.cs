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
using WPFModernVerticalMenu.Model;

namespace WPFModernVerticalMenu.Pages.Categories
{
    /// <summary>
    /// Logique d'interaction pour ModifierCategorie.xaml
    /// </summary>
    public partial class ModifierCategorie : Window
    {
        bdVenteEntities bdVenteEntities = new bdVenteEntities();
        int Id;
        public ModifierCategorie(int id)
        {
            Id = id;
            InitializeComponent();
            Model.Categorie categorie = bdVenteEntities.Categorie.Find(Id);
            CodeCategorie.Text = categorie.CodeCategorie;
            libelleCategorie.Text = categorie.LibelleCategorie;
        }

        private void btnModifier(object sender, RoutedEventArgs e)
        {

            Model.Categorie categorie = bdVenteEntities.Categorie.Find(Id);
            
            if (categorie != null)
            {
                categorie.CodeCategorie = CodeCategorie.Text;
                categorie.LibelleCategorie = libelleCategorie.Text;
                bdVenteEntities.SaveChanges();
                Categorie.dataGrid.ItemsSource = bdVenteEntities.Categorie.ToList();
                this.Hide();
            }
        }
    }
}
