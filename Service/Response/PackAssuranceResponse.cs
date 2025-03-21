using AssuranceSNTL.Models;

namespace AssuranceSNTL.Service.Response
{
    public class PackAssuranceResponse
    {
        public string Message { get; set; } = string.Empty;
        public PackAssurance? PackAssurance { get; set; }
    }
}
