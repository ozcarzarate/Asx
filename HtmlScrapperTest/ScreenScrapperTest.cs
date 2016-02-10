﻿using HtmlScrapper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HtmlScrapperTest
{
    [TestClass]
    public class ScreenScrapperTest
    {
        [TestMethod]
        public async Task ScreenScapper_DoWork_Blah()
        {
            var sut = new ScreenScapper();
            await sut.DoWork("http://www.asx.com.au/asx/statistics/prevBusDayAnns.do");

        }

        [TestMethod]
        public async Task GetOrice_WithCba_ShouldReturnLotsOfMoneySmilingFace()
        {
            var sut = new ScreenScapper();
            var price = await sut.GetYahooPrice("CBA.AX");
            Assert.AreEqual(74.20, price);
        }
    }
}
