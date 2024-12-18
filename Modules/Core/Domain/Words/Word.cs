namespace WordGuesser.Core.Domain.Words;

public class Word
{
    public WordId Id { get; private set; }
    public string Content { get; private set; } = null!;
    public string Language { get; private set; } = null!;
}
