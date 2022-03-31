using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Web
{
    public interface IRelatorio
    {
        Task Imprimir(HttpContext context);
    }
}