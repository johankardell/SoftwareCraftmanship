public class PokerCalculator{
	private Card [] cards;

	public PokerCalculator(Card [] cards){
		this.cards = cards;
	}

	public PokerResult Calculate(){
		return new PokerResult(PokerResultEnum.Pair,2);
	}
}