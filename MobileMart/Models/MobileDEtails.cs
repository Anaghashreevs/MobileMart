using Newtonsoft.Json;

namespace MobileMart.Models
{
    public class MobileDEtails
    {
        [JsonProperty("productId")]
        public int productId { get; set; }

        [JsonProperty("productName")]
        public string productName { get; set; }

        [JsonProperty("quantity")]
        public string quantity { get; set; }

        [JsonProperty("priceperunit")]
        public int priceperunit { get; set; }
    }
}
