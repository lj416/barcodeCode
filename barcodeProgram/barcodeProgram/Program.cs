// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

bool checkInput = false;
while (checkInput != true)
{
    try
    {
        Console.WriteLine("Enter barcode: ");
        string barcodeInput = Console.ReadLine();
        int intBarcodeInput = Int32.Parse(intBarcodeInput);
    }
    catch
    {
        Console.WriteLine("Bad Input");
    }

}
