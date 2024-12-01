using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AdventOfCode2024Day1 {
	internal class Program {
		static void Main(string[] args) {
			List<int> List1 = new List<int>();
			List<int> List2 = new List<int>();
			StreamReader streamReader = new StreamReader("Input.txt");
			string line = streamReader.ReadLine();
			while(line != null) {
				string Number1 = "";
				string Number2= "";
				bool FirstNumber = true;
				for(int i = 0; i < line.Length; i++) {
					if (line[i] != ' ') {
						if (FirstNumber) {
							Number1 += line[i];
							
						} else {
							Number2 += line[i];
						}
					} else {
						FirstNumber = false;
					}
				}
				List1.Add(Convert.ToInt32(Number1));
				List2.Add(Convert.ToInt32(Number2));
				line = streamReader.ReadLine();
			}
			List1.Sort();
			List2.Sort();
			int Total = 0;
			for (int i = 0; i < List1.Count; i++) {
				int Number = List1[i] - List2[i];
				if (Number < 0) {
					Number *= -1;
				}
				Total += Number;
			}
			Console.WriteLine("Part 1: " + Total.ToString());
			int TotalSimilarity = 0;
			for(int i = 0;i < List1.Count;i++) {
				int Comparison = List1[i];
				int Count = 0;
				for(int j = 0; j < List2.Count;j++) {
					if (List2[j] == Comparison) {
						Count++;
					}
				}
				TotalSimilarity += Comparison * Count;
			}
			Console.WriteLine("Part 2: " + TotalSimilarity.ToString());
			Console.ReadLine();
		}
		
	}
}
