class ShoppingCart
	attr_accessor :Items

	def initialize()
		@Items  = Array.new
	end
	def Add(item)
		@Items.push(item)
	end
	def Sum
		0
	end
end