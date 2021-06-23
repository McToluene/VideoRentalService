using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VideoRental.Data;
using VideoRental.Interfaces;
using VideoRental.API.ViewModels;
using VideoRental.API.ViewModels.Video;

namespace VideoRental.Services
{
  public class VideoService : IVideoService
  {
    private readonly ApplicationDbContext _dbContext;
    private readonly ILogger _logger;

    public VideoService(ApplicationDbContext applicationDbContext, ILogger<VideoService> logger)
    {
      _dbContext = applicationDbContext;
      _logger = logger;
    }

    public async Task<Tuple<List<Video>, int>> GetList(PaginationFilter validFilter)
    {
      List<Video> videos = new();
      int count = 0;

      try
      {
        count = await _dbContext.Videos.CountAsync();
        videos = await _dbContext.Videos
            .Include(x => x.Type)
            .Select(x => new Video { Genre = x.Genre, Title = x.Title, Type = x.Type.Type })
            .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
            .Take(validFilter.PageSize)
            .ToListAsync();
      }
      catch (Exception ex)
      {
        _logger.LogError("Failed to get videos", ex.Message);
      }

      return new Tuple<List<Video>, int>(videos, count);
    }

    public async Task<VideoPrice> GetPrice(Detail detail)
    {
      VideoPrice videoPrice = new();

      try
      {
        var video = await _dbContext.Videos
            .Include(x => x.Type)
            .Where(x => x.Title.ToLower().Equals(detail.Title.ToLower()))
            .SingleOrDefaultAsync();

        if (video != null)
        {
          videoPrice.Days = detail.Days;
          videoPrice.Name = detail.Name;
          videoPrice.Title = detail.Title;
          videoPrice.Price = CalculatePrice(video, detail.Days);
        }

      }
      catch (Exception ex)
      {
        _logger.LogError("Failed to get price", ex.Message);
      }

      return videoPrice;
    }

    private static decimal CalculatePrice(Entities.Video video, int days)
    {
      decimal price = video.Type.Rate * days;

      if (video.Type.Type.Equals("Children’s Movie"))
        price += (video.MaximumAge / 2);

      if (video.Type.Type.Equals("New Release"))
        price -= video.Year;

      return price;
    }
  }
}
