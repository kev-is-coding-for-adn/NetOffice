using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 10, 11, 12, 14
	 /// </summary>
	[SupportByVersionAttribute("Word", 10,11,12,14)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdLanguageID2000
	{
		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>3076</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14)]
		 wdChineseHongKong = 3076,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>5124</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14)]
		 wdChineseMacao = 5124,

		 /// <summary>
		 /// SupportByVersion Word 10, 11, 12, 14
		 /// </summary>
		 /// <remarks>11273</remarks>
		 [SupportByVersionAttribute("Word", 10,11,12,14)]
		 wdEnglishTrinidad = 11273
	}
}