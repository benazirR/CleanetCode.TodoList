using CleanetCode.TodoList.CLI.Models;
using CleanetCode.TodoList.CLI.Storages;

namespace CleanetCode.TodoList.CLI.Operations
{
    public class CreateNewUserOperation : IOperation
    {
        public string Name => "Create new user.";

        public void Execute()
        {

            Console.WriteLine("Enter your email:");
            string? email = Console.ReadLine();

            User newUser = new User()
            {
                Email = email,
            };

            bool userCreated = UserStorage.Create(newUser);
            if (!userCreated)
            {
                Console.WriteLine();
            }
            Console.WriteLine("User successfully created.");
        }
    }
}