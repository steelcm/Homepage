using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Net.Http.Headers;
using System.Web.Http;

namespace steelcm.App_Start
{
    public class WebApiConfig
    {
        public static void Register(HttpConfiguration configuration)
        {
            // Default to JSON on normal requests
            configuration.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
            // Format JSON
            JsonSerializerSettings jsonSetting = new JsonSerializerSettings();
            jsonSetting.Converters.Add(new StringEnumConverter());
            jsonSetting.Converters.Add(new DateTimeConverter());
            jsonSetting.NullValueHandling = NullValueHandling.Ignore;
            configuration.Formatters.JsonFormatter.SerializerSettings = jsonSetting;

            configuration.Routes.MapHttpRoute("API Default", "api/{controller}/{id}", new {id = RouteParameter.Optional});
        }
    }

    public class DateTimeConverter : DateTimeConverterBase
    {

        public override object ReadJson(JsonReader reader, System.Type objectType, object existingValue, JsonSerializer serializer)
        {
            return DateTime.Parse(reader.Value.ToString());
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            var date = (DateTime)value;
            if(date.TimeOfDay.Ticks == 0)
            {
                writer.WriteValue(((DateTime)value).ToString("dd/MM/yyyy"));
            }
            else
            {
                writer.WriteValue(((DateTime)value).ToString("dd/MM/yyyy hh:mm"));
            }
            
        }
    }
}