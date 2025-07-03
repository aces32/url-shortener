namespace UrlShortener.Api.Core.Tests
{
    public class TokenRangeScenarios
    {
        [Fact]
        public void When_start_token_is_greater_than_end_then_throw_exception()
        {
            // Arrange
            var tokenProvider = new TokenProvider();
            // Act
            Action act = () => tokenProvider.AssignRange(10, 5);
            // Assert
            act.Should().Throw<ArgumentException>()
                .WithMessage("Start of the range must be less than or equal to the end.");
        }
    }
}
