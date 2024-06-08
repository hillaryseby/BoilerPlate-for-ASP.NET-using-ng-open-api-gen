using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UserCredential
{
    public long UserId { get; set; }

    public string PasswordHash { get; set; } = null!;

    public string PasswordSalt { get; set; } = null!;

    public string LoginTimeStamp { get; set; } = null!;

    public virtual AspNetUser? AspNetUser { get; set; }
}
