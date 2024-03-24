using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.Xml.Linq;

namespace ProductSearch_demo
{
    internal class Program
    {
        private static HttpClient client = new HttpClient();
        static void Main(string[] args)
        {

            string jsonString = @"{
  ""job_id"": ""660047ae40a8de4e13019847"",
  ""status"": ""finished"",
  ""results"": [
    {
      ""updated_at"": ""2024-03-24T15:33:59.083Z"",
      ""query"": {
        ""max_age"": 1200,
        ""max_pages"": 1,
        ""value"": ""the honest kitchen"",
        ""key"": ""term"",
        ""country"": ""de"",
        ""topic"": ""search_and_offers"",
        ""source"": ""amazon""
      },
      ""content"": {
        ""offers"": [
          {
            ""price"": 191.5,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 1,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/81ThOYxYtjL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Honest-Kitchen-Preference-Base-Mix-Food/dp/B00A8O8NSY/ref=sr_1_1?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Honest-Kitchen-Preference-Base-Mix-Food/dp/B00A8O8NSY/ref=sr_1_1"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B00A8O8NSY"",
            ""name"": ""The Honest Kitchen Preference: Base-Mix Dog Food, 7 lb by The Honest Kitchen""
          },
          {
            ""price"": 165.71,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 1,
            ""review_rating"": 84,
            ""image"": ""https://m.media-amazon.com/images/I/814BBa85BpL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Honest-Kitchen-Superfood-OversTM-5-5oz/dp/B07DFW8H2V/ref=sr_1_2?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-2"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Honest-Kitchen-Superfood-OversTM-5-5oz/dp/B07DFW8H2V/ref=sr_1_2"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-2"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B07DFW8H2V"",
            ""name"": ""Honest Kitchen The Superfood Pour Overs Nassdekoration für Hunde, 156 ml, Hühnereintopf, 12 Stück""
          },
          {
            ""price"": 153.32,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 6,
            ""review_rating"": 86,
            ""image"": ""https://m.media-amazon.com/images/I/71wj+ewQXpL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Honest-Kitchen-dehydrierte-Welpenfutter-Hundefutter/dp/B00JQEHOH8/ref=sr_1_3?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-3"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Honest-Kitchen-dehydrierte-Welpenfutter-Hundefutter/dp/B00JQEHOH8/ref=sr_1_3"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-3"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B00JQEHOH8"",
            ""name"": ""Honest Kitchen The Echthaar Grade dehydrierte Welpenfutter Hundefutter""
          },
          {
            ""price"": 11.55,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 182,
            ""review_rating"": 90,
            ""image"": ""https://m.media-amazon.com/images/I/81hiu5t59IL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Lilys-Kitchen-Farmhouse-Kartoffeln-Trockenfutter/dp/B09HLJ4GZN/ref=sr_1_4?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-4"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Lilys-Kitchen-Farmhouse-Kartoffeln-Trockenfutter/dp/B09HLJ4GZN/ref=sr_1_4"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-4"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B09HLJ4GZN"",
            ""name"": ""Lily‘s Kitchen Trocken Hundefutter für ausgewachsene Hunde (1kg) Rind, Kartoffeln, Roggen und Dinkel""
          },
          {
            ""price"": 26.55,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 12,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/6128J4CRA7L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/HONEST-Refillable-Adjustable-Intensity-Fireplace/dp/B0CB5VBHFG/ref=sr_1_5?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-5"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/HONEST-Refillable-Adjustable-Intensity-Fireplace/dp/B0CB5VBHFG/ref=sr_1_5"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-5"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CB5VBHFG"",
            ""name"": ""HONEST Triple Jet Torch Lighter Built-in Punch Visible Gas Window Refillable Gas Adjustable Flame Intensity Pocket Lighter Gift for Men BBQ Kitchen Fireplace Candle (Carbon Wrap)""
          },
          {
            ""price"": 448.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/51UV3JY3BoL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/NMDCDH-Wandbehang-Flaschenhalter-Wandmontage-Wandregale/dp/B095RKTFH1/ref=sr_1_6?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-6"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/NMDCDH-Wandbehang-Flaschenhalter-Wandmontage-Wandregale/dp/B095RKTFH1/ref=sr_1_6"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-6"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B095RKTFH1"",
            ""name"": ""NMDCDH Wandbehang Weinregal Metall Flaschenhalter Lagerung Wandmontage | Weinglas Becher Stemware Halter | Wandregale aus nordischem Gold und weißem Holz für Bar Kitchen oder Hone Wall De""
          },
          {
            ""price"": 12.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 6,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/61FQJMxJJuS._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/SUPER-KITCHEN-rutschfest-Teigschaber-Tortenkruste/dp/B082H948D7/ref=sr_1_7?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-7"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/SUPER-KITCHEN-rutschfest-Teigschaber-Tortenkruste/dp/B082H948D7/ref=sr_1_7"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-7"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B082H948D7"",
            ""name"": ""SUPER KITCHEN Extra Dick Rutschfeste Backunterlage Antihafte Backmatte Silikon Groß Teigunterlage Ausrollmatte XL Silikonmatte Dauerbackfolie Teigmatte mit Teigschneider, Fondant Pizza Matte 60 x 40cm""
          },
          {
            ""price"": 90.96,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/41WceZH1qSL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Yalych-Chopsticks-Tableware-Chopstick-Stifthalter/dp/B0BV6J9CLT/ref=sr_1_8?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-8"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Yalych-Chopsticks-Tableware-Chopstick-Stifthalter/dp/B0BV6J9CLT/ref=sr_1_8"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-8"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0BV6J9CLT"",
            ""name"": ""Yalych Utensil Caddy Chopsticks Holder Cutlery Storage Box with Lid Tableware Box Dust Drain Rack Chopstick Cage Kitchen Hone Drying Tools Stifthalter (Color : White)""
          },
          {
            ""price"": 49.71,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 1,
            ""review_rating"": 88,
            ""image"": ""https://m.media-amazon.com/images/I/71KO4UhsUuL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Lilys-Kitchen-Trockenfutter-H%C3%BChnerfleisch-Vollwertnahrung/dp/B01LEODOXU/ref=sr_1_9?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-9"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Lilys-Kitchen-Trockenfutter-H%C3%BChnerfleisch-Vollwertnahrung/dp/B01LEODOXU/ref=sr_1_9"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-9"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01LEODOXU"",
            ""name"": ""Lily's Kitchen Natürliches Trockenfutter für ausgewachsene Katzen Schmortopf mit Huhn, getreidefreies Rezept (4 x 800g Pack)""
          },
          {
            ""price"": 36.24,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 459,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/91dtxF8-LuL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/HONEST-WEAVE-GOTS-zertifizierte-Bio-Baumwolle-Geschirrt%C3%BCcher-Set/dp/B08J156XKX/ref=sr_1_10?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-10"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/HONEST-WEAVE-GOTS-zertifizierte-Bio-Baumwolle-Geschirrt%C3%BCcher-Set/dp/B08J156XKX/ref=sr_1_10"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-10"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08J156XKX"",
            ""name"": ""HONEST WEAVE GOTS-zertifizierte Bio-Baumwolle, Hand- und Geschirrtücher-Set – Übergröße 50,8 x 76,2 cm, vollständig gesäumt, in Designer-Farben, 6er-Pack, Salbeigrün gestreift""
          },
          {
            ""price"": 35.46,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 816,
            ""review_rating"": 90,
            ""image"": ""https://m.media-amazon.com/images/I/61smzT+TeAS._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/JML-Fast-Thaw-1-Schneidebrett-Schneidebrett/dp/B0924SRFJN/ref=sr_1_11?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-11"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/JML-Fast-Thaw-1-Schneidebrett-Schneidebrett/dp/B0924SRFJN/ref=sr_1_11"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-11"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0924SRFJN"",
            ""name"": ""JML Fast Thaw 4-in-1-Schneidebrett – das schnelle Auftauen von Schneidebrett, das auch als Messer-Honer- und Gewürzmühle geeignet ist.""
          },
          {
            ""price"": 40.07,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 267,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/71nNGzdlc3L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/HONEST-WEAVE-GOTS-zertifizierte-Baumwolle-Geschirrhandtuch-Sets/dp/B08J1GJP73/ref=sr_1_12?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-12"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/HONEST-WEAVE-GOTS-zertifizierte-Baumwolle-Geschirrhandtuch-Sets/dp/B08J1GJP73/ref=sr_1_12"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-12"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08J1GJP73"",
            ""name"": ""HONEST WEAVE GOTS-zertifizierte 100% Bio-Mehl Sack Baumwolle Küche Hand und Geschirrhandtuch-Sets – Extra Groß 68,6 x 68,6 cm, voll gesäumt, 12 Stück, Naturbraun""
          },
          {
            ""price"": 13.83,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 6,
            ""review_rating"": 84,
            ""image"": ""https://m.media-amazon.com/images/I/71OKJylarQL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfbXRmOjIwMDgzNjk5NDIyNzk4OjowOjo&url=%2FTortilla-W%25C3%25A4rmer-Burritos-Isolationsbeutel-Picknicktasche-Thermotasche-mexikanischen-Mehrzweck-Thermotasche%2Fdp%2FB0BC8H99ZD%2Fref%3Dsr_1_13_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-13-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9tdGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfbXRmOjIwMDgzNjk5NDIyNzk4OjowOjo&url=%2FTortilla-W%25C3%25A4rmer-Burritos-Isolationsbeutel-Picknicktasche-Thermotasche-mexikanischen-Mehrzweck-Thermotasche%2Fdp%2FB0BC8H99ZD%2Fref%3Dsr_1_13_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-13-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9tdGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0BC8H99ZD"",
            ""name"": ""Tortilla-Wärmer, Taco Hamburger Burritos-Isolationsbeutel, Picknicktasche-Thermotasche, warm halten, im mexikanischen Stil, Mehrzweck-Thermotasche, für Taco Hamburger Burritos Tortilla (Schwarz)""
          },
          {
            ""price"": 30.19,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 2,
            ""review_rating"": 84,
            ""image"": ""https://m.media-amazon.com/images/I/71mW0HhXWkL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfbXRmOjIwMDY3MDk2NTI5NTAxOjowOjo&url=%2FLilys-Kitchen-XCCMP01%2Fdp%2FB071RTL5PK%2Fref%3Dsr_1_14_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-14-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9tdGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfbXRmOjIwMDY3MDk2NTI5NTAxOjowOjo&url=%2FLilys-Kitchen-XCCMP01%2Fdp%2FB071RTL5PK%2Fref%3Dsr_1_14_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-14-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9tdGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B071RTL5PK"",
            ""name"": ""Lily's Kitchen Natürliches, zartes Pasteten-Nassfutter für ausgewachsene Katzen, Schalen, getreidefreie Rezepte, verschiedene Sorten (32 x 85g schalen)""
          },
          {
            ""price"": 14.49,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 4,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/71+9Bq+Zv9L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfbXRmOjIwMDIxNDUyNTEwMTA4OjowOjo&url=%2FMjAMjAM-Mixpaket-Huhn-Rind-Herzen%2Fdp%2FB07D1G1J1Y%2Fref%3Dsr_1_15_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-15-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9tdGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfbXRmOjIwMDIxNDUyNTEwMTA4OjowOjo&url=%2FMjAMjAM-Mixpaket-Huhn-Rind-Herzen%2Fdp%2FB07D1G1J1Y%2Fref%3Dsr_1_15_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-15-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9tdGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B07D1G1J1Y"",
            ""name"": ""MjAMjAM - Premium Nassfutter für Katzen - Mixpaket I - Huhn, Rind, Herzen, 6er Pack (6 x 400 g), getreidefrei mit extra viel Fleisch""
          },
          {
            ""price"": 32.34,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 3,
            ""review_rating"": 100,
            ""image"": ""https://m.media-amazon.com/images/I/61XXIx2F-OL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Hon-Lally-Wikingerg%C3%B6ttin-heidnisches-Buchst%C3%BCtzen-Buchst%C3%A4nder/dp/B09HPMLW21/ref=sr_1_16?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-16"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Hon-Lally-Wikingerg%C3%B6ttin-heidnisches-Buchst%C3%BCtzen-Buchst%C3%A4nder/dp/B09HPMLW21/ref=sr_1_16"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-16"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B09HPMLW21"",
            ""name"": ""Hon-Lally Nordische Wikingergöttin Wicca Wicca heidnisches Muster Holz Buchstützen dekorative Buchstütze rutschfest Büro Buchständer für Bücher Büro Akten Magazin""
          },
          {
            ""price"": 13.88,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 12,
            ""review_rating"": 80,
            ""image"": ""https://m.media-amazon.com/images/I/5154teD3oQL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/DinoK-Wetzstahl-Professionelle-Messersch%C3%A4rfer-Fleischermesser/dp/B01II0FV8O/ref=sr_1_17?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-17"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/DinoK-Wetzstahl-Professionelle-Messersch%C3%A4rfer-Fleischermesser/dp/B01II0FV8O/ref=sr_1_17"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-17"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01II0FV8O"",
            ""name"": ""DinoK - Diamant 26cm Wetzstahl Oval - Professionelle Messerschärfer, Köche, die beste Wahl für die Küche und Honen Fleischermesser""
          },
          {
            ""price"": 7.19,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/41wJIp-V88S._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Honing-Sharpener-Wetzstahl-Butcher-Kitchen/dp/B0CPYHFDLC/ref=sr_1_18?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-18"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Honing-Sharpener-Wetzstahl-Butcher-Kitchen/dp/B0CPYHFDLC/ref=sr_1_18"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-18"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CPYHFDLC"",
            ""name"": ""Honing Rod Daily Honing Steel Knife Sharpener Rod Wetzstahl Rod Stick Butcher Tool Hone Bar Kitchen Blade Knife Sharpener""
          },
          {
            ""price"": 17.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 2,
            ""review_rating"": 84,
            ""image"": ""https://m.media-amazon.com/images/I/61gqjHObWmS._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Yeuligo-Nachf%C3%BCllbar-Sturmfeuerzeug-Sichtbarem-Stabfeuerzeug/dp/B094FVM4JY/ref=sr_1_19?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-19"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Yeuligo-Nachf%C3%BCllbar-Sturmfeuerzeug-Sichtbarem-Stabfeuerzeug/dp/B094FVM4JY/ref=sr_1_19"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-19"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B094FVM4JY"",
            ""name"": ""Yeuligo 2 Stück 15,2cm Jetflamme Feuerzeug, Gas Nachfüllbar Sturmfeuerzeug, Winddicht Langes Stabfeuerzeug für Kerzen, Küche, Camping, Grill, Kamin. Rot und Schwarz(Verkauft ohne Butangas)""
          },
          {
            ""price"": 24.79,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/91YunF0+OUL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/eeBoo-Kitchen-Erwachsene-recyceltem-Karton/dp/B0CV83CNZN/ref=sr_1_20?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-20"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/eeBoo-Kitchen-Erwachsene-recyceltem-Karton/dp/B0CV83CNZN/ref=sr_1_20"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-20"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CV83CNZN"",
            ""name"": ""eeBoo Pink Kitchen Erwachsene, recyceltem Karton – Puzzle 1000 Teile La Cuisine Rosa – PZTPNK""
          },
          {
            ""price"": 25.79,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/61xvA5uYBwL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Kaffeekanne-Abnehmbare-Edelstahl-Tropfkaffeemaschine-Infuser-Office-Nutzung/dp/B08SQCY732/ref=sr_1_21?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-21"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Kaffeekanne-Abnehmbare-Edelstahl-Tropfkaffeemaschine-Infuser-Office-Nutzung/dp/B08SQCY732/ref=sr_1_21"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-21"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08SQCY732"",
            ""name"": ""Viccilley Kaffeekanne Abnehmbare Edelstahl-Tropfkaffeemaschine Infuser für Hone Kitchen Office-Nutzung(schwarz)""
          },
          {
            ""price"": 13.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/61rMsSxzLUL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/YANGSHINE-Mini-Topfblumen-handgefertigt-Pflaumenbl%C3%BCten-Armaturenbrett/dp/B0CMPQ7MRB/ref=sr_1_22?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-22"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/YANGSHINE-Mini-Topfblumen-handgefertigt-Pflaumenbl%C3%BCten-Armaturenbrett/dp/B0CMPQ7MRB/ref=sr_1_22"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-22"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CMPQ7MRB"",
            ""name"": ""YANGSHINE Künstliche Mini-Topfblumen, handgefertigt, gehäkelt, handgestrickt, Pflaumenblüten für Hone, Büro, Auto, Armaturenbrett, Dekoration, Rosa, 3 Stück""
          },
          {
            ""price"": 22.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/71IwlbWufrL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Metallschild-Personalisiertes-Fitness-Paar-Team-Fitness-Studio-Paar-Blechschilder/dp/B0CP8TJ8PP/ref=sr_1_23?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-23"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Metallschild-Personalisiertes-Fitness-Paar-Team-Fitness-Studio-Paar-Blechschilder/dp/B0CP8TJ8PP/ref=sr_1_23"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-23"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CP8TJ8PP"",
            ""name"": ""Metallschild Personalisiertes Fitness-Paar Wir Sind Ein Team-Fitness-Studio-Paar Für Coffee Shop Kitchen Hone Bar Blechschild Lustiges Blechschilder Aluminium Metallschild M""
          },
          {
            ""price"": 23.29,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/61xvA5uYBwL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Kuuleyn-Tropffilterkanne-Kaffeemaschinentopf-Kaffeefilterkaffeekanne-Tropfkaffeemaschine/dp/B0C2CBKKC3/ref=sr_1_24?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-24"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Kuuleyn-Tropffilterkanne-Kaffeemaschinentopf-Kaffeefilterkaffeekanne-Tropfkaffeemaschine/dp/B0C2CBKKC3/ref=sr_1_24"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-24"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0C2CBKKC3"",
            ""name"": ""Kuuleyn Kaffee Tropffilterkanne, Kaffeemaschinentopf Im Vietnamesischen Stil, Vietnamesische Kaffeefilterkaffeekanne 304 Edelstahl Tropfkaffeemaschine Infuser Für Hone Kitchen(Schwarz)""
          },
          {
            ""price"": 21.08,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/61a4T90Br-L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Vietnamesische-Kaffeemaschine-Edelstahl-Kaffeekessel-Verwendung/dp/B08SHLCYQM/ref=sr_1_25?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-25"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Vietnamesische-Kaffeemaschine-Edelstahl-Kaffeekessel-Verwendung/dp/B08SHLCYQM/ref=sr_1_25"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-25"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08SHLCYQM"",
            ""name"": ""Vietnamesische Kaffeemaschine Filter Set, Edelstahl Kaffeekessel Kaffee Tropfer Tasse für Hone Kitchen Office Verwendung(Gold)""
          },
          {
            ""price"": 16.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/51ffIeVR2+L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Rechteckige-Bratpfanne-Stielkasserolle-Aluminiumlegierung-Kunststoffgriff/dp/B09PMZSYK4/ref=sr_1_26?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-26"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Rechteckige-Bratpfanne-Stielkasserolle-Aluminiumlegierung-Kunststoffgriff/dp/B09PMZSYK4/ref=sr_1_26"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-26"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B09PMZSYK4"",
            ""name"": ""Rechteckige Bratpfanne, Antihaft Tamagoyaki Stielkasserolle Aluminiumlegierung Bratpfanne Kunststoffgriff Stielkasserolle für Hone Kitchen""
          },
          {
            ""price"": 10.53,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/71IeAWuyoPL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Produce-Inspirational-Adhesive-Organizer-Decoration/dp/B0B6BRFKJP/ref=sr_1_27?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-27"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Produce-Inspirational-Adhesive-Organizer-Decoration/dp/B0B6BRFKJP/ref=sr_1_27"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-27"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0B6BRFKJP"",
            ""name"": ""Honest Hearts Produce Honest Actions Key Holder Inspirational Wall Mount Key Hanger Self Adhesive Key Organizer Rack Retro Mail Sorter Decoration for Kitchen Mudroom Hallway Eingang 7x4 inch""
          },
          {
            ""price"": 7.29,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 2,
            ""review_rating"": 80,
            ""image"": ""https://m.media-amazon.com/images/I/618jw4smvYL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Ledersch%C3%A4rfer-Lederhandwerk-Ledersch%C3%A4rfstreifen-Doppelseitig-Holzbearbeitung/dp/B08LSTQ679/ref=sr_1_28?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-28"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Ledersch%C3%A4rfer-Lederhandwerk-Ledersch%C3%A4rfstreifen-Doppelseitig-Holzbearbeitung/dp/B08LSTQ679/ref=sr_1_28"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-28"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08LSTQ679"",
            ""name"": ""Lederschärfer mit Holzgriff Lederhandwerk Polieren Schärfen Lederschärfstreifen Doppelseitig zum Honen von Leder Holzbearbeitung""
          },
          {
            ""price"": 0,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 8,
            ""review_rating"": 88,
            ""image"": ""https://m.media-amazon.com/images/I/71j9Y+xYjML._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cookbook-Postins-founder-Kitchen-English/dp/B00A8O1ZD4/ref=sr_1_29?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-29"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cookbook-Postins-founder-Kitchen-English/dp/B00A8O1ZD4/ref=sr_1_29"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-29"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B00A8O1ZD4"",
            ""name"": ""Out of Love Cookbook by Lucy Postins founder of The Honest Kitchen by The Honest Kitchen (English manual)""
          },
          {
            ""price"": 1087.33,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 22,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/71IUzYv6I3L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Wusthof-8526-Epicure-6-teilig-schwarz/dp/B08YRWMD5D/ref=sr_1_30?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-30"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Wusthof-8526-Epicure-6-teilig-schwarz/dp/B08YRWMD5D/ref=sr_1_30"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-30"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08YRWMD5D"",
            ""name"": ""WÜSTHOF 8526 Epicure Block Set, 6-teilig, schwarz""
          },
          {
            ""price"": 9.33,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/61N5rfJW1kL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Honest-Kitchen-Inches-Vintage-Picture/dp/B0CD5PGT67/ref=sr_1_31?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-31"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Honest-Kitchen-Inches-Vintage-Picture/dp/B0CD5PGT67/ref=sr_1_31"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-31"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CD5PGT67"",
            ""name"": ""Life Rules Love Honest Silly Kitchen,12 * 8 Inches Vintage Funny Poster Wall Decor Art Gift Retro Picture Metal Sign""
          },
          {
            ""price"": 468.17,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 3,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/91omYN15gcL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-Serie-59953-4-teiliges-Leder-Rollmesser-Set/dp/B01HUGR18K/ref=sr_1_32?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-32"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-Serie-59953-4-teiliges-Leder-Rollmesser-Set/dp/B01HUGR18K/ref=sr_1_32"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-32"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01HUGR18K"",
            ""name"": ""Cangshan W Serie 59953, 4-teiliges Messer-Set mit Roll-Etui aus Leder""
          },
          {
            ""price"": 567.53,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 6,
            ""review_rating"": 100,
            ""image"": ""https://m.media-amazon.com/images/I/914vTcRT8yL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-4-teiliges-Messer-Set-Echtleder-Etui-Silber/dp/B01HUF8Z7W/ref=sr_1_33?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-33"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-4-teiliges-Messer-Set-Echtleder-Etui-Silber/dp/B01HUF8Z7W/ref=sr_1_33"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-33"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01HUF8Z7W"",
            ""name"": ""Cangshan N1 Serie, 4-teiliges Messer-Set mit Echtleder-Etui, Silber""
          },
          {
            ""price"": 548.74,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 27,
            ""review_rating"": 96,
            ""image"": ""https://m.media-amazon.com/images/I/81Ap6VEvE7L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-Serie-59939-Rollmesser-Silber/dp/B01HUF6WHM/ref=sr_1_34?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-34"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-Serie-59939-Rollmesser-Silber/dp/B01HUF6WHM/ref=sr_1_34"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-34"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01HUF6WHM"",
            ""name"": ""Cangshan H1 Serie 59939, 4-teiliges Messer-Set mit Echtleder-Etui, Silber""
          },
          {
            ""price"": 7.39,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/41hrMrzCwKL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Sch%C3%A4rfen-Professional-Metzgerwerkzeug-Messersch%C3%A4rfer-Kitchen/dp/B091262DGF/ref=sr_1_35?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-35"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Sch%C3%A4rfen-Professional-Metzgerwerkzeug-Messersch%C3%A4rfer-Kitchen/dp/B091262DGF/ref=sr_1_35"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-35"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B091262DGF"",
            ""name"": ""Schärfen von Stahl, BiuZi Professional Rod Stick Metzgerwerkzeug Hone Bar Blade Messerschärfer für Master Chef Knife Rod oder Stick für Kitchen Home""
          },
          {
            ""price"": 219.42,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/518ksRK8KaL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Messer-Sharpener-Sharpens-Polishes-Standard/dp/B0B1PKZCJM/ref=sr_1_36?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-36"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Messer-Sharpener-Sharpens-Polishes-Standard/dp/B0B1PKZCJM/ref=sr_1_36"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-36"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0B1PKZCJM"",
            ""name"": ""Messer Sharpener - Upgrade Made of Full Metal Bracket - Sharpens Hones Polishes Beveled Blades Standard Klingen Chef's Messer - Safe to Use Kitchen Tools by 2 Pieces""
          },
          {
            ""price"": 301.49,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 8,
            ""review_rating"": 100,
            ""image"": ""https://m.media-amazon.com/images/I/61kMuww3WLL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-61871-geschmiedet-Messer-Set-kupferplattiert/dp/B01LXT7YTO/ref=sr_1_37?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-37"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-61871-geschmiedet-Messer-Set-kupferplattiert/dp/B01LXT7YTO/ref=sr_1_37"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-37"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01LXT7YTO"",
            ""name"": ""Cangshan N1 Serie 61871, Deutscher Stahl, geschmiedetes 2-teiliges Starter Messer-Set, Verkupferter Griff""
          },
          {
            ""price"": 271.3,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 25,
            ""review_rating"": 98,
            ""image"": ""https://m.media-amazon.com/images/I/718ZpbzorUL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-61758-Stahlgeschmiedetes-2-teiliges-Schnitzenset/dp/B01LXT7Z9D/ref=sr_1_38?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-38"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-61758-Stahlgeschmiedetes-2-teiliges-Schnitzenset/dp/B01LXT7Z9D/ref=sr_1_38"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-38"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01LXT7Z9D"",
            ""name"": ""Cangshan N1 Serie 61758 Deutsches Stahlgeschmiedetes 2-teiliges Schnitzenset""
          },
          {
            ""price"": 120.42,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 263,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/71YFz9xdKZL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-59120-Deutsches-Stahlgeschmiedete-Kochmesser/dp/B013KZDVRA/ref=sr_1_39?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-39"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-59120-Deutsches-Stahlgeschmiedete-Kochmesser/dp/B013KZDVRA/ref=sr_1_39"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-39"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B013KZDVRA"",
            ""name"": ""Cangshan D Serie 59120, Deutscher Stahl, geschmiedetes Kochmesser, 20 cm""
          },
          {
            ""price"": 39.09,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 1,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/51OTiqMKt2L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Profi-Messer-magnetisiert-Sicherheit-t%C3%A4glichen-Gebrauch/dp/B07MQ4KWLQ/ref=sr_1_40?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-40"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Profi-Messer-magnetisiert-Sicherheit-t%C3%A4glichen-Gebrauch/dp/B07MQ4KWLQ/ref=sr_1_40"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-40"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B07MQ4KWLQ"",
            ""name"": ""Professioneller Honstahl (25,4 cm oder 30,5 cm), magnetisiert für Sicherheit, kein Rost, kein billiger Kunststoff! Der edle Messerschärfer hat einen ovalen Griff für einen festen Halt und ist für den""
          },
          {
            ""price"": 3.09,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 1,
            ""review_rating"": 100,
            ""image"": ""https://m.media-amazon.com/images/I/51YFxs-3AJL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/NOPEILVI-L%C3%B6ffel-handgefertigtes-Holzl%C3%B6ffel-Ce-Creme/dp/B0B6TKBX2T/ref=sr_1_41?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-41"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/NOPEILVI-L%C3%B6ffel-handgefertigtes-Holzl%C3%B6ffel-Ce-Creme/dp/B0B6TKBX2T/ref=sr_1_41"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-41"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0B6TKBX2T"",
            ""name"": ""4pcs Löffel handgefertigtes Holzlöffel Ce-creme Zucker Honig Hone""
          },
          {
            ""price"": 214.71,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 53,
            ""review_rating"": 80,
            ""image"": ""https://m.media-amazon.com/images/I/81tLL9Wv3iL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-61772-geschmiedet-3-teiliges-Starter-Messer-Set/dp/B01LW7X0PB/ref=sr_1_42?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-42"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-61772-geschmiedet-3-teiliges-Starter-Messer-Set/dp/B01LW7X0PB/ref=sr_1_42"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-42"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01LW7X0PB"",
            ""name"": ""Cangshan D Serie 61772, Deutscher Stahl, geschmiedetes 3-teiliges Starter Messer-Set""
          },
          {
            ""price"": 224.14,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 27,
            ""review_rating"": 88,
            ""image"": ""https://m.media-amazon.com/images/I/71KuEVTahFL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-59984-Deutscher-Stahlgeschmiedeter-Gem%C3%BCsekl%C3%A4rer/dp/B01HUH62AM/ref=sr_1_43?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-43"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-59984-Deutscher-Stahlgeschmiedeter-Gem%C3%BCsekl%C3%A4rer/dp/B01HUH62AM/ref=sr_1_43"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-43"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01HUH62AM"",
            ""name"": ""Cangshan N1 Serie 59984, Deutscher Stahl, geschmiedetes Nakiri Gemüsemesser, 18 cm Klinge, Silber""
          },
          {
            ""price"": 224.14,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 8,
            ""review_rating"": 100,
            ""image"": ""https://m.media-amazon.com/images/I/71d+8IuK2EL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/cangshan-N1-Serie-59793-Deutscher-geschmiedet-Messer/dp/B01BUN3NZE/ref=sr_1_44?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-44"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/cangshan-N1-Serie-59793-Deutscher-geschmiedet-Messer/dp/B01BUN3NZE/ref=sr_1_44"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-44"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01BUN3NZE"",
            ""name"": ""Cangshan N1 Serie 59793, Deutscher Stahl, geschmiedetes Brotmesser, 20 cm""
          },
          {
            ""price"": 224.14,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 109,
            ""review_rating"": 86,
            ""image"": ""https://m.media-amazon.com/images/I/719fsekxw6L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-59090-German-Forged-8-Inch/dp/B013KZDR1A/ref=sr_1_45?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-45"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-59090-German-Forged-8-Inch/dp/B013KZDR1A/ref=sr_1_45"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-45"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B013KZDR1A"",
            ""name"": ""Cangshan N1 Serie 59090, Deutscher Stahl, geschmiedetes Kochmesser, 20 cm""
          },
          {
            ""price"": 7.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 30,
            ""review_rating"": 74,
            ""image"": ""https://m.media-amazon.com/images/I/61ztkbwbqaL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/KADAX-Orchideentopf-Pflanzk%C3%BCbel-Blumenk%C3%BCbel-G%C3%A4nsebl%C3%BCmchen/dp/B08LH24RMQ/ref=sr_1_46?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-46"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/KADAX-Orchideentopf-Pflanzk%C3%BCbel-Blumenk%C3%BCbel-G%C3%A4nsebl%C3%BCmchen/dp/B08LH24RMQ/ref=sr_1_46"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-46"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B08LH24RMQ"",
            ""name"": ""KADAX Blumentopf, schlanker Orchideentopf, Schlichter Pflanzkübel, Blumenkübel für Orchidee, Knabenkraut, Gänseblümchen, Übertopf für Küche und Wohnzimmer (⌀ 12cm, rund, Pflaume)""
          },
          {
            ""price"": 195.85,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 6,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/817FlBwQiBL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-60089-Deutsches-Stahlkochmesser-8-Zoll/dp/B01IGDOGKW/ref=sr_1_47?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-47"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-60089-Deutsches-Stahlkochmesser-8-Zoll/dp/B01IGDOGKW/ref=sr_1_47"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-47"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01IGDOGKW"",
            ""name"": ""Cangshan W Serie 60089, Deutscher Stahl, Kochmesser, 20 cm""
          },
          {
            ""price"": 195.85,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 83,
            ""review_rating"": 88,
            ""image"": ""https://m.media-amazon.com/images/I/71Y+HAHbzjL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-59137-Deutsches-Stahlgeschmiedete-Kochmesser/dp/B0128RRAJQ/ref=sr_1_48?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-48"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-59137-Deutsches-Stahlgeschmiedete-Kochmesser/dp/B0128RRAJQ/ref=sr_1_48"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-48"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0128RRAJQ"",
            ""name"": ""Cangshan X Serie 59137, Deutscher Stahl, geschmiedetes Kochmesser, 20 cm""
          },
          {
            ""price"": 94.39,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 0,
            ""review_rating"": 0,
            ""image"": ""https://m.media-amazon.com/images/I/51W93WNzt2L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/M%C3%B6rser-St%C3%B6%C3%9Fel-Set-M%C3%B6rser-St%C3%B6%C3%9Fel-Gew%C3%BCrzsteinm%C3%BChle/dp/B0CXM4D3P1/ref=sr_1_49?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-49"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/M%C3%B6rser-St%C3%B6%C3%9Fel-Set-M%C3%B6rser-St%C3%B6%C3%9Fel-Gew%C3%BCrzsteinm%C3%BChle/dp/B0CXM4D3P1/ref=sr_1_49"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-49"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0CXM4D3P1"",
            ""name"": ""Mörser- und Stößel-Set, Mörser und Stößel, Mörser- und Stößel-Set, Gewürzsteinmühle, Mörser und Stößel – natürlicher Granit zum Honen und Polieren, nicht porös, spülmasch""
          },
          {
            ""price"": 181.8,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 85,
            ""review_rating"": 94,
            ""image"": ""https://m.media-amazon.com/images/I/81JdGEA8CqL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-60171-geschmiedet-Gem%C3%BCseschneider-7-Zoll-Klinge/dp/B01LWAH70G/ref=sr_1_50?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-50"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-60171-geschmiedet-Gem%C3%BCseschneider-7-Zoll-Klinge/dp/B01LWAH70G/ref=sr_1_50"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-50"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01LWAH70G"",
            ""name"": ""Cangshan S Serie 60171, Deutscher Stahl, geschmiedetes Nakiri Gemüsemesser, 18 cm""
          },
          {
            ""price"": 174.24,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 57,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/71YfBNbKLeL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/Cangshan-59977-Deutsche-geschmiedete-K%C3%A4semesser/dp/B01HUH1R4S/ref=sr_1_51?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-51"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/Cangshan-59977-Deutsche-geschmiedete-K%C3%A4semesser/dp/B01HUH1R4S/ref=sr_1_51"",
              ""search"": ""?dib=eyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw&dib_tag=se&keywords=the+honest+kitchen&qid=1711294426&sr=8-51"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B01HUH1R4S"",
            ""name"": ""Cangshan N1 Serie 59977, Deutscher Stahl, geschmiedetes Tomaten-/Käsemesser, 13 cm Klinge, Silver""
          },
          {
            ""price"": 14.69,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 4,
            ""review_rating"": 42,
            ""image"": ""https://m.media-amazon.com/images/I/51Q8LhhRaJL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjMwMDE0NTAxMDIxMTgzMjo6MDo6&url=%2FKuashidai-Tortilla-Presse-manuell-K%25C3%25BCche-Restaurant%2Fdp%2FB09JBZFW9Z%2Fref%3Dsr_1_52_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-52-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjMwMDE0NTAxMDIxMTgzMjo6MDo6&url=%2FKuashidai-Tortilla-Presse-manuell-K%25C3%25BCche-Restaurant%2Fdp%2FB09JBZFW9Z%2Fref%3Dsr_1_52_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-52-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B09JBZFW9Z"",
            ""name"": ""Kuashidai Tortilla-Presse aus Holz, rund, manuelle Teigtaschen-Förmchen, für Küche und Restaurant""
          },
          {
            ""price"": 23.99,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 5,
            ""review_rating"": 92,
            ""image"": ""https://m.media-amazon.com/images/I/51J2Aiuo5uL._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjIwMTU1MjIwNTM5Nzk4OjowOjo&url=%2FBochino-Empanada-Geb%25C3%25A4ck-rostfreiem-Durchmesser%2Fdp%2FB0BR7PYFKW%2Fref%3Dsr_1_53_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-53-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjIwMTU1MjIwNTM5Nzk4OjowOjo&url=%2FBochino-Empanada-Geb%25C3%25A4ck-rostfreiem-Durchmesser%2Fdp%2FB0BR7PYFKW%2Fref%3Dsr_1_53_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-53-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B0BR7PYFKW"",
            ""name"": ""Bochino Empanada Gebäck, Ravioli, Torten for mmaschine Presse aus rostfreiem Stahl (7 Zoll Durchmesser) Groß""
          },
          {
            ""price"": 16.96,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 518,
            ""review_rating"": 90,
            ""image"": ""https://m.media-amazon.com/images/I/51s66NAQx4L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjIwMTQ3MzAxNjcwOTk4OjowOjo&url=%2FLocknLock-Round-2-5ltr-245-86mm%2Fdp%2FB00BUKKBTO%2Fref%3Dsr_1_54_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-54-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjIwMTQ3MzAxNjcwOTk4OjowOjo&url=%2FLocknLock-Round-2-5ltr-245-86mm%2Fdp%2FB00BUKKBTO%2Fref%3Dsr_1_54_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-54-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B00BUKKBTO"",
            ""name"": ""LocknLock Round 2.5ltr (245 x 86mm)""
          },
          {
            ""price"": 16.97,
            ""is_prime"": false,
            ""is_bestseller"": false,
            ""is_amazon_choice"": false,
            ""review_count"": 55,
            ""review_rating"": 90,
            ""image"": ""https://m.media-amazon.com/images/I/71Twyq0id5L._AC_UL960_FMwebp_QL65_.jpg"",
            ""link"": {
              ""href"": ""https://www.amazon.de/sspa/click?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjIwMTQ3MzAxNjc1MDk4OjowOjo&url=%2FLock-HSM952-Container-Kunststoff-Liter%2Fdp%2FB09JLXPG85%2Fref%3Dsr_1_55_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-55-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""origin"": ""https://www.amazon.de"",
              ""protocol"": ""https:"",
              ""username"": """",
              ""password"": """",
              ""host"": ""www.amazon.de"",
              ""hostname"": ""www.amazon.de"",
              ""port"": """",
              ""pathname"": ""/sspa/click"",
              ""search"": ""?ie=UTF8&spc=MTo3NTg4MjA2NDQ2OTU0MDgzOjE3MTEyOTQ0MjY6c3BfYnRmOjIwMTQ3MzAxNjc1MDk4OjowOjo&url=%2FLock-HSM952-Container-Kunststoff-Liter%2Fdp%2FB09JLXPG85%2Fref%3Dsr_1_55_sspa%3Fdib%3DeyJ2IjoiMSJ9.Fb4ajHlmdCJGiD9wbMGFwtPCOW6aZ16iq9PycVLV543CUwXeFg0AkwatZZXdZoS9ZNhaC3Zp-vbMNkhrc1Fs-5yRT0XoVCzkmvZfdgiSWGxtEbQwGAog1X4nCHebsjrO-EZ62MBrXtLicD7jDR5wvY9hYzOCu1bSwhFPgpehsnD9d0HHmImKtvbg5mWv-2XjmJPkLMo6d4gTK74lHY7EqRGxr2qFoc2NfOlr6hqFyFMwf9XbOotJXolbig2GmtF_w0HaMLcyFQoYBWXuRYlyvUf5YPz_xOQUW7XNDJnGaj8.sJSMYwZecqyhByhHYqgj36zUwXOY4zz7kBzA5ltZ8Vw%26dib_tag%3Dse%26keywords%3Dthe%2Bhonest%2Bkitchen%26qid%3D1711294426%26sr%3D8-55-spons%26sp_csd%3Dd2lkZ2V0TmFtZT1zcF9idGY%26psc%3D1"",
              ""searchParams"": {},
              ""hash"": """"
            },
            ""asin"": ""B09JLXPG85"",
            ""name"": ""Lock & Lock HSM952 rund Container, Kunststoff, klar, 2,5 Liter ⌀ 25 x 8.5 cm""
          }
        ],
        ""offers_count"": 55
      },
      ""success"": true
    }
  ]
}";

            DisplayTopOffers(jsonString);
            /*Console.WriteLine("Enter search term:");
            string searchTerm = Console.ReadLine();
            await SubmitSearch(searchTerm);*/
        }

        private static async Task SubmitSearch(string searchTerm)
        {
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri("https://price-analytics.p.rapidapi.com/search-by-term"),
                Headers =
            {
                { "X-RapidAPI-Key", "44964a2e2amsh07a4eab6b5f61bdp12b2bcjsn61d50e3049d1" },
                { "X-RapidAPI-Host", "price-analytics.p.rapidapi.com" },
            },
                Content = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { "source", "amazon" },
                { "country", "us" },
                { "values", searchTerm },
            }),
            };

            try
            {
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var jobId = getJobId(body);
                    if (!string.IsNullOrEmpty(jobId))
                    {
                        Console.WriteLine($"Job submitted successfully. Job ID: {jobId}");
                        await PollJob(jobId);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error submitting search: {ex.Message}");
            }
        }

        private static async Task PollJob(string jobId)
        {
            bool isJobFinished = false;
            Console.WriteLine("Polling job status...");
            while (!isJobFinished)
            {
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://price-analytics.p.rapidapi.com/poll-job/{jobId}"),
                    Headers =
                {
                    { "X-RapidAPI-Key", "44964a2e2amsh07a4eab6b5f61bdp12b2bcjsn61d50e3049d1" },
                    { "X-RapidAPI-Host", "price-analytics.p.rapidapi.com" },
                },
                };

                try
                {
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        var status = getStatus(body);

                        if (status == "finished")
                        {
                            isJobFinished = true;
                            Console.WriteLine("Job finished. Results:");
                            DisplayTopOffers(body);
                        }
                        else
                        {
                            Console.WriteLine("Job still processing. Waiting before polling again...");
                            await Task.Delay(5000); // Delay for 5 seconds
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error polling job status: {ex.Message}");
                    return; // Exit on error
                }
            }
        }

        private static string getJobId(string body)
        {
            var json = JObject.Parse(body);
            return json["job_id"]?.ToString();
        }

        private static string getStatus(string body)
        {
            var json = JObject.Parse(body);
            return json["status"]?.ToString();
        }

        private static void DisplayTopOffers(string jobResults)
        {
            var jsonResponse = JObject.Parse(jobResults);
            var offers = jsonResponse["results"][0]["content"]["offers"]
                .Select(offer => new
                {
                    ReviewRating = offer["shop_review_rating"],
                    ReviewCount = offer["shop_review_count"],
                    Price = offer["price"],
                    Link = offer["link"]["href"], 
                    Name = offer["name"]
                })
                .OrderByDescending(offer => offer.ReviewRating)
                .ThenByDescending(offer => offer.ReviewCount)
                .Take(10);

            foreach (var offer in offers)
            {
                Console.WriteLine($"Name: {offer.Name}, Price: {offer.Price}, Rating: {offer.ReviewRating}, Review Count: {offer.ReviewCount}, Link: {offer.Link}");
            }
        }
    }
}
