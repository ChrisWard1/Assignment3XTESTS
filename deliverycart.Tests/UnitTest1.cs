using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Xunit;
using deliverycart.Data;
using deliverycart.Models;

namespace webapp.Tests;

public class DataAccessLayerTest
{
        [Fact]
        public async Task AddOrderAsync_OrderIsAdded()
        {
            using (var db = new RazorClubContext(Utilities.TestDbContextOptions()))
            {
                // Arrange
                var recId = 10;

                var expectedOrdert = new Order() 
                { 
                    ID = recId, 
                   
                };

                // Act
                await db.AddOrderAsync(expectedOrder);

                // Assert
                var actualOrder = await db.FindAsync<Order>(recId);
                Assert.Equal(expectedOrder, actualOrder);
            }
        }
}