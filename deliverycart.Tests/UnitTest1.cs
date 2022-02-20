using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using deliverycart.Data;
using deliverycart.Models;

namespace deliverycart.Tests;

public class DataAccessLayerTest
{
        [Fact]
        public async Task AddOrderAsync_OrderIsAdded()
        {
            using (var db = new Assignment3XTestsContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;

                var expectedOrder = new Order() 
                { 
                    OrderID = recId, 
                   
                };

                // Act
                await db.AddOrderAsync(expectedOrder);

                // Assert
                var actualOrder = await db.FindAsync<Order>(recId);
                Assert.Equal(expectedOrder, actualOrder);
            }
        }
}