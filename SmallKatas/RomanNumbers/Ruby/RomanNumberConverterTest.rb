require "./RomanNumberConverter"
require "test/unit"

class RomanNumberConverterTest < Test::Unit::TestCase
	def testOneReturnsI
		romanNumberConverter = RomanNumberConverter.new

        # Act
        actual = romanNumberConverter.Convert(1)

        # Assert
		assert_equal("I",actual)
	end


    def testTwoReturnsII()
        
        # Arrange
        romanNumberConverter = RomanNumberConverter.new

        # Act
        actual = romanNumberConverter.Convert(2)

        # Assert
        assert_equal("II", actual)
    end

    def testFourReturnsIV()
        
        # Arrange
        romanNumberConverter = RomanNumberConverter.new

        # Act
        actual = romanNumberConverter.Convert(4)

        # Assert
        assert_equal("IV", actual)
    end

    def testFiveReturnsV()
        # Arrange
        romanNumberConverter = RomanNumberConverter.new
        # Act
        actual = romanNumberConverter.Convert(5)

        # Assert
        assert_equal("V", actual)
    end

    def testSixReturnsVI()
        # Arrange
        romanNumberConverter = RomanNumberConverter.new

        # Act
        actual = romanNumberConverter.Convert(6)

        # Assert
        assert_equal("VI", actual)
    end
        
	def testNineReturnsIX()
        # Arrange
        romanNumberConverter = RomanNumberConverter.new

        # Act
        actual = romanNumberConverter.Convert(9)

        # Assert
        assert_equal("IX", actual)
    end    
	def testTenReturnsX()
        # Arrange
        romanNumberConverter = RomanNumberConverter.new

        # Act
        actual = romanNumberConverter.Convert(10)

        # Assert
        assert_equal("X", actual)
    end
end