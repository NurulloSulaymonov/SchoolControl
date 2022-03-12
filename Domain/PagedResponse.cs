using System;
using System.Net;

namespace Domain
{
    public class PagedResponse<T>  : GenericResponse<T> 
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public Uri FirstPage { get; set; }
        public Uri LastPage { get; set; }
        public int TotalPages { get; set; }
        public int TotalRecords { get; set; }
        public Uri NextPage { get; set; }
        public Uri PreviousPage { get; set; }
        public PagedResponse(HttpStatusCode code, T data, int pageNumber, int pageSize)
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Payload = data;
            this.Message = null;
            this.Code = (int)code;
        }
    }
}