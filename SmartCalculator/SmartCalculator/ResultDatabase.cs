using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCalculator
{
    public class ResultDatabase
    {
        private SQLiteAsyncConnection database;

        public ResultDatabase(string dbPath)
        {
            database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Result>().Wait();
        }


        public Task<List<Result>> GetItemsAsync()
        {
            return database.Table<Result>().ToListAsync();
        }

        public Task<List<Result>> GetItemsNotDoneAsync()
        {
            return database.QueryAsync<Result>("SELECT * FROM [Result] ORDER BY Favourite; ");
        }

        public Task<Result> GetItemAsync(int id)
        {
            return database.Table<Result>().Where(i => i.ID == id).FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Result item)
        {
            if (item.ID != 0)
            {
                return database.UpdateAsync(item);
            }
            else
            {
                return database.InsertAsync(item);
            }
        }

        public Task<int> DeleteItemAsync(Result item)
        {
            return database.DeleteAsync(item);
        }
    }
}