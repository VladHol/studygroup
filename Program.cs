using System;
using Code4Kata.Commands;
using System.Collections.Generic;
namespace Code4Kata
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICommand commandToExecute;
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

            switch (input)
            {
                case 1 :
                    commandToExecute = new Add();
                break;
                case 2:
                    commandToExecute = new Multiply();
                break;
                case 3:
                    commandToExecute = new Substract();
                break;
                default:
                    commandToExecute = new Substract();
                break;
            }

            var result = commandToExecute.Execute(3,5);
            // var result = commands[input].Execute(3,5);
            //var result = commands[input].Invoke(3,5);
            Console.WriteLine(result);

        }
    }
}
