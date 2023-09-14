using System;
using System.Collections.Generic;
using System.Data.Entity;

//ref link:https://www.youtube.com/watch?v=ZCBIoI5qz4M&list=PLRwVmtr-pp06bXl6mbwDfK1eW9sAIvWUZ&index=2
// EntityFramework - is a object relational mapping(ORM) data tool

class Video
{
    public int ID { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}

class MeContext : DbContext
{
    //public MeContext() : base(@"Data Source=.;Initial Catalog=KulpotDB;Integrated Security=True")
    public MeContext() : base(@"Data Source=.;Initial Catalog=MyTestDb;Integrated Security=True")
    {

    }
    public DbSet<Video> Videos { get; set; }
}

class MainClass
{
    static void Main()
    {
        var vid = new Video
        {
            Title = "Hello World Entity Framework",
            Description = "Learn about the entity framework"
        };
        var meContext = new MeContext();

        meContext.Database.Delete();

        //meContext.Videos.Add(vid);
        //meContext.SaveChanges();
    }
}