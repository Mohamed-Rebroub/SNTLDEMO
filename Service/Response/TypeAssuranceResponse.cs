using AssuranceSNTL.Models;

namespace AssuranceSNTL.Service.Response
{
    public class TypeAssuranceResponse
    {
        public string Message { get; set; } = string.Empty;
        public TypeAssurance? TypeAssurance { get; set; }
    }
}
