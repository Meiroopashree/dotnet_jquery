using System;
using System.ComponentModel.DataAnnotations;


namespace dotnetapp.Model
{
public class Post
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Content { get; set; }
     public List<Comment> Comments { get; set; } = new List<Comment>();
}
}