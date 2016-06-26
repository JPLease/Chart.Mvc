using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Chart.Mvc.Extensions
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// The json serializer settings.
        /// </summary>
        private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            NullValueHandling = NullValueHandling.Ignore
        };

        /// <summary>
        /// The to json.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <typeparam name="T">
        /// </typeparam>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public static string ToJson<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj, JsonSerializerSettings);
        }

        public static string ToCamelCaseString<T>(this T obj)
        {
            var text = obj.ToString();
            return text.Substring(0, 1).ToLower() + text.Substring(1);
        }
    }
}
