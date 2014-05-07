import junit.framework.TestCase;

public class PokerCalculatorTest extends TestCase  {
	
	public void testForPair(){
		Cards cards = new Card[3];
		cards[0] = new Card(2,SuitEnum.Hearts);
		cards[1] = new Card(2,SuitEnum.Spades);
		cards[3] = new Card(2,SuitEnum.Diamonds);

		PokerCalculator target = new PokerCalculator(cards);	
		PokerResult actual = target.Calculate();

		assertEquals("should be pair",PokerResultEnum.Pair,actual.getResult());
	}

	public void testForThreeOfAKind()
	{
        Cards cards = new Card[3];
        cards[0] = new Card(1, SuitEnum.Hearts);
        cards[1] = new Card(1,SuitEnum.Spades);
        cards[2] = new Card(1,SuitEnum.Diamonds);

		PokerCalculator target = new PokerCalculator(cards);	
        PokerResult actual = target.Calculate();
        assertEquals("should be three of a kind",PokerResultEnum.ThreeOfAKind, actual.getResult());	
	}

	public void testForFullHouse()
	{
		Cards cards = new Card[3];
		cards[0] = new Card(1,SuitEnum.Hearts);
        cards[1] = new Card(1,SuitEnum.Spades);
        cards[2] = new Card(1,SuitEnum.Diamonds);
        cards[3] = new Card(13,SuitEnum.Diamonds);
        cards[4] = new Card(13,SuitEnum.Spades); 

        PokerCalculator target = PokerCalculator(cards);	
        PokerResult actual = target.Calculate();
        assertEquals("should be full house in aces and kings",PokerResultEnum.FullHouse, actual.getResult());
    }
}