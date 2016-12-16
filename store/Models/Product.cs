using System.ComponentModel.DataAnnotations;

namespace store.Models
{
    public class Product
    {
        // ** Unique identifier for the product
        [Required]
        public int ID { get; set; }
        // ** The name of the product 
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        // ** Description of the element
        [StringLength(200)]
        public string Description { get; set; }
        // ** The price is a double to allow $9,99 like prices
        [Required]
        public decimal Price { get; set; }
        // ** Be able to know if there are stock of the product
        [Required]
        public bool Stock { get; set; }
    }

    public class ProductImage
    {
        [Required]
        public int ID { get; set; }
        // The unique name is importart to have different names and avoid having 
        // two images with the same name like trying to get a house.jpg images
        // and having two with the same name
        // The name will be also the path so if the name is
        // image1 the path to it will be /images/products/image1.jpeg/png
        [Required]
        public string UniqueName { get; set; }
        // The product ID will link the Image with a product and the product will 
        // be able to have more than one image 
        // the image will only be for that product FOR NOW 
        public int ProductID { get; set; }
        // Just a simple description of what the image is
        [StringLength(200)]
        public string Description { get; set; }
    }

    // We should render a partial with the PRODUCT form
    // And other partial with the ProductImage form
}