using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace WNSWofA
{
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0"), CompilerGenerated]
	internal sealed class User : ApplicationSettingsBase
	{
	    public static User Default { get; } = (User)Synchronized(new User());

	    [DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool Tray
		{
			get
			{
				return (bool)this["tray"];
			}
			set
			{
				this["tray"] = value;
			}
		}

		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool OutVk
		{
			get
			{
				return (bool)this["outVk"];
			}
			set
			{
				this["outVk"] = value;
			}
		}

		[DefaultSettingValue("tuturuu.wav"), UserScopedSetting, DebuggerNonUserCode]
		public string SoundPush
		{
			get
			{
				return (string)this["soundPush"];
			}
			set
			{
				this["soundPush"] = value;
			}
		}

		[DefaultSettingValue("False"), UserScopedSetting, DebuggerNonUserCode]
		public bool Mute
		{
			get
			{
				return (bool)this["mute"];
			}
			set
			{
				this["mute"] = value;
			}
		}
	}
}
