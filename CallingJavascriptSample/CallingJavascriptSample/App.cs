using Xamarin.Forms;

namespace CallingJavascriptSample
{
    public class App : Application{
        public App(){
            MainPage = new MyPage();
        }
    }

    class MyPage : ContentPage {
        public MyPage() {
            var webView = new ExWebView() {
                Source = "http://www.google.com",
                VerticalOptions = LayoutOptions.FillAndExpand,
            };

            var entry = new Entry() {
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var button = new Button {
                WidthRequest = 60,
                Text = "OK"
            };
            button.Clicked += async (s, a) => {
                if (!string.IsNullOrEmpty(entry.Text)) {
                    webView.CallJs(entry.Text);
                }

                //var js = string.Format("document.getElementById('lst-ib').value='{0}';",entry.Text);
                //webView.CallJs(js);
                //await Task.Delay(2000);
                //js = "document.getElementsByName('btnG')[0].click();";
                //webView.CallJs(js);

                entry.Unfocus();//キーボード非表示

            };

            Content = new StackLayout {
                Padding = new Thickness(0,Device.OnPlatform(20,0,0),0,0),
                Children = {
                    new StackLayout {
                        BackgroundColor = Color.Navy,
                        Padding = 5,
                        Orientation = StackOrientation.Horizontal,
                        Children = { entry,button}
                    },webView
                }
            };
        }
    }

    public class ExWebView : WebView {
        public delegate void CallJsHandler(string js);
        public CallJsHandler CallJs;//JavaScriptの実行
    }
}
