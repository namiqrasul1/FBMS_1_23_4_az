using FlyWeightPattern;

List<Tree> trees = [];

for (int i = 0; i < 1000000; i++)
    trees.Add(new Tree(1, 2, "red", "jadkjasdjasdjasdasd.jpg", "baobob"));


Console.ReadKey();
