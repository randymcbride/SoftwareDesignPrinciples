﻿using System;

/*
 * OCP states that a class or module is open for extension but closed for modification.
 * I like to think OCP indicates we need to find the right level of abstraction for our classes.
 * If they are too concrete then we will end up writing an app that can't adapt to changing requirements.
 * If they are too abstract then we will waste time writing complicated code that can't accomplish our requirements.
 * 
 * UserTable and UserRow break OCP. If we wanted to add a new entity to our app,
 * we would have to create a new *Table class from scratch, and it would look very similar to our UserTable.
 * We don't have enough abstraction. The solution is to add a abstract table class and an abstract row class and
 * then instantiate them as UserTable and UserRow. See the OCP_After project to see how this is accomplished.
 */

namespace OCP_Before
{
	public class Program
	{
		static void Main(string[] args)
		{
			var userJane = new User
			{
				FirstName = "Jane",
				LastName = "Doe",
				DateOfBirth = new DateTime(1990, 1, 1)
			};
			var userJohn = new User
			{
				FirstName = "John",
				LastName = "Doe",
				DateOfBirth = new DateTime(2000, 1, 1)
			};

			var table = new UserTable();
			table.Insert(userJane);
			table.Insert(userJohn);
			Console.WriteLine(table.ExportCsv());
		}
	}
}
