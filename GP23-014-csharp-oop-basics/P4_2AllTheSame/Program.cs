ScoreCounter one = new ScoreCounter();
ScoreCounter two = new ScoreCounter();
ScoreCounter three = new ScoreCounter();
ScoreCounter four = new ScoreCounter();

one = two;
three = four;

one.IncreaseScore();
two.IncreaseScore();
three.IncreaseScore();
four.IncreaseScore();

Console.WriteLine(one.Score);
Console.WriteLine(two.Score);
Console.WriteLine(three.Score);
Console.WriteLine(four.Score);