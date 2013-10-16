using System;
using NetOffice;
namespace NetOffice.WordApi.Enums
{
	 /// <summary>
	 /// SupportByVersion Word 15
	 /// </summary>
	[SupportByVersionAttribute("Word", 15)]
	[EntityTypeAttribute(EntityType.IsEnum)]
	public enum WdRevisionsMarkup
	{
		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>0</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdRevisionsMarkupNone = 0,

		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>1</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdRevisionsMarkupSimple = 1,

		 /// <summary>
		 /// SupportByVersion Word 15
		 /// </summary>
		 /// <remarks>2</remarks>
		 [SupportByVersionAttribute("Word", 15)]
		 wdRevisionsMarkupAll = 2
	}
}