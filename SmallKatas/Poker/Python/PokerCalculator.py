import PokerResult
import PokerResultEnum

class PokerCalculator:
	def __init__(self,cards):
		self.cards = cards

	def Calculate(self):
		return PokerResult.PokerResult(PokerResultEnum.Pair,1)