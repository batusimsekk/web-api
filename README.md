# 📦 Product API – Basit ASP.NET Core Web API Projesi

Bu proje, ASP.NET Core Web API kullanılarak oluşturulmuş basit bir ürün yönetimi (CRUD) uygulamasıdır.  
`ProductController` üzerinden ürünleri listeleyebilir, ekleyebilir, güncelleyebilir ve silebilirsiniz.  
Veriler geçici olarak bellekte (`static List<Product>`) tutulur, veritabanı bağlantısı yoktur.

---

## 🚀 Kullanılan Teknolojiler

- .NET 8
- ASP.NET Core Web API
- C#

---

## 📁 Endpoint’ler

### ✅ Tüm Ürünleri Listele


**Response:**
```json
[
  {
    "id": 1,
    "name": "Kalem",
    "price": 10.5,
    "category": "Kırtasiye"
  }
]


🔍 Belirli ID'li Ürünü Getir
bash
Kopyala
Düzenle

GET /api/product/{id}


➕ Yeni Ürün Ekle

POST /api/product


✏️ Ürün Güncelle
bash
Kopyala
Düzenle

PUT /api/product/{id}


❌ Ürün Sil
DELETE /api/product/{id}


🧪 Test Etme
Bu API'yi test etmek için:

Postman veya Swagger UI kullanabilirsiniz.


⚠️ Notlar
API geçici bellekte çalışır. Uygulama kapatıldığında tüm veriler sıfırlanır.

Aşağıdaki Product sınıfı tanımlı olmalıdır:

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public string Category { get; set; }
}
