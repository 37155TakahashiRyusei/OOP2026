using Microsoft.AspNetCore.Http;
using SelfOrderSystem.Models;

namespace SelfOrderSystem.Services;
public class CartService {
    private const string CartKey = "CART";                       // Sessionのキー 
    private readonly IHttpContextAccessor _httpContextAccessor;
    public CartService(IHttpContextAccessor httpContextAccessor) {
        _httpContextAccessor = httpContextAccessor;
    }

    private ISession Session => _httpContextAccessor.HttpContext?.Session
           ?? throw new InvalidOperationException("Sessionを取得できません");

    public List<CartItem> GetItems() {
        return Session.GetObject<List<CartItem>>(CartKey)
               ?? new List<CartItem>();
    }

    public void Add(Product product) { ///商品を一件追加
        var items = GetItems();
        var item = items.SingleOrDefault(x => x.ProductId == product.Id);
        if (item == null) {
            items.Add(new CartItem {
                ProductId = product.Id,
                ProductName = product.Name,
                UnitPrice = product.Price,
                Quantity = 1
            });
        } else {
            item.Quantity++;
        }
        Save(items);
    }

    public void SetQuantity(int productId, int quantity) {
        var items = GetItems();
        var item = items.SingleOrDefault(x => x.ProductId == productId);
        if (item == null) {
            return;
        }
        item.Quantity = Math.Clamp(quantity, 1, 99);
        Save(items);
    }

    public void Remove(int productId) {
        var items = GetItems();
        items.RemoveAll(x => x.ProductId == productId);
        Save(items);
    }

    public void Clear() {
        Session.Remove(CartKey);
    }

    private void Save(List<CartItem> items) {
        Session.SetObject(CartKey, items);
    }
}

