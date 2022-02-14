{
string firstName;
string lastName;
int age;

    Console.WriteLine("What's your first name?");
 firstName = Console.ReadLine();

System.Console.WriteLine("What's your last name?");
lastName = Console.ReadLine();

string fullName = firstName + " " + lastName;

string firstNameInitial = firstName.Substring(0, 1);

string lastNameInitial = lastName.Substring(0, 1);

System.Console.WriteLine("What's your age?");
age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Hello, " + fullName + " your initials are " + firstNameInitial + "." + lastNameInitial + ". " + "and you are " + age + " years old"); 

}