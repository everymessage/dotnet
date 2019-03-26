using System;
using everymessage.WebAPI.Json;

using Newtonsoft.Json;

using NUnit.Framework;

namespace everymessage.WebAPI.Core.Tests.Json
{

    [TestFixture]
    public class NewtonsoftJsonContractResolverTests
    {
        [Test]
        public void NewtonsoftJsonContractResolver_ExplicitNullConverter_Can_Conver()
        {
            ExplicitNullConverter converter = new ExplicitNullConverter();

            bool canConvert = converter.CanConvert(typeof(Explicit_Json_Null_Class));
            Assert.That(canConvert, Is.True);

            bool cannotConvert = converter.CanConvert(typeof(string)) == false;
            Assert.That(cannotConvert, Is.True);
        }

        [Test]
        public void NewtonsoftJsonContractResolver_RFC3339DateTimeConverter_Can_Convert()
        {
            RFC3339DateTimeConverter converter = new RFC3339DateTimeConverter();

            bool canConvertDateTime = converter.CanConvert(typeof(DateTime));
            Assert.That(canConvertDateTime, Is.True);

            bool canConvertNullableDateTime = converter.CanConvert(typeof(Nullable<DateTime>));
            Assert.That(canConvertNullableDateTime, Is.True);

            bool cannotConvert = converter.CanConvert(typeof(string)) == false;
            Assert.That(cannotConvert, Is.True);
        }

        [Test]
        public void NewtonsoftJsonContractResolver_Serialization()
        {
            TestObject tobj = new TestObject
            {
                TestDateTime = new DateTime(2018, 5, 24, 12, 05, 32)
            };

            var settings = new JsonSerializerSettings
            {
                ContractResolver = new NewtonsoftJsonContractResolver(),
                Formatting = Formatting.None
            };

            string json = JsonConvert.SerializeObject(tobj, settings);

            Assert.AreEqual("{\"TestNull\":null,\"TestDateTime\":\"2018-05-24T11:05:32.000Z\"}", json);
        }

        [JsonExplicitNull]
        public class Explicit_Json_Null_Class
        {
            public string Name { get; set; }
        }

        public class TestObject
        {
            public Explicit_Json_Null_Class TestNull { get; set; }

            public DateTime TestDateTime { get; set; }
        }
    }

}
