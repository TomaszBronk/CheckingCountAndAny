using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

public class Benchmark
{
    private static readonly List<int> TestList = Enumerable.Range(1, 1000).ToList();
    private static readonly List<string> TestStringList = Enumerable.Range(1, 1000).Select(i => i.ToString()).ToList();
    private static readonly List<object> TestObjectList = Enumerable.Range(1, 1000).Select(i => (object)i).ToList();

    [Benchmark]
    public bool TestCountNotZero_IntList()
    {
        return CheckCountNotZero(TestList);
    }

    [Benchmark]
    public bool TestCountMethodNotZero_IntList()
    {
        return CheckCountMethodNotZero(TestList);
    }

    [Benchmark]
    public bool TestAny_IntList()
    {
        return CheckAny(TestList);
    }

    [Benchmark]
    public bool TestCountNotZero_StringList()
    {
        return CheckCountNotZero(TestStringList);
    }

    [Benchmark]
    public bool TestCountMethodNotZero_StringList()
    {
        return CheckCountMethodNotZero(TestStringList);
    }

    [Benchmark]
    public bool TestAny_StringList()
    {
        return CheckAny(TestStringList);
    }

    [Benchmark]
    public bool TestCountNotZero_ObjectList()
    {
        return CheckCountNotZero(TestObjectList);
    }

    [Benchmark]
    public bool TestCountMethodNotZero_ObjectList()
    {
        return CheckCountMethodNotZero(TestObjectList);
    }

    [Benchmark]
    public bool TestAny_ObjectList()
    {
        return CheckAny(TestObjectList);
    }

    public bool CheckCountNotZero<T>(ICollection<T> collection)
    {
        return collection.Count != 0;
    }

    public bool CheckCountMethodNotZero<T>(IEnumerable<T> collection)
    {
        return collection.Count() != 0;
    }

    public bool CheckAny<T>(IEnumerable<T> collection)
    {
        return collection.Any();
    }
}

