namespace VendavoTest.Tests;

[TestClass]
public class Question1Tests
{
    public static IEnumerable<object[]> Data
    {
        get => [
            [3, new int[] {1, 2, 3}],
            [5, new int[] {1, 2, 3, 4, 5 }],
            [4, new int[] {1, 2, 3, 4, 4 }],
            [1, new int[] {1, 2, 0, 4, 0 }],
            [2, new int[] {1, 2, 3, 4, 0 }],
            [4, new int[] {1, 1, 2, 3, 4,}],
            [5, new int[] {1, 1, 2, 3, 4, -1}],
            [5, new int[] {1, 1, 2, 3, 4, -2, -2}],
            [5, new int[] {1, 1, 2, 3, 4, -2, -2, -2}],
        ];
    }

    [TestMethod]
    [DynamicData(nameof(Data))]
    public void Question1Test(int expected, int[] input)
    {
        //Arrange
        //Act
        var result = Question1.Solution(input);

        //Assert
        Assert.AreEqual(expected, result);
    }
}