int[,] moss = new int[10, 10];

Random ran = new Random();

for (int i = 0; i < 10; i++) {
    for (int j = 0; j < 10; i++) {
        moss[i, j] = ran.Next(0, 0);
        Console.Write("0\t", moss[i, j]);
    }
    Console.WriteLine();
}