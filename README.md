**ProductInfo Response Schema**
```ts
name: string,
ingredients: string,
asin: string,
generalOffers: GeneralOffer[],
sellerSpecificOffers: SellerOffer[], 
wasFound: boolean
```

**GeneralOffer[]**
```ts
[
    {
        reviewRating: string,
        reviewCount: string,
        price: string,
        link: string,
        title: string
    },
    ...
]
```

**SellerOffer[]**
```ts
[
    {
        productPrice: string,
        productCondition: string,
        shipsFrom: string,
        seller: string,
        sellerLink: string,
        sellerStarRating: string,
        sellerStarRatingInfo: string,
        currency: string,
        deliveryPrice: string,
        deliveryTime: string
    },
    ...
]
```

**ProductDetails**
- `name: string` - The name of the product.
- `ingredients: string` - Ingredients, if applicable.
- `asin: string` - Amazon Standard Identification Number, if available.
- `generalOffers: GeneralOffer[]` - List of general offers when ASIN is not found.
- `sellerSpecificOffers: SellerOffer[]` - List of specific seller offers when ASIN is found.
- `wasFound: boolean` - Indicates if the ASIN was found in the database.

**GeneralOffer**
- `reviewRating: string` - Average rating of the product based on reviews.
- `reviewCount: string` - Number of reviews the product has received.
- `price: string` - Price of the product.
- `link: string` - URL to the product page on Amazon.
- `title: string` - Title of the product listing.

**SellerOffer**
- `productPrice: string` - Price offered by the seller.
- `productCondition: string` - Condition of the product (new, used, etc.).
- `shipsFrom: string` - Location from which the product ships.
- `seller: string` - Name of the seller.
- `sellerLink: string` - URL to the seller's profile on Amazon.
- `sellerStarRating: string` - Seller's average star rating.
- `sellerStarRatingInfo: string` - Additional information about the seller's rating.
- `currency: string` - Currency in which the price is listed.
- `deliveryPrice: string` - Cost of delivery.
- `deliveryTime: string` - Estimated time of delivery.

**APIs Used in the ScanController**

1. **Real-Time Amazon Data API**
   - RapidAPI Link: [Real-Time Amazon Data](https://rapidapi.com/letscrape-6bRBa3QguO5/api/real-time-amazon-data)
   - Description: Provides real-time pricing, offers, and product data from Amazon.

2. **Big Product Data API**
   - RapidAPI Link: [Big Product Data](https://rapidapi.com/bigproductdata/api/big-product-data)
   - Description: Access to product data including ingredients, barcodes, and more.

3. **UPCitemdb API**
   - API Explorer: [UPCitemdb API Explorer](https://www.upcitemdb.com/api/explorer#!/lookup/get_trial_lookup)
   - Description: Offers product lookup by UPC to fetch product titles, ASIN, and other details.

4. **Open Pet Food Facts**
   - Website: [Open Pet Food Facts](https://us.openpetfoodfacts.org/)
   - Description: Open database of pet food ingredients, with product details accessible via API.
