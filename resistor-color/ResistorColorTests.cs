public class ResistorColorTests
{
    [Fact]
    public void Black()
    {
        Assert.Equal(0, ResistorColor.ColorCode("black"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void White()
    {
        Assert.Equal(9, ResistorColor.ColorCode("white"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Orange()
    {
        Assert.Equal(3, ResistorColor.ColorCode("orange"));
    }

    [Fact(Skip = "Remove this Skip property to run this test")]
    public void Colors()
    {
        string[] expected = ["black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white"];
        Assert.Equal(expected, ResistorColor.Colors());
    }
}
