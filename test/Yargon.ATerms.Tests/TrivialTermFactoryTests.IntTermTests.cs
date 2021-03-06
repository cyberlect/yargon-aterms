﻿using Xunit;

namespace Yargon.ATerms
{
	partial class TrivialTermFactoryTests
	{
		public sealed class IntTermTests : TestBase
		{
			#region SUT
			public TrivialTermFactory.IntTerm CreateSUT(int value)
			{
				return (TrivialTermFactory.IntTerm)Factory.Int(value);
			}

			public sealed class IntTerm_IIntTerm : IIntTermTests
			{
				public override IIntTerm CreateSUT(int value)
				{
					return new IntTermTests().CreateSUT(value);
				}
			}
			#endregion
		}
	}
}
