/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
using System.Collections;
class HelloWorld
{
  static void Main ()
  {
    Random rnd = new Random ();

    ArrayList names = new ArrayList ();
      names.Add ("Per");
      names.Add ("Henrik");
      names.Add ("Ib");
      names.Add ("Batholomeu");

    ArrayList ages = new ArrayList ();
      ages.Add (45);
      ages.Add (47);
      ages.Add (81);
      ages.Add (32);

    for (int i = 1; i <= 5; i++)
    {
	    string name = (string) names[rnd.Next (0, names.Count)];
	    int age = (int) ages[rnd.Next (0, ages.Count)];
	    Person j = new Person (name, age);

	    Console.WriteLine (j.ToString ());

	    for (int k = 0; k < names.Count; k++)
	    {
	        if (name.Equals (names[k]))
	        {
		        Console.WriteLine ("Removing element: " + names[k]);
		        names.Remove (names[k]);
	        }
	    }
	    for (int k = 0; k < ages.Count; k++)
	    {
	        if (age.Equals (ages[k]))
	        {
		        Console.WriteLine ("Removing element: " + ages[k]);
		        ages.Remove (ages[k]);
	        }
	    }
	    if (names.Count == 0 || ages.Count == 0)
	    {
	        break;
	    }
    }
  }
}

public class Person
{
  public string Name
  {
    get;
    set;
  }
  public int Age
  {
    get;
    set;
  }
  public Person (string name, int age)
  {
    Name = name;
    Age = age;
  }
  public override string ToString ()
  {
    return Name + " er " + Age + " aar gammel";
  }
}
