import junit.framework.TestCase;

public class PerfectNumberCalculatorTest extends TestCase {
    private boolean getActual(int number){
        return new PerfectNumberCalculator().isPerfectNumber(number);
    }

    public void testFourIsNotAPerfectNumber()
    {
        assertEquals("4 is not a perfect number",false,getActual(4));
    }

    public void testSixIsAPerfectNumber()
    {
        assertEquals("6 is a perfect number",true,getActual(6));
    }

    public void testTenIsNotAPerfectNumber()
    {
        assertEquals("10 is not a perfect number",false,getActual(10));
    }

    public void testTwentyIsNotAPerfectNumber()
    {
        assertEquals("20 is not a perfect number",false,getActual(20));
    }

    public void testTwentyEightIsAPerfectNumber()
    {
        assertEquals("28 is a perfect number",true, getActual(28));
    }

    public void testOneHundredTwelveIsNotAPerfectNumber()
    {
      assertEquals("112 is not a perfect number",false, getActual(112));
    }

    public void testFourhundredNinetySixIsAPerfectNumber()
    {
        assertEquals("496 is a perfect number",true,getActual(496));
    }

    public void testFourThousandOneHundredTwentyNineIsNotAPerfectNumber()
    {
        assertEquals("4129 is not a perfect number",false,getActual(4129));
    }

    public void testEightThousandOneHundredTwentyEightIsAPerfectNumber()
    {
        assertEquals("8128 is a perfect number",true,getActual(8128));
    }

    public void testTwelveThousandFourHundredElevenIsNotAPerfectNumber()
    {
      assertEquals("12411 is not a perfect number",false,getActual(12411));
    }
}

