Console.Write("Enter the user name: ");
string username = Console.ReadLine();
if (username.ToLower() == "маша") {
    Console.WriteLine("OMG, this is the Masha!");
}
else {
    Console.Write("Привет, ");
    Console.Write(username);
}