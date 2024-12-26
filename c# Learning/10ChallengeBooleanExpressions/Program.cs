/*  Given Tasks:
    1.  If the user is an Admin w/level greater than 55
            output: "Welcome, Super Admin user."
    2.  If the user is an Admin w/level less than or equal to 55
            output: "Welcome, Admin user."
    3.  If the user is a Manager w/level greater than 20
            output: "You do not have sufficient privileges."
    4.  If the user is not an Admin or Manager
            output: "You do not have sufficient privileges."
*/

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}