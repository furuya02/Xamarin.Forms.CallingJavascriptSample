using Android.Webkit;
using Xamarin.Forms.CallingJavascriptSample;
using Xamarin.Forms.CallingJavascriptSample.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using WebView = Xamarin.Forms.WebView;

[assembly: ExportRenderer(typeof(ExWebView), typeof(ExWebViewRenderer))]
namespace Xamarin.Forms.CallingJavascriptSample.Droid
{
	class ExWebViewRenderer:WebViewRenderer{


		protected override void OnElementChanged(ElementChangedEventArgs<WebView> e){
			base.OnElementChanged(e);

			var exWebView = e.NewElement as ExWebView;
			if (exWebView != null) {
				exWebView.CallJs = CallJs;
			}
			Control.SetWebChromeClient(new WebChromeClient());
		}
		public void CallJs(string js){
			//Android.Webkit.WebView
			Control.LoadUrl("javascript:" + js);
		}

	}
}
