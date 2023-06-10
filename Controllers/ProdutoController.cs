using AutoMapper;
using dotnet_api_com_entity_framework.Data;
using dotnet_api_com_entity_framework.Data.Dtos;
using dotnet_api_com_entity_framework.Model;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace dotnet_api_com_entity_framework.Controllers
{
    [ApiController]
    [Route("v1/produtos")]
    public class ProdutoController : ControllerBase
    {
        IMapper _mapper;
        public ProdutoController(IMapper mapper)
        {
            _mapper = mapper;
        }
        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<ReadProdutoDto>>> Get([FromServices] DataContext context)
        {
            var listaProdutosDto = new List<ReadProdutoDto>();
            var listaProdutos = await context.Produtos.ToListAsync();
            listaProdutos.ForEach(x => listaProdutosDto.Add(_mapper.Map<ReadProdutoDto>(x)));

            return listaProdutosDto;
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
        public async Task<ActionResult<Produto>> Post([FromServices] DataContext context, [FromBody]CreateProdutoDto produtoDto)
        {
            if (ModelState.IsValid)
            {
                Produto produto = _mapper.Map<Produto>(produtoDto);
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

        [HttpPut]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> Put([FromServices] DataContext context, [FromBody]UpdateProdutoDto produtoDto, int id)
        {
            Produto? produtoExitente = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            //context.Entry(produto).State = EntityState.Modified;
            
            try
            {
                if(produtoExitente == null){
                    throw new Exception("Produto não encontrado");
                }
                _mapper.Map(produtoDto, produtoExitente);
               
                await context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

            return NoContent();
        }

        [HttpPatch]
        [Route("{id:int}")]
        public async Task<ActionResult<Produto>> Patch([FromServices] DataContext context, int id, [FromBody] JsonPatchDocument<UpdateProdutoDto> patch)
        {
           
            Produto? produtoExitente = await context.Produtos.FirstOrDefaultAsync(x => x.Id == id);

            if (produtoExitente == null) return NotFound();

            var produtoParaAtualizar = _mapper.Map<UpdateProdutoDto>(produtoExitente);

            patch.ApplyTo(produtoParaAtualizar, ModelState);

            if (!TryValidateModel(produtoParaAtualizar))
            {
                return ValidationProblem(ModelState);
            }

            _mapper.Map(produtoParaAtualizar, produtoExitente);

            context.SaveChanges();
            return NoContent();

        }
    }
}
