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
[![](https://i.ibb.co/JpXtmYy/Ads-z2.png)](https://i.ibb.co/JpXtmYy/Ads-z2.png)
```csharp
	public bool Control()
        {
            bool success = false;
            int i = 0;
            while (!success && i <= m)
            {
                if (Math.Pow(2,i) == m)
                    success = true;
                i++;
            }

            if (c == 0)
                success = false;

            int smallNumber = a < m ? a : m;
            for (i = 2; i <=smallNumber; i++)
            {
                if (a % i == 0 && m % i == 0)
                    success = false;
            }

            if ((a - 1) % 4 != 0)
                success = false;

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
