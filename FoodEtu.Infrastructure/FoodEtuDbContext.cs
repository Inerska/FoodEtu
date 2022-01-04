// Copyright (c) Alexis Chân Gridel. All Rights Reserved.
// Licensed under the GNU General Public License v3.0.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FoodEtu.Infrastructure;

public class FoodEtuDbContext
    : IdentityDbContext<IdentityUser>
{
    public FoodEtuDbContext(DbContextOptions<FoodEtuDbContext> options)
        : base(options)
    {
    }
}