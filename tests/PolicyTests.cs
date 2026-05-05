using PlumeSimResourceMark;

public static class PolicyTests
{
    public static void Run()
    {
        var signalcase_1 = new Signal(80, 81, 9, 19, 6);
        if (Policy.Score(signalcase_1) != 140) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_1) != "review") throw new Exception("decision mismatch");
        var signalcase_2 = new Signal(98, 94, 18, 11, 6);
        if (Policy.Score(signalcase_2) != 211) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_2) != "accept") throw new Exception("decision mismatch");
        var signalcase_3 = new Signal(107, 75, 27, 13, 13);
        if (Policy.Score(signalcase_3) != 196) throw new Exception("score mismatch");
        if (Policy.Classify(signalcase_3) != "accept") throw new Exception("decision mismatch");
    }
}
