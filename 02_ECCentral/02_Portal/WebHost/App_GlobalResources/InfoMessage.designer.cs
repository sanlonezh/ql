//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option or rebuild the Visual Studio project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Web.Application.StronglyTypedResourceProxyBuilder", "11.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class InfoMessage {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        public InfoMessage() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Resources.InfoMessage", global::System.Reflection.Assembly.Load("App_GlobalResources"));
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
        ///   Looks up a localized string similar to Invalid parameter..
        /// </summary>
        public static string Info_InvalidParameter {
            get {
                return ResourceManager.GetString("Info_InvalidParameter", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to BCC field is invalid..
        /// </summary>
        public static string Validation_Invalid_BCC {
            get {
                return ResourceManager.GetString("Validation_Invalid_BCC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to CC field is invalid..
        /// </summary>
        public static string Validation_Invalid_CC {
            get {
                return ResourceManager.GetString("Validation_Invalid_CC", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to From field is invalid..
        /// </summary>
        public static string Validation_Invalid_From {
            get {
                return ResourceManager.GetString("Validation_Invalid_From", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To field is invalid..
        /// </summary>
        public static string Validation_Invalid_To {
            get {
                return ResourceManager.GetString("Validation_Invalid_To", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to From field is required..
        /// </summary>
        public static string Validation_Required_From {
            get {
                return ResourceManager.GetString("Validation_Required_From", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subject field is required..
        /// </summary>
        public static string Validation_Required_Subject {
            get {
                return ResourceManager.GetString("Validation_Required_Subject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to To field is required..
        /// </summary>
        public static string Validation_Required_To {
            get {
                return ResourceManager.GetString("Validation_Required_To", resourceCulture);
            }
        }
    }
}