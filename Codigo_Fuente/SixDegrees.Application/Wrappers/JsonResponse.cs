using System.Collections.Generic;
using System.Net;

namespace SixDegrees.Application.Wrappers
{
    public class JsonResponse<T>
    {
        public HttpStatusCode HttpCode { get; set; }
        public bool Ok { get; set; }
        public T Data { get; set; }
        public IEnumerable<string> Errors { get; set; } = null!;
    }
}
