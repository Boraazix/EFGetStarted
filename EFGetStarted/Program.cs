using EFGetStarted;

using (var context = new Repository())
{
    // create entity objects
    Blog blog = new Blog() { Url = "www.com.vc" };
    Post post = new Post() { Title = "A verdade", Content = "nua e crua", Blog = blog };
    blog.Posts.Add(post);

    // add entity to the context
    context.Blogs.Add(blog);
    context.Posts.Add(post);

    // save data to the database tables
    context.SaveChanges();

    // retrive data
    foreach(Post p in context.Posts)
    {
        Console.WriteLine(p.Title + ", " + p.Content);
    }
    foreach(Blog b in context.Blogs)
    {
        Console.WriteLine(b.Url);
    }
}