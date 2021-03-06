using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Web;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.Gaming.XboxGameBar;
using Microsoft.Gaming.XboxGameBar.Authentication;

namespace GhostOverlay
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class WidgetNotAuthedView : Page
    {
        private XboxGameBarWidget widget = null;
        private XboxGameBarWebAuthenticationBroker gameBarWebAuth;

        public WidgetNotAuthedView()
        {
            this.InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            widget = e.Parameter as XboxGameBarWidget;
            gameBarWebAuth = new XboxGameBarWebAuthenticationBroker(widget);

            if (widget == null)
            {
                Debug.WriteLine("Widget parameter is null");
                return;
            }

            Debug.WriteLine("WidgetMainView OnNavigatedTo setting widget settings");
            widget.MaxWindowSize = new Size(1500, 1500);
            widget.MinWindowSize = new Size(200, 100);
            widget.HorizontalResizeSupported = true;
            widget.VerticalResizeSupported = true;
        }

        public async void LoginWithDesktopBrowser_OnClick(object sender, RoutedEventArgs e)
        {
            var urlBungieAuth = new Uri(AppState.bungieApi.GetAuthorisationUrl());
            var success = await Windows.System.Launcher.LaunchUriAsync(urlBungieAuth);

            if (success)
            {
                AuthWaiting.Visibility = Visibility.Visible;
                WaitForAuth();
            }
            else
            {
                Debug.WriteLine("TODO: Failed to launch Bungie auth page");
            } 
        }

        public async void LoginWithXboxBroker_OnClick(object sender, RoutedEventArgs e)
        {
            AuthWaiting.Visibility = Visibility.Visible;

            // original bungie redirect url: ghost-overlay:///oauth-return
            var requestUri = new Uri(AppState.bungieApi.GetAuthorisationUrl());
            var callbackUri = new Uri("https://destiny.report/ghost-auth-return");

            XboxGameBarWebAuthenticationResult result = await gameBarWebAuth.AuthenticateAsync(
                XboxGameBarWebAuthenticationOptions.None,
                requestUri,
                callbackUri);

            AuthWaiting.Visibility = Visibility.Collapsed;

            if (result.ResponseStatus == XboxGameBarWebAuthenticationStatus.Success)
            {
                Debug.WriteLine($"Auth has returned successfully with data {result.ResponseData}");

                var responseUri = new Uri(result.ResponseData);
                var parsed = HttpUtility.ParseQueryString(responseUri.Query);
                var authCode = parsed["code"];

                Debug.WriteLine($"authCode: {authCode}");

                await AppState.bungieApi.GetOAuthAccessToken(authCode);

                Debug.WriteLine($"New token data: {AppState.Data.TokenData}");

                if (AppState.Data.TokenData.IsValid())
                {
                    this.Frame.Navigate(typeof(WidgetMainView), widget);
                }
                else
                {
                    throw new Exception("Exchanged code for token, but the TokenData is not valid??");
                }
            }
            else
            {
                BrowserLoginStack.Visibility = Visibility.Visible;
            }
        }

        private async void WaitForAuth()
        {
            while (!(AppState.Data.TokenData?.IsValid() ?? false))
            {
                await Task.Delay(500);
            }

            this.Frame.Navigate(typeof(WidgetMainView), widget);
        }
    }
}
