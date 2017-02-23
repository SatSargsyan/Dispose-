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
