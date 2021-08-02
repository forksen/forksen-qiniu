using Newtonsoft.Json;
namespace Qiniu.CDN
{
    /// <summary>
    /// 查询带宽-请求
    /// </summary>
    public class BandwidthRequest
    {
        /// <summary>
        /// 起始日期，例如2016-09-01
        /// </summary>
        [JsonProperty("startDate")]
        public string StartDate { get; set; }

        /// <summary>
        /// 结束日期，例如2016-09-10
        /// </summary>
        [JsonProperty("endDate")]
        public string EndDate { get; set; }

        /// <summary>
        /// 时间粒度((取值：5min ／ hour ／day))
        /// </summary>
        [JsonProperty("granularity")]
        public string Granularity { get; set; }

        /// <summary>
        /// 域名列表，以西文半角分号分割
        /// </summary>
        [JsonProperty("domains")]
        public string Domains { get; set; }
    }
}
