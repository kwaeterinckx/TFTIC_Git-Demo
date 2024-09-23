namespace Distributeur
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int stock1 = 5;
			int stock2 = 2;
			int stock3 = 0;

			int choix;

			do
			{
				Console.WriteLine("Veuillez sélectionner une boisson :");
				Console.WriteLine("1. Eau");
				Console.WriteLine("2. Soda");
				Console.WriteLine("3. Orangeade");
				Console.WriteLine("4. Quitter");

				choix = int.Parse(Console.ReadLine());

				switch (choix)
				{
					case 1:
						if (stock1 > 0)
						{
							Console.WriteLine("Voici votre eau");
							stock1--;
						}
						else
							Console.WriteLine("Sold out!");
						break;
					case 2:
						if (stock2 > 0)
						{
							Console.WriteLine("Voici votre soda");
							stock2--;
						}
						else
							Console.WriteLine("Sold out!");
						break;
					case 3:
						if (stock3 > 0)
						{
							Console.WriteLine("Voici votre soda");
							stock3--;
						}
						else
							Console.WriteLine("Sold out!");
						break;
					case 4:
						break;
					default:
						Console.WriteLine("Choix indisponible");
						break;
				}
			} while ((stock1 + stock2 + stock3 > 0) && choix != 4);
			Console.WriteLine("Merci d'utiliser distributeur 3000!");
		}
	}
}
