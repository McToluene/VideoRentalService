using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoRental.API.ViewModels;
using VideoRental.API.ViewModels.Video;

namespace VideoRental.Interfaces
{
    public interface IVideoService
    {
        Task<Tuple<List<Video>, int>> GetList(PaginationFilter validFilter);
        Task<VideoPrice> GetPrice(Detail price);
    }
}

