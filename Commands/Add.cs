using Code4Kata;
namespace Code4Kata.Commands
{
    public class Add : ICommand
    {
        public double Execute(double a, double b){
            return a + b;
        }
    }
}