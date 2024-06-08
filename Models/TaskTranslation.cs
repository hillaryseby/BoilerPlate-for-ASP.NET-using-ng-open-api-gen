using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class TaskTranslation
{
    public long TaskId { get; set; }

    public string? UserId { get; set; }

    public DateTime? TimeStamp { get; set; }
}
