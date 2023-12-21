using AttributesApp;

Person tom = new Person("Tom", 35);
Person bob = new Person("Bob", 16);

bool tomIsValid = CommonMethods.ValidateUser(tom); 
bool bobIsValid = CommonMethods.ValidateUser(bob); 

Console.WriteLine($"Tom validation result: {tomIsValid}");
Console.WriteLine($"Bob validation result: {bobIsValid}");