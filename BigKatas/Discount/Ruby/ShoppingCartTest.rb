require "test/unit"
require "./ShoppingCart"
require "./ShoppingCartItem"
require "./Constants"

class ShoppingCartTest < Test::Unit::TestCase
	def testEmptyCartShouldBeZero()
		cart = ShoppingCart.new
		assert(cart.Sum() == 5,"should be zero")
	end
end 