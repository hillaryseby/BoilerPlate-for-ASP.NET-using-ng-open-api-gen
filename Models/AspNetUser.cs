using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class AspNetUser
{
    public long UserId { get; set; }

    public string UserName { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public virtual UserCredential User { get; set; } = null!;

    public virtual UserDetail UserNavigation { get; set; } = null!;
}
