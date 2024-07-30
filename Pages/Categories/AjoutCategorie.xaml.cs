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
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace WPFModernVerticalMenu.Pages.Categories
{
    /// <summary>
    /// Logique d'interaction pour AjoutCategorie.xaml
    /// </summary>
    public partial class AjoutCategorie : Window
    {
        bdVenteEntities bdVenteEntities = new bdVenteEntities();
        public AjoutCategorie()
        {
            InitializeComponent();
        }

        private void btn_AjouterCategorie(object sender, RoutedEventArgs e)
        {
            //Categorie ce-dessous c'est la Classe recuperer depuis la base de donnees 


            WPFModernVerticalMenu.Model.Categorie categorie = new WPFModernVerticalMenu.Model.Categorie()
            {
                CodeCategorie = CodeCategorie.Text,
                LibelleCategorie = libelleCategorie.Text,
            };
            bdVenteEntities.Categorie.Add(categorie);
            bdVenteEntities.SaveChanges();


            //Categorie ce-dessous c'est la page qui contient le datagridView 
            Categorie.dataGrid.ItemsSource = bdVenteEntities.Categorie.ToList();
            this.Hide();

        }
    }
}
