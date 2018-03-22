using System;
using System.ComponentModel;
using CoreGraphics;
using Foundation;
using UIKit;

namespace SampleDemo
{
    [Register("CustomButton"), DesignTimeVisible(true)]
    public class CustomButton : UIButton
    {
        [DisplayName("Border Color"), Export("BorderColor"), Browsable(true)]
        public UIColor BorderColor { get; set; } = UIColor.Clear;

        [DisplayName("Font Size"), Export("FontSise"), Browsable(true)]
        public float FontSize { get; set; } = 8f;

        public CustomButton(IntPtr handle) 
            : base(handle)
        {
        }

        public CustomButton(CGRect frame) 
            : base(frame)
        {
            
        }

		public override void AwakeFromNib()
		{
            base.AwakeFromNib();
            SetupBorders();
		}

        protected void SetupBorders()
        {
            this.Layer.BorderColor = BorderColor.CGColor;
            this.Layer.BorderWidth = 2;
            this.Layer.CornerRadius = Frame.Height / 2;
            this.Layer.MasksToBounds = true;
        }
	}
}
