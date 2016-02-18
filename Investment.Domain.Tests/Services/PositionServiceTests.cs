﻿using HtmlScrapper;
using Investment.Domain.Services;
using Investment.Persistance;
using Investment.Persistance.Repositories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Investment.Domain.Tests.Services
{
    [TestClass]
    public class PositionServiceTests
    {
        [TestMethod]
        public void Integration_GetCurrentPosition_ShouldReturnEnumerableOfPositions()
        {
            var screenScrapper = new ScreenScapper();
            var context = new InvestmentDbContextProvider();
            var positionRepository = new PositionRepository(context);
            var sut = new PositionService(positionRepository, screenScrapper);

            var actual = sut.GetCurrentPosition();
            var asd = 1;
        }
    }
}
