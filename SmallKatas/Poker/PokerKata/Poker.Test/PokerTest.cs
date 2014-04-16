using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Test
{
    [TestClass]
    public class PokerTest
    {
        [TestMethod]
        public void TestForPair()
        {
            Card[] cards = new Card[]
            { 
                new Card{ SuitEnum = SuitEnum.Hearts, Value = 1},
                new Card{ SuitEnum = SuitEnum.Spades, Value = 1},
                new Card{ SuitEnum = SuitEnum.Diamonds, Value = 2} 
            };

            var actual = PokerCalculator.Calculate(cards);

            Assert.AreEqual(PokerResultEnum.Pair, actual.ResultEnum);
        }

        [TestMethod]
        public void TestForThreeOfAKind()
        {
            Card[] cards = new Card[]
            { 
                new Card{ SuitEnum = SuitEnum.Hearts, Value = 1},
                new Card{ SuitEnum = SuitEnum.Spades, Value = 1},
                new Card{ SuitEnum = SuitEnum.Diamonds, Value = 1} 
            };

            var result = PokerCalculator.Calculate(cards);

            Assert.AreEqual(PokerResultEnum.ThreeOfAKind, result.ResultEnum);
        }

        [TestMethod]
        public void TestForFullHouse()
        {
            Card[] cards = new Card[]
            { 
                new Card{ SuitEnum = SuitEnum.Hearts, Value = 1},
                new Card{ SuitEnum = SuitEnum.Spades, Value = 1},
                new Card{ SuitEnum = SuitEnum.Diamonds, Value = 1},
                new Card{ SuitEnum = SuitEnum.Diamonds, Value = 13} ,
                new Card{ SuitEnum = SuitEnum.Spades, Value = 13} 
            };

            var result = PokerCalculator.Calculate(cards);

            Assert.AreEqual(PokerResultEnum.FullHouse, result.ResultEnum);
        }
    }
}
