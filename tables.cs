using System;
using static System.Console;
using System.Globalization;
class Tables 

//Created By: Josh Thrash
//Date: April 20, 2021
//Purpose: This program prompts a user to input a number of chairs (greater than 1), then ask the user to select
//			a specific type of wood.  The program then calculates the cost of number of chair in that particular
//			style of wood and displays the total cost of chairs and type of wood.



{
	static void Main()
	{	
		int chairs = NumOfChairs();
		string wood = WoodChoice();
		int cost = TotalCost(chairs, wood);

		Display(cost, wood, chairs);
		
	}

	//Function to propmpt number of chairs until grater than one
	static int NumOfChairs()
	{
		int numOfChairs;

		Write("Enter a number of chairs >> ");
		numOfChairs = Convert.ToInt32(ReadLine());

		while(numOfChairs <= 1)
		{
			WriteLine("You must order at least two chairs");
			Write("Enter a number of chairs >> ");
			numOfChairs = Convert.ToInt32(ReadLine());
		}

		return numOfChairs;

	}

	//Function to prompt for type of wood
	static string WoodChoice()
	{
		string typeOfWood;
		
		Write("Enter a type of wood - p, m, or o >> ");
		typeOfWood = ReadLine();

		while(typeOfWood != "p" && typeOfWood != "m" && typeOfWood != "o")
		{
			WriteLine("You have entered an invalid wood type");
			Write("Enter a type of wood - p, m, or o >> ");
			typeOfWood = ReadLine();
		}
		return typeOfWood;
		
	}
	
	//Function that takes numbe rof chairs and type of wood and totals amount
	static int TotalCost(int chairs, string wood)
	{	
		const int p = 250;
		const int m = 300;
		const int o = 350;
		int tablePrice = 0;
		int finalCost;
		const int pricePerChair = 50;

		int totalCostChair = ((chairs * pricePerChair));
		
		string woodType = wood;
		
		if(woodType == "p")
			tablePrice = p;
		else if(woodType == "m")
			tablePrice = m;
		else if(woodType == "o")
			tablePrice = o;
		
			
		finalCost = totalCostChair + tablePrice;
		return finalCost;

	}
	
	//Function that will display all calculations and prompts for user to see total
	static void Display(int cost, string wood, int chairs)
	{
		int chairNum = chairs;
		string tableMaterial = "";
		string woodType = wood;
		int totalCost = cost;
		
		if(woodType == "p")
			tableMaterial = "Pine";
		else if(woodType == "m")
			tableMaterial = "Maple";
		else if(woodType == "o")
			tableMaterial = "Other";
		
		WriteLine("\nYou have ordered a {0} table with {1} chairs", tableMaterial, chairNum);
		WriteLine("\r\nTotal price is {0}", totalCost.ToString("C", CultureInfo.GetCultureInfo("en-US")));

	}

	


}



