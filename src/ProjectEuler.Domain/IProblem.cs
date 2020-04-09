namespace ProjectEuler.Domain
{
    public interface IProblem
    {
        int Id { get; set; }
        string Url { get; set; }
        string Title { get; set; }
        string Description { get; set; }

        void Solve();
    }
}