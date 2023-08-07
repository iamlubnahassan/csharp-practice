int divisor, dividend, quotient, remainder;

Console.WriteLine("Enter divident: ");
dividend = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("divisor: ");
divisor = Convert.ToInt32(Console.ReadLine());

quotient = dividend / divisor;
remainder = dividend % divisor;

Console.WriteLine("Quotient = "+ quotient);
Console.WriteLine("Remainder = "+ remainder);