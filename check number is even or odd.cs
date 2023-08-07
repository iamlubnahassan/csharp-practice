int n;
Console.WriteLine("Enter any number: ");
n = Convert.ToInt32(Console.ReadLine());  //Convert string to intiger

if(n % 2==0){
    Console.WriteLine("even");
}
else{
    Console.WriteLine("odd");
}