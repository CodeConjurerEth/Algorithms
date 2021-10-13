using System;
using System.Collections;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		/**/

		//The old PRE GENERIC way using ArrayList instead of List<>
		{
			ArrayList arrayList = new ArrayList();
			//we can add anything we want
			arrayList.Add("hello");
			arrayList.Add(10);
			//but we have to cast it correctly
			string textA = (string)arrayList[0];
			//otherwise we either get a compiler error since all elements are objects (uncomment next line)
			//string textB = arrayList[0];
			//or a runtime error when we are casting it wrong (uncomment next line)
			//int intA = (int)arrayList[0];
		}

		/**/

		//The new GENERIC way using List<>
		{
			List<string> list = new List<string>();
			list.Add("hello");
			//note that we no longer need a cast
			string textA = list[0];
			//and trying to assign an element to the wrong type will give a compiler error: (uncomment next line)
			//int intA = list[0];
			//which cannot be 'fooled' by casting (uncomment next line)
			//int intB = (int)list[0];
		}

		/**/

		//Using your own generic class

		MagicBox<string> stringBox = new MagicBox<string>();
		//this box can only store strings
		stringBox.StoreItem("hello");
		//stringBox.StoreItem(10);

		MagicBox<int> intBox = new MagicBox<int>();
		//this box can only store ints
		intBox.StoreItem(10);
		//intBox.StoreItem("hello");

		/**/
		Console.ReadLine();
	}

}

