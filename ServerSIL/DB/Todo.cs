using System;
using System.Collections.Generic;

namespace ServerSIL.DB;

public partial class Todo
{
    public int Id { get; set; }

    public string? TodoName { get; set; }

    public string? Description { get; set; }

    public int? StatusId { get; set; }

    public virtual Status? Status { get; set; }
}
