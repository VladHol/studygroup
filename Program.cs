using System;
using Code4Kata.Commands;
using System.Collections.Generic;
using System.Linq;

namespace Code4Kata
{
    public class Program
    {
        static void Main(string[] args)
        {
            var commands = new List<ICommand>{
                new Add(),new Multiply(),new Substract()
            };

            int input = (int)Char.GetNumericValue((char)Console.Read());

            // Dictionary<int, ICommand> commands = new Dictionary<int, ICommand>{
            //     {1, new Add()},
            //     {2, new Multiply()},
            //     {3, new Substract()}
            // };

            //  Dictionary<int, Func<double,double,double>> commands = new Dictionary<int, Func<double,double,double>>{
            //     {1, (x,y) => x + y },
            //     {2, (x,y) => x * y },
            //     {3, (x,y) => x - y}
            // };
           double result = 0;
           var commandToBeExecuted = commands.FirstOrDefault(c => c.Type == input); // Could be replaced with a Factory
            if(commandToBeExecuted != null)
                result = commandToBeExecuted.Execute(3,5);
            else
                result = commands[0].Execute(3,5);
            // var result = commands[input].Execute(3,5);
            //var result = commands[input].Invoke(3,5);
            Console.WriteLine(result);

        }
    }
}