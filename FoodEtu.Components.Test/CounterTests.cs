using Bunit;
using FoodEtu.Server.Pages;
using Xunit;

namespace FoodEtu.Components.Test;
public class CounterTests
{
    [Fact]
    public void CounterShouldIncrementWhenClicked()
    {
        using var ctx = new TestContext();
        var cut = ctx.RenderComponent<Counter>();

        cut.Find("button").Click();

        cut.Find("p").MarkupMatches("<p role=\"status\">Current Alexandre count: 1</p>");
    }
}
