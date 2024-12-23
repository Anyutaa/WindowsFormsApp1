#pragma once
#include "pch.h"
#include "Product.h"

class Online_product : public Product {
	friend class boost::serialization::access;
	string link = "None";
public:

	void setLink(const string& link_product) { link = link_product; }

	string getLink() const { return link; }

	BOOST_SERIALIZATION_SPLIT_MEMBER();
	virtual ~Online_product() {}

	//virtual void Input(istream& in) override;
	//virtual void Output(ostream& out) override;

	template<class Archive>
	void save(Archive& ar, const unsigned int version) const
	{
		ar& boost::serialization::base_object<Product>(*this);
		ar& link;
	}

	template<class Archive>
	void load(Archive& ar, const unsigned int version)
	{
		ar& boost::serialization::base_object<Product>(*this);
		ar& link;

	}

};
BOOST_CLASS_VERSION(Online_product, 1);



