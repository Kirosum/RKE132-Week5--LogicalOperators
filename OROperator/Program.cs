// Math >= 90 OR Biology >= 90 

//MAth && Biology || Math && Chemistry || Chemistry && Biology

int math, chemistry, biology;

Console.WriteLine("Enter your Math Result:");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Biology result:");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your Chemistry Result:");
chemistry = Int32.Parse(Console.ReadLine());

if((math >= 90 && chemistry >=90) || (math >= 90 && biology >=90) || (chemistry >= 90 && biology >= 90) )
{
    Console.WriteLine("Congratulations! You got accepted");
}
else
{
    Console.WriteLine("Your application cannot be approved.");
}