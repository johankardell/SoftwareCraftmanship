import unittest
import PerfectNumberCalculator

class PerfectNumberCalculatorTest(unittest.TestCase):
	
	def testFourIsNotAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(4), "4 is not a perfect number")

	def testSixIsAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(6),"6 is a perfect number")

	def testTenIsNotAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(10),"10 is not a perfect number")

	def testTwentyEightIsNotAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(28),"28 is not a perfect number")

	def testOneHundredTwelveIsNotAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(112),"112 is not a perfect number")

	def testFourhundredNinetySixIsAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(496),"496 is a perfect number")

	def testFourThousandOneHundredTwentyNineIsNotAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(4129),"4129 is not a perfect number")

	def testEightThousandOneHundredTwentyEightIsAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(8128),"8128 is a perfect number")

	def testTwelveThousandFourHundredElevenIsNotAPerfectNumber(self):
		target = PerfectNumberCalculator.PerfectNumberCalculator()

		return self.assertTrue(target.isPerfectNumber(12411),"12411 is not a perfect number")
    
if __name__ == "__main__":
	unittest.main()
