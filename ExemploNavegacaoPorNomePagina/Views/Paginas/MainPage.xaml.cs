using ExemploNavegacaoPorNomePagina.Servicos;
using System.ComponentModel;
using Xamarin.Forms;

namespace ExemploNavegacaoPorNomePagina {
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage {                 
        Navegacao _navegacao = new Navegacao();

        public MainPage() {   
            InitializeComponent();
        }
        
        private void listViewPaginasNome_ItemTapped(object sender, ItemTappedEventArgs e) {
            string nomePagina = e.Item.ToString();
            _navegacao.AbrirPaginaPorNome(nomePagina);
        }
    }
}