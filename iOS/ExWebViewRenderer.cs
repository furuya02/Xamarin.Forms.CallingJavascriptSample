using CallingJavascriptSample;
using CallingJavascriptSample.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin.Forms.CallingJavascriptSample;

[assembly: ExportRenderer(typeof(ExWebView), typeof(ExWebViewRenderer))]
namespace CallingJavascriptSample.iOS
{
	public class ExWebViewRenderer : WebViewRenderer
	{
		protected override void OnElementChanged(VisualElementChangedEventArgs e) {
			base.OnElementChanged(e);

			var exWebView = e.NewElement as ExWebView;
			if (exWebView!=null) {
				exWebView.CallJs = CallJs;
			}
		}

		public void CallJs(string js) {
			//this = UIKit.UIWebView
			//this.EvaluateJavascript(js);
			EvaluateJavascript(js);
		}

	}
}