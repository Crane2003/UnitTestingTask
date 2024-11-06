namespace UnitTestingTask;

public class Analyzer
{
    private const int InitialLengthForUnequalConsecutive = 1;
    private const int InitialLengthForIdenticalSequences = 0;

    private static int MaxConsecutive(string? input, int initialMaxLength, Func<char, char, bool> condition)
    {
        if (string.IsNullOrEmpty(input)) return 0;

        int maxLength = initialMaxLength;
        int currentLength = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (condition(input[i], input[i - 1]))
            {
                currentLength++;
                maxLength = Math.Max(maxLength, currentLength);
            }
            else
            {
                currentLength = 1;
            }
        }

        return maxLength;
    }

    public static int MaxUnequalConsecutive(string? input)
    {
        return MaxConsecutive(
            input,
            InitialLengthForUnequalConsecutive,
            (current, previous) => current != previous);
    }

    public static int MaxConsecutiveIdenticalLetters(string? input)
    {
        return MaxConsecutive(
            input,
            InitialLengthForIdenticalSequences,
            (current, previous) => char.IsLetter(current) && current == previous);
    }

    public static int MaxConsecutiveIdenticalDigits(string? input)
    {
        return MaxConsecutive(
            input,
            InitialLengthForIdenticalSequences,
            (current, previous) => char.IsDigit(current) && current == previous);
    }
}

