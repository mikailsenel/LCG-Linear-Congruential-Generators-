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
