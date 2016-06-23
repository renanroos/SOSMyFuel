using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace SOSMyFuel
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
            
        }

        /// <summary>
        /// Método Clique do botão Calcular da tela principal
        /// Criado por Renan Roos
        /// 21/06/2016
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCalcular_Click(object sender, RoutedEventArgs e)
        {
            //Renan Roos - 21/06/2016 - Variáveis de resultado do app - Início
            int litros;
            int media;
            //Renan Roos - 21/06/2016 - Variáveis de resultado do app - Fim

            //Renan Roos - 21/06/2016 - Validação de preenchimento dos campos - Início
            if (txtKms.Text == "" || txtPreco.Text == "" || txtValor.Text == "")
            {
                lblResultado.Text = "Preencha todos os campos para prosseguir!";
            }
            else if (Regex.IsMatch(txtKms.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(txtPreco.Text, @"^[a-zA-Z]+$") || Regex.IsMatch(txtValor.Text, @"^[a-zA-Z]+$"))
            {
                lblResultado.Text = "Os campos acima aceitam apenas números!";
            }
            //Renan Roos - 21/06/2016 - Validação de preenchimento dos campos - Fim
            //Renan Roos - 21/06/2016 - Se todos os campos estiverem corretamente preenchidos, o sistema prossegue - Início
            else
            {
                //Renan Roos - 21/06/2016 - Método que calcula a quantidade de litros gastos é chamado - Início
                litros = CalculaMedia.calculaLitros(int.Parse(txtPreco.Text), int.Parse(txtValor.Text));
                //Renan Roos - 21/06/2016 - Método que calcula a quantidade de litros gastos é chamado - Fim
                //Renan Roos - 21/06/2016 - Método que calcula a quantidade de quilômetros feitos com um litro de combustível é chamado - Início
                media = CalculaMedia.calculaMedia(int.Parse(txtKms.Text), litros);
                //Renan Roos - 21/06/2016 - Método que calcula a quantidade de quilômetros feitos com um litro de combustível é chamado - Fim
                //Renan Roos - 21/06/2016 - O resultado é exibido - Início
                lblResultado.Text = string.Format("O seu automóvel usou {litros} litros de combustível e está fazendo {media} quilômetros por litro de combustível :)");
                //Renan Roos - 21/06/2016 - O resultado é exibido - Fim
            }
            //Renan Roos - 21/06/2016 - Se todos os campos estiverem corretamente preenchidos, o sistema prossegue - Fim
        }
    }
}
