﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Health.Api {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Health.Api.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum length of a custom audit header value is {0}. The supplied custom audit header &apos;{1}&apos; has length of {2}..
        /// </summary>
        internal static string CustomAuditHeaderTooLarge {
            get {
                return ResourceManager.GetString("CustomAuditHeaderTooLarge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A duplicate controller/action was found with different audit events. Controller: {0}, Action: {1}. Try using distinct action names inside the same controller..
        /// </summary>
        internal static string DuplicateActionForAuditEvent {
            get {
                return ResourceManager.GetString("DuplicateActionForAuditEvent", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Failed while running health check..
        /// </summary>
        internal static string FailedHealthCheckMessage {
            get {
                return ResourceManager.GetString("FailedHealthCheckMessage", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Health Check cache refresh offset cannot be larger than the expiry..
        /// </summary>
        internal static string InvalidHealthCheckCacheExpiry {
            get {
                return ResourceManager.GetString("InvalidHealthCheckCacheExpiry", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The audit information is missing for Controller: {0} and Action: {1}. This usually means the action is not marked with appropriate attribute..
        /// </summary>
        internal static string MissingAuditInformation {
            get {
                return ResourceManager.GetString("MissingAuditInformation", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The maximum number of custom audit headers allowed is {0}. The number of custom audit headers supplied is {1}..
        /// </summary>
        internal static string TooManyCustomAuditHeaders {
            get {
                return ResourceManager.GetString("TooManyCustomAuditHeaders", resourceCulture);
            }
        }
    }
}
