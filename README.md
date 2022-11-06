# Indexers in C#

An indexer allows an object to be indexed such as an array.

When you define an indexer for a class, this class behaves similar to a
virtual array.

You can then access the instance of this class using the array access
operator ([ ]).

Before going into the details, we have to know about list in C#.

List Class

List class represents the list of objects which can be accessed by
index.

It comes under the System.Collection.Generic namespace.

List class can be used to create a collection of different types like
integers, strings etc.

List class also provides the methods to search, sort, and manipulate
lists.

Creating a List of integers

List<int> numberlist = new List<int>();

numberlist.Add(1);

numberlist.Add(2);

numberlist.Add(3);

Accessing Items from the List

We can access items using foreach.

foreach (var number in numberlist)

{

Console.WriteLine(number);

}

We can also use “Count” to find the number if items in the list.

Console.WriteLine(numberlist.Count);

List can be cleared using “Clear”.

numberlist.Clear();

Example

List<string> nameslist = new List<string>();

nameslist.Add("Awais");

nameslist.Add("ALi");

nameslist.Add("Ahmad");

“Sort” will be used to sort the array.

nameslist.Sort();

Back to Indexers

In order to understand the scenario lets create a Person class.

Give some attributes like Id and name to it.

class Person

{

public int EmpId { get; set; }

public string EmpName { get; set; }

}

Now let's create a class Company.

We are already aware of the list class, lets create a Person type list.

After that set some initial values of Id and name using constructor.

In this way we have a “Person” as a data type in the list that we are
going to create.

class Company

{

private List<Person> listPersons = new List<Person>();

public Company()

{

listPersons.Add(new Person { EmpId = 1, EmpName = "Awias" }) ;

listPersons.Add(new Person { EmpId = 2, EmpName = "Ali" });

listPersons.Add(new Person { EmpId = 3, EmpName = "Ahmad" });

}

}

Create Indexer

Now we have almost all the ingredients to create an indexer that can
be useful in our example.

Indexers have a return type, they have parameters and get/set
accessors.

Now I am going to create a string type indexer with parameter
“EmpId”.

public string this[int empId]

After that we have to define get and set accessors.

In get accessor traverse the listPersons and find the id that matches
with the parameter passed.

After that return the name against that Id.

get

{

foreach(var per in listPersons)

{

if(per.EmpId == empId)

{

return per.EmpName;

}

}

return null;

}

In set accessor we can find the object which has the id same as the
passed parameter and change its name.

set

{

foreach (var per in listPersons)

{

if (per.EmpId == empId)

{

per.EmpName = value;

}

}

}

Overloaded Indexer

We can have multiple indexers in a class, but they must have differrnt
parameters.
