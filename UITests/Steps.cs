using System;
using TechTalk.SpecFlow;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using NUnit.Framework;
using System.Linq;

namespace XamFormsSpecFlowTest.UITests
{
	[Binding]
	public class Steps
	{
		IApp app;

		public Steps ()
		{
			app = FeatureContext.Current.Get<IApp> ("App");
		}

		[Given ("App has started")]
		public void GivenAppHasStarted ()
		{
		}

		[When ("I look at the screen")]
		public void WhenILookAtTheScreen ()
		{
		}

		[Then ("the welcome screen show be displayed")]
		public void WelcomeScreenShouldBeDisplayed ()
		{
			AppResult[] results = app.WaitForElement (c => c.Marked ("Welcome to Xamarin Forms!"));
			app.Screenshot ("Welcome screen.");

			Assert.IsTrue (results.Any ());
		}
	}



}

