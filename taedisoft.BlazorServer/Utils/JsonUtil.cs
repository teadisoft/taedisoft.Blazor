using Newtonsoft.Json;

namespace taedisoft.BlazorServer.Utils
{
    /// <summary>
    /// Json Data Serialize/Deserialize
    /// </summary>
    public class JsonUtil
    {
        /// <summary>
        /// Serialize (직렬화)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetJsonString<T>(List<T>? list)
        {
            return JsonConvert.SerializeObject(list);
        }

        /// <summary>
        /// DeSerialize (역직렬화)
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <returns></returns>
        public static List<T>? GetJsonModel<T>(string json)
        {
            return JsonConvert.DeserializeObject<List<T>>(json);
        }
    }
}
