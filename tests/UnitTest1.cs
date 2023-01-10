using SampleApi.Core.Models;
using System;
using Xunit;

namespace SampleApi.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var entity = new Sample
        {
            Id = Guid.NewGuid(),
            CreatedAt = DateTime.Now
        };
        Assert.NotNull(entity);
    }
}