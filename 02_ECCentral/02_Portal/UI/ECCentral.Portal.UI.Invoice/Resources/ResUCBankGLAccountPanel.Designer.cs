﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ECCentral.Portal.UI.Invoice.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class ResUCBankGLAccountPanel {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public ResUCBankGLAccountPanel()
        {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ECCentral.Portal.UI.Invoice.Resources.ResUCBankGLAccountPanel", typeof(ResUCBankGLAccountPanel).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 确定.
        /// </summary>
        public static string Button_OK {
            get {
                return ResourceManager.GetString("Button_OK", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 请输入银行科目号.
        /// </summary>
        public static string Message_BankGLAccountRequired {
            get {
                return ResourceManager.GetString("Message_BankGLAccountRequired", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 请输入有效的银行科目数字编号.
        /// </summary>
        public static string Message_InvalidBankGLAccount {
            get {
                return ResourceManager.GetString("Message_InvalidBankGLAccount", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 银行科目号:.
        /// </summary>
        public static string TextBlock_BankGLAccount {
            get {
                return ResourceManager.GetString("TextBlock_BankGLAccount", resourceCulture);
            }
        }
    }
}
