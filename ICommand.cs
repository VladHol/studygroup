namespace Code4Kata
{
    public interface ICommand
    {
        int Type{get;}
        double Execute(double a, double b);
    }
}