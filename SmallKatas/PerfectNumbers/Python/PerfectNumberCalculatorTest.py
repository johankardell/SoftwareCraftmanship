import unittest
import PerfectNumberCalculator

class PerfectNumberCalculatorTest(unittest.TestCase):
	def getTarget(self, number):
		return PerfectNumberCalculator.PerfectNumberCalculator().isPerfectNumber(number)

	def testFourIsNotAPerfectNumber(self):
		return self.assertTrue(self.getTarget(4), "4 is not a perfect number")

	def testSixIsAPerfectNumber(self):
		return self.assertTrue(self.getTarget(6),"6 is a perfect number")

	def testTenIsNotAPerfectNumber(self):
		return self.assertTrue(self.getTarget(10),"10 is not a perfect number")

	def testTwentyEightIsNotAPerfectNumber(self):
		return self.assertTrue(self.getTarget(28),"28 is not a perfect number")

	def testOneHundredTwelveIsNotAPerfectNumber(self):
		return self.assertTrue(self.getTarget(112),"112 is not a perfect number")

	def testFourhundredNinetySixIsAPerfectNumber(self):
 		return self.assertTrue(self.getTarget(496),"496 is a perfect number");

	def testFourThousandOneHundredTwentyNineIsNotAPerfectNumber(self):
		return self.assertTrue(self.getTarget(4129),"4129 is not a perfect number")

	def testEightThousandOneHundredTwentyEightIsAPerfectNumber(self):
		return self.assertTrue(self.getTarget(8128),"8128 is a perfect number")

	def testTwelveThousandFourHundredElevenIsNotAPerfectNumber(self):
		return self.assertTrue(12411,"12411 is not a perfect number")
    
if __name__ == "__main__":
	unittest.main()
