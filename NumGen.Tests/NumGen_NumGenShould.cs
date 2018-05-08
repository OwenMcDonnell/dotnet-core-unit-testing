using System;
using Xunit;
using NumGen;

namespace NumGen.Tests
{
    public class NumGen_NumGenShould
    {
        private readonly NumGen _numGen;

        public NumGen_NumGenShould()
        {
            _numGen = new NumGen();
        }

        [Fact]
        public void ReturnIntValue()
        {
            var result = _numGen.Generate();

            Assert.Equal(result.GetType(), typeof(Int32));
        }
    }
}