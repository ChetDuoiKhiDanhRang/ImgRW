﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ImgRW_WF.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool resize {
            get {
                return ((bool)(this["resize"]));
            }
            set {
                this["resize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("FixWidth")]
        public global::ImgRW_WF.ResizeModes resizeMode {
            get {
                return ((global::ImgRW_WF.ResizeModes)(this["resizeMode"]));
            }
            set {
                this["resizeMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("750")]
        public int resizeValue {
            get {
                return ((int)(this["resizeValue"]));
            }
            set {
                this["resizeValue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool drawString {
            get {
                return ((bool)(this["drawString"]));
            }
            set {
                this["drawString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ImageRW")]
        public string content {
            get {
                return ((string)(this["content"]));
            }
            set {
                this["content"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Consolas")]
        public string fontName {
            get {
                return ((string)(this["fontName"]));
            }
            set {
                this["fontName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool fontStyleBold {
            get {
                return ((bool)(this["fontStyleBold"]));
            }
            set {
                this["fontStyleBold"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool fontStyleItalic {
            get {
                return ((bool)(this["fontStyleItalic"]));
            }
            set {
                this["fontStyleItalic"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool fontStyleUnderline {
            get {
                return ((bool)(this["fontStyleUnderline"]));
            }
            set {
                this["fontStyleUnderline"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("30")]
        public decimal fontSize {
            get {
                return ((decimal)(this["fontSize"]));
            }
            set {
                this["fontSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool frameString {
            get {
                return ((bool)(this["frameString"]));
            }
            set {
                this["frameString"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10")]
        public decimal frameLineWidth {
            get {
                return ((decimal)(this["frameLineWidth"]));
            }
            set {
                this["frameLineWidth"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#9900FF82")]
        public string stringColor {
            get {
                return ((string)(this["stringColor"]));
            }
            set {
                this["stringColor"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BottomCenter")]
        public global::ImgRW_WF.LocationModes stringLocationMode {
            get {
                return ((global::ImgRW_WF.LocationModes)(this["stringLocationMode"]));
            }
            set {
                this["stringLocationMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public decimal stringLocationX {
            get {
                return ((decimal)(this["stringLocationX"]));
            }
            set {
                this["stringLocationX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public decimal stringLocationY {
            get {
                return ((decimal)(this["stringLocationY"]));
            }
            set {
                this["stringLocationY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool drawImage {
            get {
                return ((bool)(this["drawImage"]));
            }
            set {
                this["drawImage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string imagePath {
            get {
                return ((string)(this["imagePath"]));
            }
            set {
                this["imagePath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("BottomCenter")]
        public global::ImgRW_WF.LocationModes imageLocationMode {
            get {
                return ((global::ImgRW_WF.LocationModes)(this["imageLocationMode"]));
            }
            set {
                this["imageLocationMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public float stringRotateAngle {
            get {
                return ((float)(this["stringRotateAngle"]));
            }
            set {
                this["stringRotateAngle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal imageLocationX {
            get {
                return ((decimal)(this["imageLocationX"]));
            }
            set {
                this["imageLocationX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public decimal imageLocationY {
            get {
                return ((decimal)(this["imageLocationY"]));
            }
            set {
                this["imageLocationY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public float imageRotateAngle {
            get {
                return ((float)(this["imageRotateAngle"]));
            }
            set {
                this["imageRotateAngle"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.8")]
        public float imageOptical {
            get {
                return ((float)(this["imageOptical"]));
            }
            set {
                this["imageOptical"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string outputPath {
            get {
                return ((string)(this["outputPath"]));
            }
            set {
                this["outputPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public byte outputFormat {
            get {
                return ((byte)(this["outputFormat"]));
            }
            set {
                this["outputFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("en")]
        public string lang {
            get {
                return ((string)(this["lang"]));
            }
            set {
                this["lang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public decimal imgScale {
            get {
                return ((decimal)(this["imgScale"]));
            }
            set {
                this["imgScale"] = value;
            }
        }
    }
}
