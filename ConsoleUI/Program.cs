
using  Methods;

SampleMethods.SayAuthor();
SampleMethods.WelcomeUser("Héctor", "Sandoval");
string firstName = SampleMethods.GetUserName("¿Cuál es tu nombre? ");
string lastName = SampleMethods.GetUserName("¿Cuál es tu apellido? ");
SampleMethods.WelcomeUser(firstName,lastName);
(string firstName, string lastName) fullName = SampleMethods.GetFullName();
SampleMethods.WelcomeUser(fullName.firstName,fullName.lastName);






