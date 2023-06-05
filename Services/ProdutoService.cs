using dotnet_api_com_entity_framework.Data;
using dotnet_api_com_entity_framework.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.OData;

namespace dotnet_api_com_entity_framework.Services
{
    public class ProdutoService
    {
        DataContext _context;
        public ProdutoService(DataContext context)
        {
            _context = context;
        }
        public async Task Patch(int id, Produto produto)
        {
            Delta<Produto> delta = new Delta<Produto>();
            var dominio = await _context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (dominio != null)
            {
                delta.Patch(dominio);
                Console.WriteLine("break");
            }
        }
    }
}
