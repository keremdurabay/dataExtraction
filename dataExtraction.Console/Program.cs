using dataExtraction.Application.Abstract;
using dataExtraction.Presistence.concretes;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection().AddTransient<IUserService,UserService>().BuildServiceProvider();

var Users = serviceProvider.GetService<IUserService>()!.GetAllUsers();

foreach(var user in Users)
{
    Console.WriteLine(user.FirstName+ " " + user.LastName+" "+user.Balance);
}