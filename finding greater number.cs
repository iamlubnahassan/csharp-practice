double n1 , n2 , n3;
Console.WriteLine("Enter three number");
string[] inputValues= Console.ReadLine().Split(' ');

if (inputValues.Length==3 && 
    double.TryParse(inputValues[0] ,out n1) &&
    double.TryParse(inputValues[1], out n2 )&&
    double.TryParse(inputValues[2], out n3)) 
 { 
    if(n1>n2 && n2>n3){
        Console.WriteLine("n1 is greater");
    }
    else if(n2>n1 && n2>n3){
        Console.WriteLine("n2 is greater ");
    }
    else{
        Console.WriteLine("n3 is greater ");
    }
 }   
else{
    Console.WriteLine("invalid number try again");
}
