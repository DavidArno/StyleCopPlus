namespace StyleCopPlus.Plugin.AdvancedNaming
{
	/// <summary>
	/// Special setting for blocking @ character.
	/// </summary>
	public class BlockAt : EntitySetting
	{
		/// <summary>
		/// Gets help text for current setting.
		/// </summary>
		public override string HelpText
		{
			get { return EntitySettingResources.BlockAtHelp; }
		}
	}
}
