using WordGuesser.Core.Domain.Words;

namespace WordGuesser.Core.Domain.Translations;

public class Translation
{
    public TranslationId Id { get; private set; }
    public WordId WordId { get; private set; }
    public string Content { get; private set; } = null!;
    public string Language { get; private set; } = null!;
}
