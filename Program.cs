/*
 * Created by SharpDevelop.
 * User: admin
 * Date: 8/20/2021
 * Time: 08:47
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Pairwiseupdate
{
	class Program
	{
		public static void Main(string[] args)
		{

			// TODO: Implement Functionality Here

			Console.WriteLine("Enter numbers, or 0 to stop:");
			// Make a list to hold the values the user types
			List<int> values = new List<int>();
			// Start a loop that goes forever
			while (true)
			{
				// Read a line of text
				string line = Console.ReadLine();

				// Get the value..
				int value;
				if (!int.TryParse(line, out value))
				{
					Console.WriteLine("Please enter a valid number!");
					continue; // Try again - just jumps to the next loop
				}

				if (value == 0)
				{
					// If you want to include the 0, add it here:
					// values.Add(value);
					break; // Exit our loop when the user enters zero
				}

				// Add this to your list of values...
				values.Add(value);
			}

			for (int i = 0; i < values.Count; i++) //checkpoint
			{
				Console.WriteLine(values[i]);
			}


			int tut = summingwhatever(values); //checkpoint


			Swap(values, 0, 1);

			int newtut = summingwhatever(values); //checkpoint


			for (int i = 0; i < values.Count; i++)
			{
				if (tut < newtut)
				{
					Swap(values, i, i + 1);
					summingwhatever(values);
				}
				else
				{
					int Max = summingwhatever(values);
				}


			}

			//Console.WriteLine("Maxium Sum: " + Max);

			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}


		static int summingwhatever(List<int> values) // add whatever permutation of data that is feed to it
		{
			//int length = values.Count;
			int[] arr = new int[values.Count];
			int pairtotal = 0;
			int maxtotal = 0;

			for (int i = 0; i < values.Count; i++)
			{

				for (int j = i + 1; j < values.Count; j++)
				{
					values[j] = values[i] + values[j];
					pairtotal = values[j];
				}
				arr[i] = pairtotal;
			}

			for (int i = 0 ;i<arr.Length; i++) //checkpoint
			{
				Console.WriteLine("[{0}]", string.Join(", ", arr));
			}

			/*for (int i = 0; i < arr.Length; i++)
				{
				    maxtotal += arr[i];
				}*/

			return maxtotal;


		}


		static void Swap(List<int> values, int indexA, int indexB)
		{
			int tmp = values[indexA];
			values[indexA] = values[indexB];
			values[indexB] = tmp;
		}

	}
}