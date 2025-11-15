using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Data;
using WEBAPI.Models;

namespace WEBAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDBContext _context;
        public ProdutoController(AppDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<ProdutoModel>> BusacarProdutos()
        {
            var produtos = _context.Produtos.ToList();
            return Ok(produtos);
        }

        [HttpGet]
        [Route("{id}")]
        public ActionResult<List<ProdutoModel>> BusacarProdutoPOrID(int id)
        {
            var produto = _context.Produtos.Find(id);

            if (produto == null)
            {
                return NotFound("Registro não encontrado!");
            }

            return Ok(produto);
        }
        [HttpPost]
        public ActionResult<ProdutoModel> CriarProduto(ProdutoModel produtoModel)
        {
            _context.Produtos.Add(produtoModel);
            _context.SaveChanges();
            return CreatedAtAction(nameof(BusacarProdutoPOrID), new { id = produtoModel.ID }, produtoModel);
        }

        [HttpPut]
        [Route("{id}")]
        public ActionResult<ProdutoModel> EditarProduto(ProdutoModel produtoModel, int id)
        {
            var produto = _context.Produtos.Find(produtoModel.ID);

            if (produto == null)
            {
                return NotFound("Registro não encontrado!");
            }

            produto.Nome = produtoModel.Nome;
            produto.Descricao = produtoModel.Descricao;
            produto.Quantidade = produtoModel.Quantidade;
            produto.CodigoDeBarras = produtoModel.CodigoDeBarras;
            produto.Marca = produtoModel.Marca;

            _context.Produtos.Update(produto);
            _context.SaveChanges();

            return NoContent();

        }

        [HttpDelete]
        [Route("{id}")]
        public ActionResult<ProdutoModel> DeletarProduto(int id)
        {
            var produto = _context.Produtos.Find(id);
            if (produto == null)
            {
                return NotFound("Registro não encontrado!");
            }
            _context.Produtos.Remove(produto);
            _context.SaveChanges();
            return NoContent();
        }
     
    }
}
