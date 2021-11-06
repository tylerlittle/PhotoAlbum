using Xunit;

namespace PhotoAlbumTests
{
    public class ArgumentCheckerTests
    {
        [Fact]
        public void HasInvalidArgs_MinRangeValid_ReturnsFalse()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "1" });
            Assert.False(isInvalid);
        }

        [Fact]
        public void HasInvalidArgs_MaxRangeValid_ReturnsFalse()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "100" });
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

        [Fact]
        public void HasInvalidArgs_MinRangeViolation_ReturnsTrue()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "0" });
            Assert.True(isInvalid);
        }

        [Fact]
        public void HasInvalidArgs_MaxRangeViolation_ReturnsTrue()
        {
            var isInvalid = PhotoAlbum.ArgumentChecker.HasInvalidArgs(new string[] { "101" });
            Assert.True(isInvalid);
        }

    }
}
