using BenchmarkDotNet.Running;
using ForSpanForeachLinq;
using System.Diagnostics;

/*
#region old code
// Define some basic types for testing each loop type.
var ints = new int[] { 1, 2, 3, 5, 6 };

Span<int> intSpans = new Span<int>(ints);
List<int> intList = new List<int>(ints);
// Normal for loop with array
var watch = Stopwatch.StartNew();
for (int i = 0; i < ints.Count(); i++)
{
    Console.WriteLine(ints[i]);
}
watch.Stop();
Console.WriteLine($"Elapsed time FOR LOOP with ARRAY = {watch.ElapsedMilliseconds / 1000.0}");
// Normal for loop with list
watch.Start();
for (int i = 0; i < intList.Count; i++)
{
    Console.WriteLine(intList[i]);
}
watch.Stop();
Console.WriteLine($"Elapsed time FOR LOOP with LIST = {watch.ElapsedMilliseconds / 1000.0}");
// Normal for loop with span
watch.Start();
for (int i = 0; i < intSpans.Length; i++)
{
    Console.WriteLine(intSpans[i]);
}
watch.Stop();
Console.WriteLine($"Elapsed time FOR LOOP with SPAN = {watch.ElapsedMilliseconds / 1000.0}");
#endregion
*/


BenchmarkRunner.Run<TestingClasses>();

