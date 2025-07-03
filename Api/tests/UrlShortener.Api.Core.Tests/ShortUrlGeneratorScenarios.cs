namespace UrlShortener.Api.Core.Tests
{
    public class ShortUrlGeneratorScenarios
    {
        [Fact]
        public void Should_return_short_url_for_zero()
        {
            // Arrange
            var tokenProvider = new TokenProvider();
            tokenProvider.AssignRange(0, 10);
            var generator = new ShortUrlGenerator(tokenProvider);
            // Act
             var shortUrl = generator.GenerateShortUrl();
            // Assert
            shortUrl.Should().Be("0");
        }

        [Fact]
        public void Should_return_short_url_for_10001()
        {
            // Arrange
            var tokenProvider = new TokenProvider();
            tokenProvider.AssignRange(10001, 20000);
            var generator = new ShortUrlGenerator(tokenProvider);
            // Act
            var shortUrl = generator.GenerateShortUrl();
            // Assert
            shortUrl.Should().Be("2bJ");
        }
    }
}
