using System;
using System.Collections;
public class SampHashVal
{

	public static void Main2()
	{

		// Creates and initializes a new Hashtable.
		Hashtable myHT = new Hashtable();
		myHT.Add(0, "zero");
		myHT.Add(1, "one");
		myHT.Add(2, "two");
		myHT.Add(3, "three");
		myHT.Add(4, "four");
		myHT.Add(5, "seth");
		myHT.Add(6, "michael");

		// Displays the values of the Hashtable.
		Console.WriteLine("The Hashtable contains the following values:");
		PrintIndexAndKeysAndValues(myHT);

		// Searches for a specific key.
		int myKey = 2;
		Console.WriteLine("The key \"{0}\" is {1}.", myKey, myHT.ContainsKey(myKey) ? "in the Hashtable" : "NOT in the Hashtable");
		myKey = 6;
		Console.WriteLine("The key \"{0}\" is {1}.", myKey, myHT.ContainsKey(myKey) ? "in the Hashtable" : "NOT in the Hashtable");

		// Searches for a specific value.
		String myValue = "three";
		Console.WriteLine("The value \"{0}\" is {1}.", myValue, myHT.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
	 	myValue = "seth";
		Console.WriteLine("The value \"{0}\" is {1}.", myValue, myHT.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
		myValue = "harden";
		Console.WriteLine("The value \"{0}\" is {1}.", myValue, myHT.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
		myValue = "nine";
		Console.WriteLine("The value \"{0}\" is {1}.", myValue, myHT.ContainsValue(myValue) ? "in the Hashtable" : "NOT in the Hashtable");
	}


	public static void PrintIndexAndKeysAndValues(Hashtable myHT)
	{
		int i = 0;
		Console.WriteLine("\t-INDEX-\t-KEY-\t-VALUE-");
		foreach (DictionaryEntry de in myHT)
			Console.WriteLine("\t[{0}]:\t{1}\t{2}", i++, de.Key, de.Value);
		Console.WriteLine();
	}

}
