
using FN.Store.UI.Models;
using Microsoft.EntityFrameworkCore;

namespace FN.Store.UI.Data
{
    public interface IDataContext
    {
        string GetStringConn();

        DbSet<Produto> Produtos { get; set; }
    }
}
