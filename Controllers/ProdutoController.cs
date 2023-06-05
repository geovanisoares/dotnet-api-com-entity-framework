using dotnet_api_com_entity_framework.Data;
using dotnet_api_com_entity_framework.Model;
using dotnet_api_com_entity_framework.Services;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.JsonPatch.Operations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Web.Http.OData;

namespace dotnet_api_com_entity_framework.Controllers
{
    [ApiController]
    [Route("v1/produtos")]
    public class ProdutoController : ControllerBase
    {
        ProdutoService _produtoService;
        public ProdutoController(ProdutoService produtoService)
        {
            _produtoService = produtoService;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Produto>>> Get([FromServices] DataContext context)
        {
            return await context.Produtos.ToListAsync();
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> GetById([FromServices] DataContext context, int id)
        {
            var produto = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
       
            return produto;
        }

        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Produto>> Post([FromServices] DataContext context, [FromBody]Produto produto)
        {
            if (ModelState.IsValid)
            {
                context.Produtos.Add(produto);
                await context.SaveChangesAsync();
                return produto;
            }
            else
            {
                return BadRequest(ModelState);
            }

        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> Delete([FromServices] DataContext context, int id)
        {
            var produto = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);
            if (produto != null)
            {
                try
                {
                    context.Produtos.Remove(produto);
                    await context.SaveChangesAsync();
                    return NoContent();
                }
                catch (Exception ex)
                {
                    return BadRequest($"Error: {ex.Message}");
                }
                
            }
            else
            {
                return NotFound();
            }

            return produto;
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> Patch([FromServices] DataContext context, int id, [FromBody] JsonPatchDocument<Produto> produto)
        {
            
            //var dominio = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            //await _produtoService.Patch(id, produto);
            //Console.WriteLine(dominio);

            //delta.Patch(dominio);
            //Console.WriteLine(dominio);


            return NoContent();
            
        }
    }
}
