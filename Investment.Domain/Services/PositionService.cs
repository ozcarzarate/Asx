using System;
using System.Collections.Generic;
using Investment.Domain.Services.Interfaces;
using Investment.Domain.Interfaces;
using AutoMapper;

namespace Investment.Domain.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IScreenScrapper _screenScrapper;
        public PositionService(IPositionRepository positionRepository, IScreenScrapper screenScrapper)
        {
            _positionRepository = positionRepository;
            _screenScrapper = screenScrapper;
        }

        public IEnumerable<CurrentPosition> GetCurrentPosition()
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Position, CurrentPosition>());
            var mapper = config.CreateMapper();
            var result = new List<CurrentPosition>();
            var positions = _positionRepository.Get();
            foreach (var position in positions)
            {
                var current = mapper.Map<CurrentPosition>(position);
                if (current.CurrencyCode == "AUD")
                {
                    current.CurrentPrice = _screenScrapper.GetYahooPrice($"{current.Key}.AX").Result;
                }
                else
                {
                    current.CurrentPrice = _screenScrapper.GetYahooPrice(current.Key).Result / _screenScrapper.GetYahooPrice($"AUD{current.CurrencyCode}=X").Result;
                }
                //make the calculation
                current.TotalNow = current.Quantity * current.CurrentPrice;
                current.TotalWhenBought = current.Quantity * current.PriceWhenBought;
                current.DaysSinceBought = (int)(DateTime.Now - current.DateWhenBought).TotalDays;
                current.DifferenceMoney = current.TotalNow - current.TotalWhenBought;
                current.DifferencePercentage = (current.DifferenceMoney / current.TotalWhenBought) * 100;
                result.Add(current);
            }
            return result;
        }
    }
}
