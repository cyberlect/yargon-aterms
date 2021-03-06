﻿using Xunit;

namespace Yargon.ATerms
{
	partial class TrivialTermFactoryTests
	{
		public sealed class StringTermTests : TestBase
		{
			#region SUT
			public TrivialTermFactory.StringTerm CreateSUT(string value)
			{
				return (TrivialTermFactory.StringTerm)Factory.String(value);
			}

			public sealed class StringTerm_IStringTerm : IStringTermTests
			{
				public override IStringTerm CreateSUT(string value)
				{
					return new StringTermTests().CreateSUT(value);
				}
			}
			#endregion
		}
	}
}
