char c;
bool isLowercaseVowel,isUppercaseVowel;
Console.WriteLine("Enter an alphabet");
c=Console.ReadKey().KeyChar;
isLowercaseVowel=(c=='a' || c=='e'||c=='i'||c=='o'||c=='u');
isUppercaseVowel=(c=='A' || c=='E'||c=='I'||c=='O'||c=='U');

if(!char.IsLetter(c)){
    Console.Write(" error non-aplhabetic character") ;
}
else if (isLowercaseVowel||isUppercaseVowel){
    Console.WriteLine(" is avowel");
}
else {
    Console.WriteLine(" is a constant");
}