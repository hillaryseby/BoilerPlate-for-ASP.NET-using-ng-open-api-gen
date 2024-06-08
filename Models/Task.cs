using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Task
{
    public long TaskId { get; set; }

    public string? TaskName { get; set; }
}
