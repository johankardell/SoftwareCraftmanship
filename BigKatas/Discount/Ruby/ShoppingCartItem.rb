class ShoppingCartItem
	attr_accessor :Name,
				  :Category,
				  :Price
    def initialize(name,category,price)
    	@Name = name
    	@Category = category
    	@Price = price
    end
end