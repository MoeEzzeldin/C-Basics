// creating list of int / sort and select using LINQ!

List<int> scores = [0, 2, 1, 3, 5, 4, 6, 7, 9, 8];
IEnumerable<string> scoreQuery =
    from score in scores
    where score > 2
    orderby score ascending
    select $"the score found is: {score}";

foreach (string s in scoreQuery)
{
    Console.WriteLine(s);
};