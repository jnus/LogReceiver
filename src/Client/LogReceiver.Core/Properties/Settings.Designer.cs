﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LogReceiver.Core.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    public sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ILogReceiverUserSettings_WordWrap {
            get {
                return ((string)(this["ILogReceiverUserSettings_WordWrap"]));
            }
            set {
                this["ILogReceiverUserSettings_WordWrap"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ILogReceiverUserSettings_ParseCSharpStackTrace {
            get {
                return ((string)(this["ILogReceiverUserSettings_ParseCSharpStackTrace"]));
            }
            set {
                this["ILogReceiverUserSettings_ParseCSharpStackTrace"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string ILogReceiverUserSettings_MaxNumberOfLogEntries {
            get {
                return ((string)(this["ILogReceiverUserSettings_MaxNumberOfLogEntries"]));
            }
            set {
                this["ILogReceiverUserSettings_MaxNumberOfLogEntries"] = value;
            }
        }
    }
}
