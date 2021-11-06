using Xunit;

namespace PhotoAlbumTests
{
    public class ArgumentCheckerTests
    {
        [Fact]
        public void HasInvalidArgs_ReturnsFalse()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "1" });
            Assert.False(isInvalid);
        }

        [Fact]
        public void HasInvalidArgs_ZeroArgs_ReturnsTrue()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { });
            Assert.True(isInvalid);
        }

        [Fact]
        public void HasInvalidArgs_MultipleArgs_ReturnsTrue()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "1", "2" });
            Assert.True(isInvalid);
        }

        [Fact]
        public void HasInvalidArgs_NonIntegerArg_ReturnsTrue()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "abc" });
            Assert.True(isInvalid);
        }

    }
}
