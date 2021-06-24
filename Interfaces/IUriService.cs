using System;
using VideoRental.API.ViewModels;

namespace VideoRental.Interfaces
{
    public interface IUriService
    {
        Uri GetPageUri(PaginationFilter filter, string route);
    }
}
