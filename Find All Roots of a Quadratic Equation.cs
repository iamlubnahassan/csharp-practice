float a,b,c, x1 ,x2, discriminant , imaginarypart ,realpart;
Console.WriteLine("enter three cofficient");
string[] inputValues = Console.ReadLine().Split(' ');

if(inputValues.Length == 3 &&  
float.TryParse (inputValues[0], out a)&&
float.TryParse (inputValues[1], out b)&&
float.TryParse (inputValues[2], out c))


{
    discriminant= b*b - 4*a*c;
    if( discriminant > 0){
        x1 = (-b + (float)Math.Sqrt(discriminant)) / (2*a);
        x2 = (-b - (float)Math.Sqrt(discriminant)) / (2*a);
        Console.WriteLine("Roots are real and different");
        Console.WriteLine("x1"+x1);
        Console.WriteLine("x2"+x2);
    }
    else if(discriminant==0){
        Console.WriteLine("roots are real and same");
         x1 = -b/(2*a);
         Console.WriteLine ("x1="+x1 );
    }
    else{
        float realPart,imaginaryPart;
        realPart = -b / (2 * a);
        imaginaryPart = (float)Math.Sqrt(-discriminant) / (2 * a);
        Console.WriteLine("Roots are complex and different");
        Console.WriteLine("x1: " + realPart + " + i" + imaginaryPart);
        Console.WriteLine("x2: " + realPart + " - i" + imaginaryPart);
    }
    
}
