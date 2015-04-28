using Android.Webkit;
using CallingJavascriptSample;
using CallingJavascriptSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using WebView = Xamarin.Forms.WebView;

[assembly: ExportRenderer(typeof(ExWebView), typeof(ExWebViewRenderer))]
namespace CallingJavascriptSample.Droid
{
    class ExWebViewRenderer:WebViewRenderer{
        

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e){
            base.OnElementChanged(e);

            //Xamarin.Formのコントロール(ExWebView)
            var exWebView = e.NewElement as ExWebView;
            //ExWebViewのメソッドにレンダラー側のメソッドをアタッチする
            if (exWebView != null) {
                exWebView.CallJs = CallJs;
            }
            //alert や prompt を使う場合、下記の設定が必要
            Control.SetWebChromeClient(new WebChromeClient());
        }
        public void CallJs(string js){
            //Android.Webkit.WebView
            Control.LoadUrl("javascript:" + js);
        }

    }
}