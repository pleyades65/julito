using System.Threading;

namespace PartsUnlimited.Models
{  // cambios mayo.15.2024
    public class Request
    {
        public CancellationToken CancellationToken { get; set; }
        public int Id { get; set; }
    }
}
