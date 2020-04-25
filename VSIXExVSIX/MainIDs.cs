using System;
using VSIXEx.Attributes;

namespace VSIXExVSIX
{
	[GuidSymbols]
	public static class GuidSymbols
	{
		[GuidSymbol]
		public const string guidMainPackage = "87ac2de8-7288-4c92-8d2e-8827ce7e71c9";
		[GuidSymbol]
		public const string guidMainPackageCmdSet = "3767ee58-dd86-41eb-93f7-8896274b8c7d";
		[GuidSymbol]
		public const string guidImages = "d1840211-2031-4c96-b606-670e494a093f";

		public static readonly Guid MainPackage = new Guid(guidMainPackage);
		public static readonly Guid MainCommandSet = new Guid(guidMainPackageCmdSet);
	}

}
