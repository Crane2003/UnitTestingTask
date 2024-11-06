using UnitTestingTask;

namespace UnitTestingTask_Tests;

[TestFixture]
public class AnalyzerTests
{
    // Test MaxUnequalConsecutive
    [Test]
    public void MaxUnequalConsecutive_InputIsNull_ReturnsZero()
    {
        // Arrange
        string? input = null;

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxUnequalConsecutive_InputIsEmpty_ReturnsZero()
    {
        // Arrange
        string input = string.Empty;

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxUnequalConsecutive_AllSameCharacters_ReturnsOne()
    {
        // Arrange
        string input = "aaaa";

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void MaxUnequalConsecutive_AllDifferentCharacters_ReturnsLength()
    {
        // Arrange
        string input = "abcd";

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void MaxUnequalConsecutive_MixedCharacters_ReturnsExpected()
    {
        // Arrange
        string input = "aabbbcddd";

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }

    // Additional Tests for MaxUnequalConsecutive   
    [Test]
    public void MaxUnequalConsecutive_AlternatingCharacters_ReturnsLength()
    {
        // Arrange
        string input = "ababababa";

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(9));
    }

    [Test]
    public void MaxUnequalConsecutive_MixedCaseCharacters_ReturnsExpected()
    {
        // Arrange
        string input = "AaBbCcDd";

        // Act
        int result = Analyzer.MaxUnequalConsecutive(input);

        // Assert
        Assert.That(result, Is.EqualTo(8));
    }


    // Test MaxConsecutiveIdenticalLetters
    [Test]
    public void MaxConsecutiveIdenticalLetters_InputIsNull_ReturnsZero()
    {
        // Arrange
        string? input = null;

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_InputIsEmpty_ReturnsZero()
    {
        // Arrange
        string input = string.Empty;

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_AllSameLetters_ReturnsLength()
    {
        // Arrange
        string input = "aaaa";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_MixedLetters_ReturnsExpected()
    {
        // Arrange
        string input = "aabbbccccc";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }

    // Additional Tests for MaxConsecutiveIdenticalLetters
    [Test]
    public void MaxConsecutiveIdenticalLetters_NonLetterCharacters_ReturnsZero()
    {
        // Arrange
        string input = "1234!@#$";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalLetters_MixedCharactersWithLetters_ReturnsExpected()
    {
        // Arrange
        string input = "aa1bb2cc3ccc";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalLetters(input);

        // Assert
        Assert.That(result, Is.EqualTo(3));
    }


    // Test MaxConsecutiveIdenticalDigits
    [Test]
    public void MaxConsecutiveIdenticalDigits_InputIsNull_ReturnsZero()
    {
        // Arrange
        string? input = null;

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_InputIsEmpty_ReturnsZero()
    {
        // Arrange
        string input = string.Empty;

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_AllSameDigits_ReturnsLength()
    {
        // Arrange
        string input = "1111";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_MixedDigits_ReturnsExpected()
    {
        // Arrange
        string input = "11222333344";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(4));
    }

    // Additional Tests for MaxConsecutiveIdenticalDigits
    [Test]
    public void MaxConsecutiveIdenticalDigits_NonDigitCharacters_ReturnsZero()
    {
        // Arrange
        string input = "abcdEFG";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void MaxConsecutiveIdenticalDigits_MixedDigitsAndLetters_ReturnsExpected()
    {
        // Arrange
        string input = "123455555abc111";

        // Act
        int result = Analyzer.MaxConsecutiveIdenticalDigits(input);

        // Assert
        Assert.That(result, Is.EqualTo(5));
    }
}