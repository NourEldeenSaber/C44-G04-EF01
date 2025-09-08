using Demo.Data;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Connection with old way

            /// CompanyDbContext dbContext = new CompanyDbContext();
            /// try
            /// {
            ///     //code
            /// }
            /// finally
            /// {
            ///     //to close the connection
            ///     // dispose , close  , release
            ///     dbContext.Dispose();
            /// }


            #endregion

            #region Connection With new way

            // using (CompanyDbContext dbContext = new CompanyDbContext())
            // {
            //     // Code 
            // }


            /// using CompanyDbContext dbContext = new CompanyDbContext();
            /// //code 
            /// dbContext.Dispose();


            #endregion
        
        
            //CompanyDbContext db = new CompanyDbContext();
            //var name = db.Employees.Where(n => n.Name == "nour").Select(n=> n.Name).FirstOrDefault();
            //Console.WriteLine(name);


        }
    }
}
