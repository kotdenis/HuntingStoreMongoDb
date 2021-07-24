using HuntingStoreMongoDb.Server.Repositories;
using HuntingStoreMongoDb.Shared.Models;
using HuntingStoreMongoDb.Shared.State;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HuntingStoreMongoDb.Server.Controllers
{

    [Authorize(AuthenticationSchemes = "Cookies, Bearer")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly AdminRepository _adminRepository;
        private readonly ILogger<AdminController> _logger;
        public AdminController(AdminRepository adminRepository, ILogger<AdminController> logger)
        {
            _adminRepository = adminRepository;
            _logger = logger;
        }

        [HttpGet]
        [Route("Admin/GetProductsAsync")]
        public async Task<IActionResult> GetProductsAsync()
        {
            try
            {
                var list = await _adminRepository.GetProductsAsync();

                if (list == null)
                    return NotFound("Not found");
                else
                {
                    return Ok(list);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }

        [HttpGet]
        [Route("Admin/GetOrdersAsync")]
        public async Task<IActionResult> GetOrdersAsync()
        {
            try
            {
                var list = await _adminRepository.GetOrdersAsync();
                if (list == null)
                    return NotFound("Not found");
                else
                {
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
        [Route("Admin/UpdateOrdersAsync")]
        public async Task<IActionResult> UpdateOrdersAsync([FromBody] OrderViewModel order)
        {
            try
            {
                await _adminRepository.UpdateOrderAsync(order);
                return Ok("Successfully updated");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }

        [HttpPut]
        [Route("Admin/EditProductAsync")]
        public async Task<IActionResult> EditProductAsync([FromBody] Product product)
        {
            try
            {
                await _adminRepository.EditProductAsync(product);
                return Ok("Product has been edited");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }

        [HttpPost]
        [Route("Admin/CreateProductAsync")]
        public async Task<IActionResult> CreateProductAsync([FromBody] Product product)
        {
            try
            {
                await _adminRepository.CreateProductAsync(product);
                return Ok("A new product has been created!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }

        [HttpPost]
        [Route("Admin/DeleteProductAsync")]
        public async Task<IActionResult> DeleteProductAsync([FromBody] Product product)
        {
            try
            {
                await _adminRepository.DeleteProductAsync(product.Id);
                return Ok("Product was successfully deleted!");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, "Sorry, internal server error");
            }
        }
    }
}
