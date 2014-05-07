public class PokerResult
{
	private PokerResultEnum resultEnum;
	private int value;

	public PokerResult(PokerResultEnum result, int value)
	{
		this.resultEnum = result;
		this.value = value;
	}

	public PokerResultEnum getResult(){
		return this.resultEnum;
	}

	public int getValue(){
		return this.value;
	}
}