using Code4Kata;
namespace Code4Kata.Commands
{
    public class Multiply : ICommand
    {
        public double Execute(double a, double b){
            return a * b;
        }
    }
}