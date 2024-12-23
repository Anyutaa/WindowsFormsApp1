#include "pch.h"
#include "Shop.h"
#include "Product.h"
#include "Online_product.h"

Shop myshop;

struct product_struct {
    char name_product[256];
    double price;
    int manufacture_year, manufacture_month, manufacture_day;
    int valid_until_year, valid_until_month, valid_until_day;
    int quantity_of_product;
    char link[256];
};

extern "C" {
    __declspec(dllexport) void __stdcall Load(const char* filename) {
        myshop.Writing_to_file_product(filename);
    }

    __declspec(dllexport) void __stdcall Save(const char* filename) {
        myshop.Read_from_file_product(filename);
    }

    __declspec(dllexport) void Clear() {
        myshop.ClearProducts();
    }

    __declspec(dllexport) void AddProduct(int param) {
        if (param == 0) {
            // Обычный продукт
            auto product = std::make_shared<Product>();
            product->setName("");
            product->setPrice(0.0);
            product->setmanufacture_year(0);
            product->setmanufacture_month(0);
            product->setmanufacture_day(0);
            product->setvalid_until_year(0);
            product->setvalid_until_month(0);
            product->setvalid_until_day(0);
            product->setQuantity(0);
            myshop.AddProduct(product);
        }
        else {
            // Онлайн продукт
            auto online_product = std::make_shared<Online_product>();
            online_product->setName("");
            online_product->setPrice(0.0);
            online_product->setmanufacture_year(0);
            online_product->setmanufacture_month(0);
            online_product->setmanufacture_day(0);
            online_product->setvalid_until_year(0);
            online_product->setvalid_until_month(0);
            online_product->setvalid_until_day(0);
            online_product->setQuantity(0);
            online_product->setLink("");
            myshop.AddProduct(online_product);
        }
    }

    __declspec(dllexport) void UpdateProduct(product_struct& prod_struct, int id) {
        auto product = myshop.GetProduct(id);
        if (!product) return;

        product->setName(prod_struct.name_product);
        product->setPrice(prod_struct.price);

        product->setmanufacture_year(prod_struct.manufacture_year);
        product->setmanufacture_month(prod_struct.manufacture_month);
        product->setmanufacture_day(prod_struct.manufacture_day);
        product->setvalid_until_year(prod_struct.valid_until_year);
        product->setvalid_until_month(prod_struct.valid_until_month);
        product->setvalid_until_day(prod_struct.valid_until_day);

        product->setQuantity(prod_struct.quantity_of_product);

        if (auto online_product = dynamic_cast<Online_product*>(product.get())) {
            online_product->setLink(prod_struct.link);
        }
    }

    __declspec(dllexport) void GetProduct(product_struct& prod_struct, int id) {
        auto product = myshop.GetProduct(id);
        if (!product) return;

        strncpy_s(prod_struct.name_product, product->getName().c_str(), sizeof(prod_struct.name_product));
        prod_struct.price = product->getPrice();

        prod_struct.manufacture_year = product->getmanufacture_year();
        prod_struct.manufacture_month = product->getmanufacture_month();
        prod_struct.manufacture_day = product->getmanufacture_day();
        prod_struct.valid_until_year = product->getvalid_until_year();
        prod_struct.valid_until_month = product->getvalid_until_month();
        prod_struct.valid_until_day = product->getvalid_until_day();


        prod_struct.quantity_of_product = product->getQuantity();

        if (auto online_product = dynamic_cast<Online_product*>(product.get())) {
            strncpy_s(prod_struct.link, online_product->getLink().c_str(), sizeof(prod_struct.link));
        }
    }

    __declspec(dllexport) int GetSize() {
        return myshop.GetSize();
    }

    __declspec(dllexport) void DeleteProduct(int id) {
        myshop.Delete(id);
    }
}
