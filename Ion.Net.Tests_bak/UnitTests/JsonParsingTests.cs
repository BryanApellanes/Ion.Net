using FluentAssertions;
using Ion.Net;
using Newtonsoft.Json.Linq;
using Xunit;

namespace Ion.Net.Tests.UnitTests
{
    public class JsonParsingTests
    {
        [Fact]
        public void JsonArrayParsesAsJArray()
        {
            string arrayJson = @"[
                {
                    ""name"": ""firstName""
                },
                {
                    ""name"": ""lastName""
                }
            ]";

            arrayJson.IsJsonArray(out JArray jArray).Should().BeTrue();
            jArray.Should().NotBeNull();
            jArray.Should().BeOfType<JArray>();
        }

        [Fact]
        public void ObjectArrayParsesAsJArray()
        {
            object[] array = new[] { new { name = "user" }, new { name = "baloney" } };
            string json = array.ToJson();

            json.IsJsonArray(out JArray jArray).Should().BeTrue();
            jArray.Count.Should().Be(2);
        }
    }
}
