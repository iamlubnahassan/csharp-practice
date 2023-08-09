int n;
long factorial=1;
Console.WriteLine("Enter positive integer");
n = Convert.ToInt32(Console.ReadLine());
if(n<0){
    Console.WriteLine("factorial of negative number don't exist");
}
else{
    for(int i=1; i<=n; ++i){
    factorial*=i;
    }
    Console.Write("The fraction is: "+ factorial);
}