﻿namespace PersonalWebsite.API;

public class TodoItem
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public bool IsComplete { get; set; }
}