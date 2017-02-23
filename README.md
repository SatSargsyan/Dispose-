# Operator Overloading
####Most operators in C# can be overloaded, meaning they can be redefined for custom actions.
####For example, you can redefine the action of the plus (+) operator in a custom class.
Consider the Box class that has Height and Width properties:
```C#
class Box {
  public int Height {get; set;}
  public int Width {get; set;}
  public Box(int h, int w) {
    Height = h;
    Width = w;
  }
}
static void Main(string[] args) {
  Box b1 = new Box(14, 3);
  Box b2 = new Box(5, 7);
}
```
####We would like to add these two Box objects, which would result in a new, bigger Box.
So, basically, we would like the following code to work:
```C#
 Box b3 = b1 + b2;
```
####The Height and Width properties of object b3 should be equal to the sum of the corresponding properties of the b1 and b2 objects.

####Overloaded operators are methods with special names, where the keyword operator is followed by the symbol for the operator being defined. 
####Similar to any other method, an overloaded operator has a return type and a parameter list.
####For example, for our Box class, we overload the + operator:
```C#
public static Box operator+ (Box a, Box b) {
  int h = a.Height + b.Height;
  int w = a.Width + b.Width;
  Box res = new Box(h, w);
  return res;
}
```
####The method above defines an overloaded operator + with two Box object parameters and returning a new Box object whose Height and Width properties equal the sum of its parameter's corresponding properties.
###Additionally, the overloaded operator must be static.
####Putting it all together:
```C#
class Box {
  public int Height { get; set; }
  public int Width { get; set; }
  public Box(int h, int w) {
    Height = h;
    Width = w;
  }
  public static Box operator+(Box a, Box b) {
    int h = a.Height + b.Height;
    int w = a.Width + b.Width;
    Box res = new Box(h, w);
    return res;
  }
}
static void Main(string[] args) {
  Box b1 = new Box(14, 3);
  Box b2 = new Box(5, 7);
  Box b3 = b1 + b2;

  Console.WriteLine(b3.Height); //19
  Console.WriteLine(b3.Width); //10
}
```
####All arithmetic and comparison operators can be overloaded. For instance, you could define greater than and less than operators for the boxes that would compare the Boxes and return a boolean result. Just keep in mind that when overloading the greater than operator, the less than operator should also be defined.
