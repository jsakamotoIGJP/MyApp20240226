using Bunit;
using Microsoft.Extensions.DependencyInjection;
using MyApp20240226B.Pages;

namespace TestMyApp20240226B
{
	[Collection("MyApp20240226B")]
	public class TestMacBook_Air_1
	{
		[Fact]
		public void ViewIsCreated()
		{
			using var ctx = new TestContext();
			ctx.JSInterop.Mode = JSRuntimeMode.Loose;
			ctx.Services.AddIgniteUIBlazor(
				typeof(IgbNavbarModule));
			var componentUnderTest = ctx.RenderComponent<MacBook_Air_1>();
			Assert.NotNull(componentUnderTest);
		}
	}
}
