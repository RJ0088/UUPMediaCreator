﻿// Generated by Xamasoft JSON Class Generator
// http://www.xamasoft.com/json-class-generator

using System.Text.Json.Serialization;

namespace Microsoft.StoreServices.DisplayCatalog.Product
{
    public class FulfillmentData
    {
        [JsonPropertyName("ProductId")]
        public string ProductId;

        [JsonPropertyName("WuBundleId")]
        public string WuBundleId;

        [JsonPropertyName("WuCategoryId")]
        public string WuCategoryId;

        [JsonPropertyName("PackageFamilyName")]
        public string PackageFamilyName;

        [JsonPropertyName("SkuId")]
        public string SkuId;

        [JsonPropertyName("Content")]
        public object Content;
    }
}