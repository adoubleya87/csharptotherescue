// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Act1First_Form.CSharp.CST150
{
	[Register("ViewController")]
	partial class ViewController
	{
        public object MessageBox { get; private set; }

        [Action("ClickMeBtn:")]
		partial void ClickMeBtn(Foundation.NSObject sender);

		void ReleaseDesignerOutlets()
		{
		MessageBox.Show("Thanks for clicking the button!");
		}
	}
}
