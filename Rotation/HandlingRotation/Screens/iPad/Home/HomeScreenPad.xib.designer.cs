// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace HandlingRotation.Screens.iPad.Home {
	
	
	// Base type probably should be UIKit.UIViewController or subclass
	[Foundation.Register("HomeScreenPad")]
	public partial class HomeScreenPad {
		
		private UIKit.UIView __mt_view;
		
		private UIKit.UIButton __mt_btnMethod1;
		
		private UIKit.UIButton __mt_btnMethod2;
		
		private UIKit.UIButton __mt_btnMethod3;
		
		#pragma warning disable 0169
		[Foundation.Connect("view")]
		private UIKit.UIView view {
			get {
				this.__mt_view = ((UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[Foundation.Connect("btnMethod1")]
		private UIKit.UIButton btnMethod1 {
			get {
				this.__mt_btnMethod1 = ((UIKit.UIButton)(this.GetNativeField("btnMethod1")));
				return this.__mt_btnMethod1;
			}
			set {
				this.__mt_btnMethod1 = value;
				this.SetNativeField("btnMethod1", value);
			}
		}
		
		[Foundation.Connect("btnMethod2")]
		private UIKit.UIButton btnMethod2 {
			get {
				this.__mt_btnMethod2 = ((UIKit.UIButton)(this.GetNativeField("btnMethod2")));
				return this.__mt_btnMethod2;
			}
			set {
				this.__mt_btnMethod2 = value;
				this.SetNativeField("btnMethod2", value);
			}
		}
		
		[Foundation.Connect("btnMethod3")]
		private UIKit.UIButton btnMethod3 {
			get {
				this.__mt_btnMethod3 = ((UIKit.UIButton)(this.GetNativeField("btnMethod3")));
				return this.__mt_btnMethod3;
			}
			set {
				this.__mt_btnMethod3 = value;
				this.SetNativeField("btnMethod3", value);
			}
		}
	}
}
