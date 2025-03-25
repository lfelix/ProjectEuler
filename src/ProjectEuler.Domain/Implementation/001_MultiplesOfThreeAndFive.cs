namespace ProjectEuler.Domain.Implementation;
public class MultiplesOfThreeAndFive : IProblem
{
    public required int Id { get; set; }
    public required string Url { get; set; }
    public required string Title { get; set; }
    public required string Description { get; set; }

    //If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.\nFind the sum of all the multiples of 3 or 5 below 1000.
    public decimal Solve()
    {
        int sum = 0;
        for (int i = 1; i < 1_000; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
                sum += i;
        }
        return sum;
    }
}