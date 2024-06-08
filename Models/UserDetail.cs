using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UserDetail
{
    public long UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Address { get; set; }

    public virtual AspNetUser? AspNetUser { get; set; }
}
