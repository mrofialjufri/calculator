class calkulator
{
  static void main(string[] args)
  {
	int a = 10;
	int b = 6;
		
	Console.WriteLine("Hasil penambahan: {0} + {1} = {2}", a, b, Penambahan(a, b));
	Console.WriteLine("Hasil penambahan: {0} - {1} = {2}", a, b, Pengurangan(a, b));
		
	Console.WriteLine("\nTekan Sembarang key untuk keluar");
	Console.ReadKey();
  }

  static int penambahan(int a, int b)
  {
      return a + b;
  }
  static int Pengurangan(int a, int b)
	{
		return a - b;
	}
  }
