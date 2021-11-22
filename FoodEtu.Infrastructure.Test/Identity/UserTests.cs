using Moq;
using Xunit;

namespace FoodEtu.Infrastructure.Test.Identity;

public class UserTests
{
    [Fact]
    public void Register_User_Should_Insert_In_Users_Table()
    {
        var databaseContextMock = new Mock<FoodEtuDbContext>();
    }
}

