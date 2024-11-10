namespace Blind75.Tests.AdvancedGraphs;

// Input：["wrt","wrf","er","ett","rftt"]
// Output："wertf"
// Explanation：
// from "wrt"and"wrf" ,we can get 't'<'f'
// from "wrt"and"er" ,we can get 'w'<'e'
// from "er"and"ett" ,we can get 'r'<'t'
// from "ett"and"rftt" ,we can get 'e'<'r'
// So return "wertf"


public class AlienDictionaryTest
{
    [Fact]
    public void AlienDictionaryCorrect()
    {
        string[] input = ["wrt", "wrf", "er", "ett", "rftt"];
        string exp = "wertf";

        Assert.Equal(exp, AlienDictionaryClass.AlienOrder(input));
    }
}
