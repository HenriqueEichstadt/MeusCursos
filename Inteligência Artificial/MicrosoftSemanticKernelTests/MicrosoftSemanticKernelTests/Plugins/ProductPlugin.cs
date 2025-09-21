using Microsoft.SemanticKernel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftSemanticKernelTests.Plugins
{
    public class ProductPlugin
    {
        private readonly List<Product> _products =
        [
            new(1, "Mousepad", true, 10),
            new(2, "Mouse Gamer", true, 8),
            new(3, "Teclado Gamer", true, 1),
            new(4, "Capa Monitor", false, 1),
            new(5, "Monitor Gamer", true, 5),
        ];

        [KernelFunction("get_products")]
        [Description("Returns list of products")]
        public async Task<List<Product>> GetProductsAsync()
        {
            await Task.Delay(1);
            return _products;
        }

        [KernelFunction("get_state")]
        [Description("Get the state of a particular product")]
        public async Task<Product?> GetStateAsync([Description("The ID of the product")] int id)
        {
            await Task.Delay(1);
            return _products.FirstOrDefault(p => p.Id == id);
        }


        [KernelFunction("change_state")]
        [Description("Change the state of the product")]
        public async Task<Product?> ChangeStateAsync(
            [Description("The ID of the product")] int id,
            [Description("The content of the product to be modified")] Product model)
        {
            await Task.Delay(1);
            var product = _products.FirstOrDefault(p => p.Id == id);

            if (product == null)
                return null;

            product = new Product(model.Id, model.Title, model.IsActive, model.QuantityOnHand);

            return product;
        }
    }
}

public record Product(int Id, string Title, bool IsActive, int QuantityOnHand);