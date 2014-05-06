import java.util.ArrayList;
import java.util.List;

/**
 * Created with IntelliJ IDEA.
 * User: cno
 * Date: 2014-05-06
 * Time: 19:47
 * To change this template use File | Settings | File Templates.
 */
public class ShoppingCart {
    List<ShoppingCartItem> items;
    public ShoppingCart(){
        items = new ArrayList<ShoppingCartItem>();
    }

    public double sum()
    {
        return 0;
    }
}


