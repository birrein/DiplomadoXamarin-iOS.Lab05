// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace PhoneApp
{
    [Register ("ValidateController")]
    partial class ValidateController
    {
        [Outlet]
        UIKit.UITextField EmailTextField { get; set; }

        [Outlet]
        UIKit.UITextField PasswordTextField { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ValidateButton { get; set; }
        
        void ReleaseDesignerOutlets ()
        {
            if (ValidateButton != null) {
                ValidateButton.Dispose ();
                ValidateButton = null;
            }

            if (EmailTextField != null) {
                EmailTextField.Dispose ();
                EmailTextField = null;
            }

            if (PasswordTextField != null) {
                PasswordTextField.Dispose ();
                PasswordTextField = null;
            }
        }
    }
}
