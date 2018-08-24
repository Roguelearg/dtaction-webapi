namespace TacosDotIoJourneyAgency2.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class JourneyAgencyDb : DbContext
    {
        // Your context has been configured to use a 'JourneyAgencyDb' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'TacosDotIoJourneyAgency2.Models.JourneyAgencyDb' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'JourneyAgencyDb' 
        // connection string in the application configuration file.
        public JourneyAgencyDb()
            : base("name=JourneyAgencyDb")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Pays> Pays { get; set; }
        public virtual DbSet<Ville> Ville { get; set; }
        public virtual DbSet<Voyage> Voyage { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}