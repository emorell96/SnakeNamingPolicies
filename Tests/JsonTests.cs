using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass]
    public class JsonTests
    {
        public static string ExpectedJson = "{\"Name\":\"My name\"}";

        [TestMethod]
        public void TestOptionalParamater()
        {
            var dto = new ExampleDto
            {
                Name = "My name",
                Optional = null
            };

            var json = JsonSerializer.Serialize<ExampleDto>(dto, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
            });
            json.Should().Be(ExpectedJson);

            var deserializedJson = JsonSerializer.Deserialize<ExampleDto>(json);

            deserializedJson.Should().BeEquivalentTo(dto);

        }
    }
}
