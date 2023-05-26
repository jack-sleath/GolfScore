using GolfScore.Services.Helpers;

namespace GolfScore.Tests.Services.Helpers
{
    [TestFixture]
    public class EmojiStringTests
    {
        [Test]
        [TestCase(true, "😀")]
        [TestCase(true, "👩🏽‍🤝‍🧑🏿")]
        [TestCase(true, "👨🏼")]
        [TestCase(true, "🕵🏿‍♀️")]
        [TestCase(false, "😂😂")]
        [TestCase(false, "1")]
        [TestCase(false, "test")]
        [TestCase(false, "T")]
        [TestCase(false, "+")]
        public void ProfileImage(bool expectedResult, string testValue)
        {
            Assert.That(EmojiString.ValidProfile(testValue), Is.EqualTo(expectedResult));
        }

    }
}
