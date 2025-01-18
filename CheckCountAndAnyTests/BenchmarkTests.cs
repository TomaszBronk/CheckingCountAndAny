
using System.Collections.Generic;
using Xunit;

namespace CheckCountAndAnyTests
{
    public class BenchmarkTests
    {
        private readonly Benchmark _benchmark = new Benchmark();

        public static IEnumerable<object[]> IntListData =>
            new List<object[]>
            {
                new object[] { new int[] { 1, 2, 3 }, true },
                new object[] { new int[] { }, false }
            };

        public static IEnumerable<object[]> StringListData =>
            new List<object[]>
            {
                new object[] { new string[] { "a", "b", "c" }, true },
                new object[] { new string[] { }, false }
            };

        public static IEnumerable<object[]> ObjectListData =>
            new List<object[]>
            {
                new object[] { new object[] { new object(), new object(), new object() }, true },
                new object[] { new object[] { }, false }
            };

        [Theory]
        [MemberData(nameof(IntListData))]
        public void TestCountNotZero_IntList(int[] input, bool expected)
        {
            var result = _benchmark.CheckCountNotZero(new List<int>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(IntListData))]
        public void TestCountMethodNotZero_IntList(int[] input, bool expected)
        {
            var result = _benchmark.CheckCountMethodNotZero(new List<int>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(IntListData))]
        public void TestAny_IntList(int[] input, bool expected)
        {
            var result = _benchmark.CheckAny(new List<int>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(StringListData))]
        public void TestCountNotZero_StringList(string[] input, bool expected)
        {
            var result = _benchmark.CheckCountNotZero(new List<string>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(StringListData))]
        public void TestCountMethodNotZero_StringList(string[] input, bool expected)
        {
            var result = _benchmark.CheckCountMethodNotZero(new List<string>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(StringListData))]
        public void TestAny_StringList(string[] input, bool expected)
        {
            var result = _benchmark.CheckAny(new List<string>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ObjectListData))]
        public void TestCountNotZero_ObjectList(object[] input, bool expected)
        {
            var result = _benchmark.CheckCountNotZero(new List<object>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ObjectListData))]
        public void TestCountMethodNotZero_ObjectList(object[] input, bool expected)
        {
            var result = _benchmark.CheckCountMethodNotZero(new List<object>(input));
            Assert.Equal(expected, result);
        }

        [Theory]
        [MemberData(nameof(ObjectListData))]
        public void TestAny_ObjectList(object[] input, bool expected)
        {
            var result = _benchmark.CheckAny(new List<object>(input));
            Assert.Equal(expected, result);
        }
    }
}

