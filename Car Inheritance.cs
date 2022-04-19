using System;

public abstract class Car
{
 protected virtual int color {get{return 0;}}
 protected virtual int make{get{return 0;}}

 public void Printcolor()
 {
     Console.WriteLine(
         string.Format(" -  -Color is {0}",
         this.color));
 }
 public void printMake()
 {
     Console.WriteLine(
         string.Format(" - Make is {0}",
         this.make));
 }
}

public class Insert : Car
{
    protected override int color { get{ return 1;}}
    protected override int make { get{return 1;}}
    public virtual void color()
    {
        Console.WriteLine(String.Format(" -Color is black {0}", this.color));
    }
    public virtual void make()
    {
        Console.WriteLine(String.Format(" -Make is Chevy {0}", this.make));
    }
    public void carnoise()
    {
        Console.WriteLine("vroom vroom");
    }
    public void Speed()
    {
        Console.WriteLine(" - Max speed is 160");
    }
    public void Doors()
    {
        Console.WriteLine(" - 4 doors");
    }
    public void MPG()
    {
        Console.WriteLine(" - MPG is 30");
    }
}
}

public class Truck : Insert
{
    protected override int color { get { return 3; } }
    protected override int make { get{return 5;}}
    public virtual void color()  
    { 
        Console.WriteLine(String.Format(" -Color is red {0}", this.color));         
    } 
    public virtual void make()  
    { 
        Console.WriteLine(String.Format(" -Make is Dodge {0}", this.make));         
    }
    public void trucknoise()
    {
        Console.WriteLine("purr purr");
    }
    public void Speed()
    {
        Console.WriteLine(" - Max speed is 120");
    }
    public void Doors()
    {
        Console.WriteLine(" - 2 doors");
    }
    public void MPG()
    {
        Console.WriteLine(" - MPG is 14");
    }
}
public class Van : Insert
{
    protected override int color { return 4; } }
    protected override int make {get{return 2;}}
    public virtual void color()   
    { 
        Console.WriteLine(String.Format(" - Color is blue {0}", this.color));         
    } 
    public virtual void make()  
    { 
        Console.WriteLine(String.Format(" - Make is Ford {0}", this.make));         
    }
    public void vannoise()
    {
        Console.WriteLine("zoom zoom");
    }
    public void Speed()
    {
        Console.WriteLine(" - Max speed is 140");
    }
    public void Doors()
    {
        Console.WriteLine(" - 2 doors");
    }
    public void MPG()
    {
        Console.WriteLine(" - MPG is 20");
    }
}


public class Valet
{
    static void Main(string[] args)
    {
    Car car1 = new Car();
    Console.WriteLine("Your car has arrived");
        car1.color();
        car1.make();
        car1.carnoise();
        car1.Speed();
        car1.Doors();
        car1.MPG();

    Truck car2 = new Truck();
    Console.WriteLine("Your truck has arrived");
        car2.color();
        car2.make();
        car2.trucknoise();
        car2.Speed();
        car2.Doors();
        car2.MPG();

    Van car3 = new Van();
    Console.WriteLine("Your van has arrived");
        car3.color();
        car3.make();
        car3.vannoise();
        car3.Speed();
        car3.Doors();
        car3.MPG();
    }
}