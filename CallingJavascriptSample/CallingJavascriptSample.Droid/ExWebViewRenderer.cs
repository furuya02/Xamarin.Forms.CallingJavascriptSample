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

            //Xamarin.Form�̃R���g���[��(ExWebView)
            var exWebView = e.NewElement as ExWebView;
            //ExWebView�̃��\�b�h�Ƀ����_���[���̃��\�b�h���A�^�b�`����
            if (exWebView != null) {
                exWebView.CallJs = CallJs;
            }
            //alert �� prompt ���g���ꍇ�A���L�̐ݒ肪�K�v
            Control.SetWebChromeClient(new WebChromeClient());
        }
        public void CallJs(string js){
            //Android.Webkit.WebView
            Control.LoadUrl("javascript:" + js);
        }

    }
}