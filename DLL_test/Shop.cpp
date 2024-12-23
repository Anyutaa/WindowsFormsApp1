#include "pch.h"
#include "Shop.h"

#include <sstream>

#include <cstring>
#include <iostream>

void Shop::AddProduct(std::shared_ptr<Product> product) {
    shop.push_back(product);
}

std::shared_ptr<Product> Shop::GetProduct(int id) const {
    if (id < 0 || id >= shop.size()) return nullptr;
    return shop[id];
}

void Shop::ClearProducts() {
    shop.clear();
}

int Shop::GetSize() const {
    return shop.size();
}

void Shop::Delete(int id) {
    if (id >= 0 && id < shop.size()) {
        shop.erase(shop.begin() + id);
    }
}


void Shop::Writing_to_file_product(const string& filename)
{
    try {
        ifstream fin(filename);
        if (!fin) {
            cerr << "Не удалось открыть файл для загрузки." << endl;
            return;
        }
        boost::archive::text_iarchive ia(fin);
        shop.clear();
        ia >> shop;
        cout << "Продукты успешно загружены из файла: " << filename << endl;
    }
    catch (const exception& e) {
        cerr << "Ошибка при загрузке файла: " << e.what() << endl;
        shop.clear();
    }
}

void Shop::Read_from_file_product(const string& filename)
{
    try {
        ofstream fout(filename);
        if (!fout) {
            cerr << "Не удалось открыть файл для записи." << endl;
            return;
        }
        boost::archive::text_oarchive oa(fout);
        oa << shop;
        cout << "Продукты успешно сохранены в файл: " << filename << endl;
    }
    catch (const exception& e) {
        cerr << "Ошибка при сохранении файла: " << e.what() << endl;
    }
}

//void Shop::Delete_product()
//{
//	shop.clear();
//	cout << "Все продукты удалены" << endl;
//}