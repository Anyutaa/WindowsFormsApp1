#pragma once
#include "pch.h"
#include "utils.h"
#include "Product.h"
#include "Online_product.h"

class Shop
{
	vector<shared_ptr<Product>> shop;
    
public:
    template<class Archive>
    void serialize(Archive& ar, const unsigned int version)
    {
        ar& shop;
    }
    void AddProduct(std::shared_ptr<Product> product);
    std::shared_ptr<Product> GetProduct(int id) const;
    void ClearProducts();
    int GetSize() const;
    void Writing_to_file_product(const string& filename);
    void Read_from_file_product(const string& filename);
    void Delete(int id);
    
};