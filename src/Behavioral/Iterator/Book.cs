﻿namespace Iterator;
/// <summary>
/// Collection item
/// </summary>
public class Book(string title, string author)
{
    public string Title { get; } = title;
    public string Author { get; } = author;
}