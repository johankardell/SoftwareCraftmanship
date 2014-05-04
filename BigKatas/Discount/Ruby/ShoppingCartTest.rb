require "test/unit"
require "./ShoppingCart"
require "./ShoppingCartItem"
require "./Constants"

class ShoppingCartTest < Test::Unit::TestCase
	def testEmptyCartShouldBeZero()
		cart = ShoppingCart.new
		assert(cart.Sum(),"should be zero")
	end
end