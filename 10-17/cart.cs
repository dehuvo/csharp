using System;
using System.Collections.Generic;

class Goods {
  public int goodsno { get; set; }
  public string gname { get; set; }
  public int danga { get; set; }

  public Goods(int goodsno, string gname, int danga) {
    this.goodsno = goodsno;
    this.gname = gname;
    this.danga = danga;
  }

  public override String ToString() {
    return goodsno + " : " + gname + ":" + danga;
  }
}

class Cart {
  public Goods goods { get; set; }
  public int count { get; set; }
  public int sum { get { return goods.danga * count; } }

  public Cart(Goods goods, int count) {
    this.goods = goods;
    this.count = count;
  }

  public override String ToString() {
    return goods + " : " + count + " : " + sum;
  }
}

class CartTest {
  static void Main() {
    Goods g1 = new Goods(1001, "볼펜", 2000);
    Goods g2 = new Goods(1002, "연필", 500);
    Goods g3 = new Goods(1003, "딸기", 6000);

    SortedList<int, Cart> carts = new SortedList<int, Cart>();
    carts.Add(1, new Cart(g1, 2));
    carts.Add(2, new Cart(g2, 3));
    carts.Add(3, new Cart(g3, 2));

    foreach (KeyValuePair<int, Cart> cart in carts) {
      Console.WriteLine(cart.Key + " : " + cart.Value);
    }
  }
}