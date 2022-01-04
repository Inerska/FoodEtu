// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

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