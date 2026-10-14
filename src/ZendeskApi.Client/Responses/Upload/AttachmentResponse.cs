using Newtonsoft.Json;
using ZendeskApi.Client.Models;

namespace ZendeskApi.Client.Responses
{
    [JsonObject]
    public class AttachmentResponse
    {
        [JsonProperty("attachment")]
        public Attachment Attachment { get; set; }
    }
}
