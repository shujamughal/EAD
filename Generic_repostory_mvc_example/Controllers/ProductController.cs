using Generic_repostory_mvc_example.Models.Interfaces;
using Generic_repostory_mvc_example.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Generic_repostory_mvc_example.Models.Repositories;

namespace Generic_repostory_mvc_example.Controllers
{
    public class ProductController : Controller
    {
        private readonly IRepository<Product> _productRepository;
        IRepository<Product> productRepository = new GenericRepository<Product>("connectionString");

        public ProductController(IRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var products = _productRepository.GetAll();
            return View(products);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Add(product);
                productRepository.Add(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Edit(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                _productRepository.Update(product);
                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public IActionResult Delete(int id)
        {
            _productRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
