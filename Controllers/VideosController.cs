using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Threading.Tasks;
using VideoRental.API.Helper;
using VideoRental.Interfaces;
using VideoRental.API.ViewModels.Response;
using VideoRental.API.ViewModels.Video;
using VideoRental.API.ViewModels;

namespace VideoRental.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideosController : ControllerBase
    {
        private readonly IVideoService _videoService;
        private readonly IUriService _uriService;

        public VideosController(IVideoService video, IUriService uriService)
        {
            _videoService = video;
            _uriService = uriService;
        }

        [HttpGet]
        [SwaggerResponse(200, "Paginated video list.", typeof(PagedResponse<List<Video>>))]
        public async Task<IActionResult> GetList([FromQuery] PaginationFilter filter)
        {
            var route = Request.Path.Value;
            PaginationFilter validFilter = new(filter.PageNumber, filter.PageSize);
            var data = await _videoService.GetList(validFilter);

            PagedResponse<List<Video>> pagedResponse = PaginationHelper.CreatePagedReponse(data.Item1, validFilter, data.Item2, _uriService, route);
            pagedResponse.Message = "Videos fetched successfully!";
            return Ok(pagedResponse);
        }

        [HttpPost]
        [SwaggerResponse(200, "A video price", typeof(Response<VideoPrice>))]
        public async Task<IActionResult> GetPrice(Detail detail)
        {
            VideoPrice price = await _videoService.GetPrice(detail);
            Response<VideoPrice> response = new(price);
            response.Message = "Price fetched successfully!";

            return Ok(response);
        }
    }
}
