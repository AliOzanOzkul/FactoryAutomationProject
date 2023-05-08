using Otomasyon.Entity.Classes;
using Otomasyon.Model.Context;

namespace Otomasyon.BLL.Services
{
    public static class ExpensesServices
    {
        static OtomasyonContext _db = new OtomasyonContext();

        public static void AddExpenses(Expenses expenses)
        {
            _db.Expenses.Add(expenses);
            _db.SaveChanges();
        }
        public static List<Expenses> GetExpenses()
        {
            return _db.Expenses.ToList();
        }
        public static decimal GetTotalExpense()
        {

            return _db.Expenses.Sum(x => x.Bill);
        }
        public static List<Expenses> GetExpensesWeek()
        {
            DateTime oneWeekAgo = DateTime.Today.AddDays(-7);
            return _db.Expenses.Where(x => x.DateTime >= oneWeekAgo).ToList();
        }

        public static List<Expenses> GetExpensesMon()
        {
            DateTime oneWeekAgo = DateTime.Today.AddDays(-30);
            return _db.Expenses.Where(x => x.DateTime >= oneWeekAgo).ToList();
        }
        public static List<Expenses> GetExpensesYear()
        {
            DateTime oneWeekAgo = DateTime.Today.AddDays(-365);
            return _db.Expenses.Where(x => x.DateTime >= oneWeekAgo).ToList();
        }
    }
}
