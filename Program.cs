using HuffmanAlgorithm;

var filePath = args[0] ?? throw new ArgumentNullException(nameof(args));

var codes = filePath.GetHuffmanCodes();

foreach (var kvp in codes)
{
    Console.WriteLine($"{kvp.Key} {kvp.Value}");
}