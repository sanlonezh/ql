﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
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
    public class ResUCNetPayMaintain {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public ResUCNetPayMaintain()
        {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ECCentral.Portal.UI.Invoice.Resources.ResUCNetPayMaintain", typeof(ResUCNetPayMaintain).Assembly);
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
        ///   Looks up a localized string similar to 审核.
        /// </summary>
        public static string Button_Audit {
            get {
                return ResourceManager.GetString("Button_Audit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 关闭.
        /// </summary>
        public static string Button_Close {
            get {
                return ResourceManager.GetString("Button_Close", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 保存.
        /// </summary>
        public static string Button_Save {
            get {
                return ResourceManager.GetString("Button_Save", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 强制核收.
        /// </summary>
        public static string Expander_ForceCheck {
            get {
                return ResourceManager.GetString("Expander_ForceCheck", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 确认.
        /// </summary>
        public static string Message_ConfirmDlgDefaultTitle {
            get {
                return ResourceManager.GetString("Message_ConfirmDlgDefaultTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 确认要进行审核操作?.
        /// </summary>
        public static string Message_ConfrimAuditContent {
            get {
                return ResourceManager.GetString("Message_ConfrimAuditContent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 无效的订单号。.
        /// </summary>
        public static string Message_InvalidSOSysNo {
            get {
                return ResourceManager.GetString("Message_InvalidSOSysNo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 保存成功。.
        /// </summary>
        public static string Message_SaveSuccessful {
            get {
                return ResourceManager.GetString("Message_SaveSuccessful", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 已作废的订单不能创建支付记录！.
        /// </summary>
        public static string Message_SOStatusIsAbandon {
            get {
                return ResourceManager.GetString("Message_SOStatusIsAbandon", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to 精度冗余绝对值大于0.1，请检查返还金额和点数数值是否正确。.
        /// </summary>
        public static string Message_ToleranceAmtIncorrect {
            get {
                return ResourceManager.GetString("Message_ToleranceAmtIncorrect", resourceCulture);
            }
        }
    }
}
