using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CodeWarsSolutions
{
    public class JsonSerealize
    {
    


    //Serialize
    Product product = new Product();
    product.Name = "Apple";
    product.Expiry = new DateTime(2008, 12, 28);
    product.Sizes = new string[] { "Small" };

    string json = JsonConvert.SerializeObject(product);
    // {
    //   "Name": "Apple",
    //   "Expiry": "2008-12-28T00:00:00",
    //   "Sizes": [
    //     "Small"
    //   ]
    // }


    //Deserialize
    string json = @"{
      'Name': 'Bad Boys',
      'ReleaseDate': '1995-4-7T00:00:00',
      'Genres': [
        'Action',
        'Comedy'
      ]
    }";

    Movie m = JsonConvert.DeserializeObject<Movie>(json);

    string name = m.Name;



    //Linq to Json 

    JArray array = new JArray();
    array.Add("Manual text");
    array.Add(new DateTime(2000, 5, 23));

    JObject o = new JObject();
    o["MyArray"] = array;

    string json = o.ToString();
    // {
    //   "MyArray": [
    //     "Manual text",
    //     "2000-05-23T00:00:00"
    //   ]
    // }
}

