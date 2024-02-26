﻿using System;

Console.WriteLine("Enter your Name");
string fullName = Console.ReadLine().ToUpper();

Console.WriteLine("Enter your Date of Birth as 2010/12/12");
DateTime DOB = DateTime.Parse(Console.ReadLine());

DateTime today = DateTime.Today;

TimeSpan age = today - DOB;
int totalDays = Convert.ToInt32(age.TotalDays);
int totalHours = Convert.ToInt32(age.TotalHours);
int totalMinutes = Convert.ToInt32(age.TotalMinutes);

int years = totalDays / 365;
int months = (totalDays % 365) / 30;
int weeks = (totalDays % 365 % 30) / 7;
int days = totalDays % 365 % 30 % 7;

Console.WriteLine($"Hello, {fullName} Ji");

Console.WriteLine($"Your DOB is {DOB.ToString("dddd, dd MMMM yyyy")}.");