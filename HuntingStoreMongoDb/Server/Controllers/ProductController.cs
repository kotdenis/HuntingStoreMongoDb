using HuntingStoreMongoDb.Server.Repositories;
using HuntingStoreMongoDb.Shared.State;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Server.Controllers
{
    
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ProductRepository _productRepository;
        private readonly ILogger<ProductController> _logger;
        public ProductController(ILogger<ProductController> logger, ProductRepository productRepository)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("Product/GetProductsAsync")]
        public async Task<IActionResult> GetProductsAsync()
        {
            try
            {
                var list = await _productRepository.GetProductsAsync();

                if (list == null)
                    return NotFound("Not found");
                else
                {
                    _logger.LogWarning("got");
                    return Ok(list);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }

        [HttpPost]
        [Route("Product/CompleteOrderAsync")]
        public async Task<IActionResult> CompleteOrderAsync([FromBody] OrderViewModel orders)
        {
            try
            {
                await _productRepository.CompleteOrderAsync(orders);
                return Ok("Your order is successfully accepted!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }
    }
}
