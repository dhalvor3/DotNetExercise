﻿using System;

namespace FluentAssertions
{
    public class Class1
    {
        public void additionMethod() {
            var first = 3;
            var second = 7;
            var result = first + second;

            result.Should().Be(10);
        }
    }
}
