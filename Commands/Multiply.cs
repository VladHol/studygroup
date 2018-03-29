using Code4Kata;
namespace Code4Kata.Commands
{
    public class Multiply : ICommand
    {
         public int Type => 2;
        public double Execute(double a, double b){
            return a * b;
        }
    }
}