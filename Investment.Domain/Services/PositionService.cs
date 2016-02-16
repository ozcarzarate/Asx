using System;
using System.Collections.Generic;
using Investment.Domain.Services.Interfaces;
using Investment.Domain.Interfaces;

namespace Investment.Domain.Services
{
    public class PositionService : IPositionService
    {
        private readonly IPositionRepository _positionRepository;
        private readonly IScreenScrapper _screenScrapper;
        public PositionService(IPositionRepository PositionRepository, IScreenScrapper ScreenScrapper)
        {
            _positionRepository = PositionRepository;
            _screenScrapper = ScreenScrapper;
        }

        public IEnumerable<CurrentPosition> GetCurrentPosition()
        {
            var result = new List<CurrentPosition>();
            var positions = _positionRepository.Get();
            foreach (var position in positions)
            {
                var current = (CurrentPosition)position;
                if (current.CurrencyCode == "AUD")
                {
                    current.CurrentPrice = _screenScrapper.GetYahooPrice(current.Key).Result;
                }
                else
                {
                    current.CurrentPrice = _screenScrapper.GetYahooPrice(current.Key).Result / _screenScrapper.GetYahooPrice($"AUD{current.CurrencyCode}=X").Result;
                }
                //make the calculation
                current.TotalNow = current.Quantity * current.CurrentPrice;
                current.TotalWhenBought = current.Quantity * current.PriceWhenBought;
                result.Add(current);
            }
            return result;
        }
    }
}
