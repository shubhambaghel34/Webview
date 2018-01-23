using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WebviewApp
{
  public  class WebviewPage: ContentPage

    {
        public WebviewPage()
        {
                        BackgroundColor = Color.MistyRose;
            Label header = new Label
            {
                Text = "WebView",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                HorizontalOptions = LayoutOptions.Center
            };
           
            WebView webView = new WebView
            {
                Source = new UrlWebViewSource
                {
                    
                    Url = "https://www.google.co.in",
                },
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            WebView web2 = new WebView
            {
                Source = new HtmlWebViewSource
                {
                    Html = "<html><body>Hello</body></html>"
                }
            };
            Padding = new Thickness(10, 20, 10, 5);
            Content = new StackLayout
            {
                Children =
                {
                    header,
                    webView,
                    web2
                }
            };
        }




    }
}
