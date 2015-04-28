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

            //Xamarin.Form�̃R���g���[��(ExWebView)
            var exWebView = e.NewElement as ExWebView;
            //ExWebView�̃��\�b�h�Ƀ����_���[���̃��\�b�h���A�^�b�`����
            if (exWebView!=null) {
                exWebView.CallJs = CallJs;
            }

        }

        public void CallJs(string js) {
            //this = UIKit.UIWebView�Ȃ̂� 
            //this.EvaluateJavascript(js);��JavaScript���R�[���ł���
            EvaluateJavascript(js);
        }

    }
}