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
using WPFModernVerticalMenu.Model;

namespace WPFModernVerticalMenu.Pages.Categories
{
    /// <summary>
    /// Logique d'interaction pour Categorie.xaml
    /// </summary>
    public partial class Categorie : Page
    {
        bdVenteEntities bdVenteEntities = new bdVenteEntities();
        public static DataGrid dataGrid;
        public Categorie()
        {
            InitializeComponent();
            Load();
        }
        public void Load()
        {
            dgCategorie.ItemsSource = bdVenteEntities.Categorie.ToList();
            dataGrid = dgCategorie;
        }
        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dgCategorie_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void btnAjouter(object sender, RoutedEventArgs e)
        {
            AjoutCategorie ajoutCategorie = new AjoutCategorie();
            ajoutCategorie.ShowDialog();
        }

        private void btnModifier(object sender, RoutedEventArgs e)
        {
            int id = (dataGrid.SelectedItem as WPFModernVerticalMenu.Model.Categorie).idCategorie;
            ModifierCategorie modifierCategorie = new ModifierCategorie(id);
            modifierCategorie.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, RoutedEventArgs e)
        {
            int Id = (dataGrid.SelectedItem as Model.Categorie).idCategorie;
            Model.Categorie categorie = bdVenteEntities.Categorie.Find(Id);
            bdVenteEntities.Categorie.Remove(categorie);
            bdVenteEntities.SaveChanges();
            dataGrid.ItemsSource = bdVenteEntities.Categorie.ToList();
        }
    }
}
