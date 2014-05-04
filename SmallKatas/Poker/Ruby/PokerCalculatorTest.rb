require "test/unit"
require "./PokerCalculator"
require "./Card"
require "./Enums"

class PokerCalculatorTest < Test::Unit::TestCase
	def testForPair
		cards = []
		cards[0] = Card.new(2,SuitEnum::Hearts)
		cards[1] = Card.new(2,SuitEnum::Spades)
		cards[3] = Card.new(2,SuitEnum::Diamonds)

		target = PokerCalculator.new	
		actual = target.Calculate(cards)

		assert_equal(PokerResultEnum::Pair,actual.Result)
		assert_equal(2,actual.Value)
	end

	def testForThreeOfAKind
        cards = []
        cards[0] = Card.new(1, SuitEnum::Hearts)
        cards[1] = Card.new(1,SuitEnum::Spades)
        cards[2] = Card.new(1,SuitEnum::Diamonds)

		target = PokerCalculator.new	
        actual = target.Calculate(cards);
        assert_equal(PokerResultEnum::ThreeOfAKind, actual.Result)	
	end

	def testForFullHouse
		cards = []
		cards[0] = Card.new(1,SuitEnum::Hearts)
        cards[1] = Card.new(1,SuitEnum::Spades)
        cards[2] = Card.new(1,SuitEnum::Diamonds)
        cards[3] = Card.new(13,SuitEnum::Diamonds)
        cards[4] = Card.new(13,SuitEnum::Spades) 

        target = PokerCalculator.new	
        actual = target.Calculate(cards);
        assert_equal(PokerResultEnum::FullHouse, actual.Result)	
    end
        
end