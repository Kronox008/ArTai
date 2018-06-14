using SQLite;

namespace ArTai
{
    public interface ISQLiteDb
    {
        SQLiteAsyncConnection GetConnection();
    }
}

