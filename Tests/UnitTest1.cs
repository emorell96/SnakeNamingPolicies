using FluentAssertions;
using SnakeCaseNamingPolicies;

namespace Tests
{
    [TestClass]
    public class SnakePolicyTests
    {
        [TestMethod]
        [DataRow("", "")]
        [DataRow("A", "a")]
        [DataRow("AB", "ab")]
        [DataRow("ABC", "abc")]
        [DataRow("ABCD", "abcd")]
        [DataRow("IOStream", "io_stream")]
        [DataRow("IOStreamAPI", "io_stream_api")]
        [DataRow("already_snake", "already_snake")]
        [DataRow("SCREAMING_CASE", "screaming_case")]
        [DataRow("NormalPascalCase", "normal_pascal_case")]
        [DataRow("camelCase", "camel_case")]
        [DataRow("camelCaseAPI", "camel_case_api")]
        [DataRow("IOStreamAPIForReal", "io_stream_api_for_real")]
        [DataRow("OnceUponATime", "once_upon_a_time")]

        public void ConvertsCorrectly(string input, string expected)
        {
            SpanFastNamingPolicy.ConvertName(input).Should().Be(expected);
        }
    }
}