using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Data;
using SelfOrderSystem.Services;

namespace SelfOrderSystem.Controllers;
public class CartController : Controller {

    private readonly AppDbContext _db;         // DBへ問い合わせるためのフィールド
    private readonly CartService _cart;        // カート操作用

    public CartController(AppDbContext db, CartService cart) {
        _db = db;          // DIで受け取る
        _cart = cart;
    }

    public IActionResult Index() {
        return View(_cart.GetItems()); //Sessionのカート一覧をViewへ返す
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Add(int productId) {
        var product = await _db.Products
            .AsNoTracking()
            .SingleOrDefaultAsync(p => p.Id == productId && p.IsActive);
        if (product == null) {
            return NotFound();
        }

        if (product.IsSoldOut) {
            TempData["Error"] = "この商品は売り切れです";
            return RedirectToAction("Index", "Menu");
        }
        _cart.Add(product);
        return RedirectToAction("Index", "Menu");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Update(int productId, int quantity) {
        _cart.SetQuantity(productId, quantity); //指定商品の数量を変更
        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Remove(int productId) {
        _cart.Remove(productId);
        return RedirectToAction(nameof(Index));
    }
}

