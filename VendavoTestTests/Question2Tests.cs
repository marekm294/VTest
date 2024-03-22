namespace VendavoTest.Tests;

[TestClass()]
public class Question2Tests
{
    public static IEnumerable<object[]> Data
    {
        get => [
            [4, 9, new int[] {5, 3, 8, 1, 8, 7, 7, 6}],
            [5, 7, new int[] {7, 6, 5, 2, 7, 4, 5, 4 }],
            [0, 7, new int[] {3, 4, 3, 1}],
        ];
    }

    [TestMethod()]
    [DynamicData(nameof(Data))]
	public void Question2Test(int expected, int U, int[] weight)
	{
        var result = Question2.Solution(U, weight);

        Assert.AreEqual(expected, result);
	}
}