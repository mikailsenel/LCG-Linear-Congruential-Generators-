# LCG Generator (Linear Congruential Generators)
## Mathematical Operation
```
/*
   *      z(k+1)=(a*z(k)+c) mod(m)	a=multiplier
   *      u(k)=z(k)/m			c=increment
   * 					m=amplitude
*/
 ```
## Initial Method
```csharp
public Generator(int multiplier, int increment, int amplitude, int initialValue)
        {
            ....
	    ....
        }
```
## Use Of
```csharp
	Generator generator = new Generator(5,3,16,7);
	double[] randomArray = generator.LCG_Generators();
```
## Full Periyot Control

```csharp
	public bool Control()
        {
            bool success = true;

            if (m % 2 != 0)
                success = false;
            if (c == 0)
                success = false;
            if ((a - 1) % 4 != 0)
                success = false;
            int smallNumber = m < c ? m : c;
            for (int i = 2; i < smallNumber; i++)
            {
                if (c % i == 0 && m % i == 0)
                    success = false;
            }
            return success;
        }
```
#### CALL
```csharp
	bool status = generator.Control();
        Console.WriteLine(status
                ? "\nFull Periyot"
                : "\nNot Full Periyot");
```
