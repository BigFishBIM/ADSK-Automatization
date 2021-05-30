using System.ComponentModel;
using Newtonsoft.Json;

namespace AdskTemplateMepTools.Commands.CopyADSK.Operations
{
    public class CopyAreaOperation : IOperation
    {
       public CopyAreaOperation(string parameter, string reserveParameter)
        {
            Parameter = parameter;
            ReserveParameter = reserveParameter;
            Reserve = 1;
        }

        [JsonConstructor]
        public CopyAreaOperation(string parameter, double reserve, string reserveParameter)
        {
            Parameter = parameter;
            Reserve = reserve;
            ReserveParameter = reserveParameter;
        }

        public Operation Name => Operation.CopyArea;
        
        [JsonProperty("Название параметра")] public string Parameter { get; }
        
        [JsonProperty("Коэффициент запаса")]
        [DefaultValue(1d)]
        public double Reserve { get; }
        
        [JsonProperty("Глобальный параметр коэффициента запаса")]
        [DefaultValue("")]
        public string ReserveParameter { get; }
    }
}