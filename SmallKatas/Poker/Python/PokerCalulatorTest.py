import unittest
import PokerCalculator
import Card
import PokerResultEnum
import SuitEnum

class PokerCalulatorTest(unittest.TestCase):
	def testForPair(self):
		cards = []
		cards.append(Card.Card(1,SuitEnum.Hearts))
		cards.append(Card.Card(3,SuitEnum.Spades))
		cards.append(Card.Card(1,SuitEnum.Hearts))	

		target = PokerCalculator.PokerCalculator(cards)
		actual = target.Calculate()

		self.assertTrue(actual.result == PokerResultEnum.Pair,"should be a pair")
	def testForThreeOfAKind(self):
		cards = []
		cards.append(Card.Card(7,SuitEnum.Hearts))
		cards.append(Card.Card(7,SuitEnum.Clubs))
		cards.append(Card.Card(7,SuitEnum.Clubs))

		target = PokerCalculator.PokerCalculator(cards)	
		actual = target.Calculate()

		self.assertTrue(actual.result == PokerResultEnum.ThreeOfAKind,"should be a Three of a kind")
	def testForFullHouse(self):
		cards = []
		cards.append(Card.Card(7,SuitEnum.Hearts))
		cards.append(Card.Card(7,SuitEnum.Spades))
		cards.append(Card.Card(7,SuitEnum.Hearts))

		cards.append(Card.Card(2,SuitEnum.Hearts))
		cards.append(Card.Card(2,SuitEnum.Spades))
		
		target = PokerCalculator.PokerCalculator(cards)
		actual = target.Calculate()

		self.assertTrue(actual.result == PokerResultEnum.FullHouse,"should be a full house")		

if __name__ == "__main__":
	unittest.main()
