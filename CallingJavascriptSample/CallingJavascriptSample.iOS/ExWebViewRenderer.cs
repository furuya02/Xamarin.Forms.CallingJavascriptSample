using CallingJavascriptSample;
using CallingJavascriptSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ExWebView), typeof(ExWebViewRenderer))]
namespace CallingJavascriptSample.iOS
{
    public class ExWebViewRenderer : WebViewRenderer
    {
        protected override void OnElementChanged(VisualElementChangedEventArgs e) {
            base.OnElementChanged(e);

            //Xamarin.Formのコントロール(ExWebView)
            var exWebView = e.NewElement as ExWebView;
            //ExWebViewのメソッドにレンダラー側のメソッドをアタッチする
            if (exWebView!=null) {
                exWebView.CallJs = CallJs;
            }

        }

        public void CallJs(string js) {
            //this = UIKit.UIWebViewなので 
            //this.EvaluateJavascript(js);でJavaScriptがコールできる
            EvaluateJavascript(js);
        }

    }
}