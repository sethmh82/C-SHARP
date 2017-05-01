using System;
using System.Collections;
public class SampleHashRemove
{

	public static void Main ()
	{

		// Creates and initializes a new Hashtable.
		Hashtable myHT = new Hashtable();
		myHT.Add("1a", "The");
		myHT.Add("1b", "quick");
		myHT.Add("1c", "brown");
		myHT.Add("2a", "fox");
		myHT.Add("2b", "jumped");
		myHT.Add("2c", "over");
		myHT.Add("3a", "the");
		myHT.Add("3b", "lazy");
		myHT.Add("3c", "dog");

		// Displays the Hashtable.
		Console.WriteLine("The Hashtable initially contains the following:");
		PrintKeysAndValues(myHT);

		Hashtable myHT2 = new Hashtable();
		myHT2.Add("Name1", "Mark");
		myHT2.Add("Name2", "Jim");
		myHT2.Add("Name3", "Jeff");
		myHT2.Add("Name4", "Steve");
		myHT2.Add("Name5", "Jessica");
		myHT2.Add("Name6", "Oliver");
		myHT2.Add("Name7", "Lola");
		myHT2.Add("Name8", "Bob");
		myHT2.Add("Name9", "Stanley");
        PrintKeysAndValues2(myHT2);
		// Removes the element with the key "3b".
		myHT.Remove("3b");
		myHT.Remove("2c");
		myHT.Remove("2a");
		myHT.Remove("1c");
		myHT.Remove("1a");

		// Displays the current state of the Hashtable.
		Console.WriteLine("After removing \"lazy\":");
		PrintKeysAndValues(myHT);
	}


	public static void PrintKeysAndValues(Hashtable myHT)
	{
		foreach (DictionaryEntry de in myHT)
			Console.WriteLine("    {0}:    {1}", de.Key, de.Value);
		Console.WriteLine();
	}

	public static void PrintKeysAndValues2(Hashtable myHT2)
	{
	foreach (DictionaryEntry de in myHT2)
		Console.WriteLine("    {0}:    {1}", de.Key, de.Value);
	Console.WriteLine();	
	}

}