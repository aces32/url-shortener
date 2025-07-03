
namespace UrlShortener.Api.Core
{
    public record TokenRange
    {
        public TokenRange(long start, long end)
        {
            if (end < start)
                throw new ArgumentException("Start of the range must be less than or equal to the end.");

            Start = start;
            End = end;
        }

        public long Start { get; init; }
        public long End { get; init; }
    };
}