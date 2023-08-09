int n,sum=0;
Console.WriteLine("please enter any pasitive integer");
n = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=n; i++){
    sum+=i;
}
Console.Write($"the sum of the numbers is {sum}");