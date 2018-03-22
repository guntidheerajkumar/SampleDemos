// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace SampleDemo
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        SampleDemo.CustomButton MyCustomButton { get; set; }

        void ReleaseDesignerOutlets ()
        {
            if (MyCustomButton != null) {
                MyCustomButton.Dispose ();
                MyCustomButton = null;
            }
        }
    }
}