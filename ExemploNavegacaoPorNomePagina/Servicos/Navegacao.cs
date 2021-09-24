using System;
using Xamarin.Forms;

namespace ExemploNavegacaoPorNomePagina.Servicos {
    public class Navegacao : INavegacao {
        public void AbrirPaginaPorNome(string nomePagina) {
            try {
                var tipoPagina = Type.GetType($"ExemploNavegacaoPorNomePagina.Views.Paginas.{nomePagina}", true);

                var pagina = Activator.CreateInstance(tipoPagina) as Page;

                App.Current.MainPage.Navigation.PushAsync(pagina);
            } catch {
                App.Current.MainPage.DisplayAlert("Página não encontrada", $"A página {nomePagina} não foi encontrada!", "Ok");
            }            
        }
    }
}