using PlumeSimResourceMark;

public static class DomainReviewTests
{
    public static void Run()
    {
        var item = new DomainReview(62, 47, 27, 79);
        if (DomainReviewLens.Score(item) != 169) throw new Exception("domain score mismatch");
        if (DomainReviewLens.Lane(item) != "ship") throw new Exception("domain lane mismatch");
    }
}
