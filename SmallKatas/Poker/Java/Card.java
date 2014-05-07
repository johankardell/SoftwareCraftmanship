public class Card
{
	private int value;
	private SuitEnum suit;

	public Card(int value, SuitEnum suit){
		this.value = value;
		this.suit = suit;
	} 

	public int getValue(){
		return this.value;
	}

	public SuitEnum getSuit(){
		return this.suit;
	}

}


