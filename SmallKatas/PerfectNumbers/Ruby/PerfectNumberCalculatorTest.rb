require "test/unit"
require "./PerfectNumberCalculator"

class TestPerfectNumbers < Test::Unit::TestCase
    def testFourIsNotAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(4)

        # Assert
        assert_equal(false, actual, "4 is not a perfect number")
    end

    def testSixIsAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(6)

        # Assert
        assert(actual, "6 is a perfect number")
    end

    def testTenIsNotAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(10)

        #Assert
        assert_equal(false,actual, "10 is not a perfect number")
    end

    def testTwentyIsNotAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(20)

        # Assert
        assert_equal(false,actual, "20 is not a perfect number")
    end

    def testTwentyEightIsAPerfectNumber()
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(28)

        # Assert
        assert(actual, "28 is a perfect number")
    end

    def testOneHundredTwelveIsNotAPerfectNumber
    
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(112)

        # Assert
        assert_equal(false, actual, "112 is not a perfect number")
    end

    def testFourhundredNinetySixIsAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(496)

        # Assert
        assert(actual, "496 is a perfect number")
    end

    def testFourThousandOneHundredTwentyNineIsNotAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(4129)

        # Assert
        assert_equal(false,actual, "4129 is not a perfect number")
    end

    def testEightThousandOneHundredTwentyEightIsAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(8128)

        # Assert
        assert(actual, "8128 is a perfect number")
    end

    def testTwelveThousandFourHundredElevenIsNotAPerfectNumber
        # Arrange
        perfectNumberCalculator = PerfectNumberCalculator.new

        # Act
        actual = perfectNumberCalculator.IsPerfectNumber(12411)

        # Assert
        assert_equal(false,actual, "12411 is not a perfect number")
    end
end

