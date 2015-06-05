using System;
using Xamarin.UITest;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace XamFormsSpecFlowTest.UITests
{
	[TestFixture (Platform.Android)]
	[TestFixture (Platform.iOS)]
	public abstract class FeatureBase
	{
		protected IApp app;
		protected Platform platform;

		public FeatureBase (Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest ()
		{
			app = AppInitializer.StartApp (platform);
			FeatureContext.Current.Add ("App", app);
		}
	}
}

