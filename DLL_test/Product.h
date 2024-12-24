#pragma once
#include "pch.h"

class Product
{
	friend class boost::serialization::access;

	string name_product = "None";
	double price = 0;
	int manufacture_year = 0;
	int manufacture_month = 0;
	int manufacture_day = 0;
	int valid_until_year = 0;
	int valid_until_month = 0;
	int valid_until_day = 0;
	int quantity_of_product = 0;
	bool availability = 1;

	template<class Archive>
	void serialize(Archive& ar, const unsigned int version)
	{
		ar& name_product;
		ar& price;
		ar& manufacture_year;
		ar& manufacture_month;
		ar& manufacture_day;
		ar& valid_until_year;
		ar& valid_until_month;
		ar& valid_until_day;
		ar& quantity_of_product;
		ar& availability;
	}
public:
	std::string getName() const { return name_product; }
	double getPrice() const { return price; }
	int getmanufacture_year() const { return manufacture_year; }
	int getmanufacture_month() const { return manufacture_month; }
	int getmanufacture_day() const { return manufacture_day; }
	int getvalid_until_year() const { return valid_until_year; }
	int getvalid_until_month() const { return valid_until_month; }
	int getvalid_until_day() const { return valid_until_day; }
	int getQuantity() const { return quantity_of_product; }
	bool isAvailable() const { return availability; }

	void setName(const std::string& name) { name_product = name; }
	void setPrice(double new_price) { price = new_price; }
	void setmanufacture_year(int new_manufacture_year) { manufacture_year = new_manufacture_year; }
	void setmanufacture_month(int new_manufacture_month) { manufacture_month = new_manufacture_month; }
	void setmanufacture_day(int new_manufacture_day) { manufacture_day = new_manufacture_day; }
	void setvalid_until_year(int new_valid_until_year) { valid_until_year = new_valid_until_year; }
	void setvalid_until_month(int new_valid_until_month) { valid_until_month = new_valid_until_month; }
	void setvalid_until_day(int new_valid_until_day) { valid_until_day = new_valid_until_day; }
	void setQuantity(int quantity) { quantity_of_product = quantity; }
	void setAvailability(bool is_available) { availability = is_available; }
	/*virtual void Input(istream& in);
	virtual void Output(ostream& out);*/
	virtual ~Product() = default;

};