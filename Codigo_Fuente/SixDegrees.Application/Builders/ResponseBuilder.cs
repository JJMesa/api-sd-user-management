using System.Collections.Generic;
using System.Net;
using SixDegrees.Application.Commons;
using SixDegrees.Application.Wrappers;

namespace SixDegrees.Application.Builders
{
    public static class ResponseBuilder<T>
    {
        public static JsonResponse<T> Ok(T data)
        {
            return new JsonResponse<T>() { HttpCode = HttpStatusCode.OK, Ok = true, Data = data };
        }

        public static JsonResponse<T> Created(T data)
        {
            return new JsonResponse<T>() { HttpCode = HttpStatusCode.Created, Ok = true, Data = data };
        }

        public static JsonResponse<T> NoContent()
        {
            return new JsonResponse<T>() { HttpCode = HttpStatusCode.NoContent, Ok = true };
        }

        public static JsonResponse<T> NotFound()
        {
            return new JsonResponse<T>() { HttpCode = HttpStatusCode.NotFound, Ok = false, Errors = new List<string> { ErrorMessages.NotFound } };
        }

        public static JsonResponse<T> BadRequest(string error)
        {
            return new JsonResponse<T>() { HttpCode = HttpStatusCode.BadRequest, Ok = false, Errors = new List<string> { error } };
        }
    }
}
