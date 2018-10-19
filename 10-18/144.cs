using System;
using System.Collections.Generic;
using System.Text;
namespace deledatetest {
  delegate void OnjDelegate(int a, int b);
  class MainApp {
    static void Plus(int a, int b) { 
      Console.WriteLine("{0} + {1} = {2}", a, b, a + b); 
    }
    static void Minus(int a, int b) { 
      Console.WriteLine("{0} - {1} = {2}", a, b, a - b); 
    }
    void Multiplication(int a, int b) { 
      Console.WriteLine("{0} * {1} = {2}", a, b, a * b); 
    }
    void Division(int a, int b) { 
      Console.WriteLine("{0} / {1} = {2}", a, b, a / b); 
    }
    
    static void Main() {
    
      MainApp m = new MainApp();
      OnjDelegate CallBack = (OnjDelegate) Delegate.Combine(
        new OnjDelegate(Plus),
        new OnjDelegate(MainApp.Minus),
        new OnjDelegate(m.Multiplication),
        new OnjDelegate(m.Division)
      );
      CallBack(4, 3);

      OnjDelegate CallBack1 = new OnjDelegate(MainApp.Plus)
                            + new OnjDelegate(MainApp.Minus)
                            + new OnjDelegate(m.Multiplication)
                            + new OnjDelegate(m.Division);
      CallBack1(40, 30);                  
    }
  }
}