using mvc.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mvc.Models
{
    public class SeedData
    {
		public static void Initialize(ApplicationDbContext context)
		{
			context.Database.EnsureCreated();

			// Look for any data
			if (context.Product.Any())
			{
				return;   // DB has been seeded
			}

			var products = new Product[]
			{
				new Product{Name="iPhone 11 ",Manufacturer="iPhone",Price=11690000,Quantity=10,Desciption="Chip Apple A13 Bionic RAM: 4 GB Dung lượng: 64 GB",Image="iphone1.jpg"},
				new Product{Name="iPhone 13 Pro Max",Manufacturer="iPhone",Price=33590000,Quantity=10,Desciption="Chip Apple A15 Bionic RAM: 6 GB Dung lượng: 128 GB ",Image="iphone2.jpg"},
				new Product{Name="iPhone 14 Pro Max ",Manufacturer="iPhone",Price=11690000,Quantity=10,Desciption="Chip Apple A16 Bionic RAM: 4 GB Dung lượng: 64 GB",Image="iphone3.jpg"},
				new Product{Name="iPhone 14 Pro",Manufacturer="iPhone",Price=33590000,Quantity=10,Desciption="Chip Apple A16 Bionic RAM: 6 GB Dung lượng: 128 GB ",Image="iphone4.jpg"},
				new Product{Name="iPhone 13 Pro ",Manufacturer="iPhone",Price=11690000,Quantity=10,Desciption="Chip Apple A15 Bionic RAM: 4 GB Dung lượng: 64 GB",Image="iphone5.jpg"},
				new Product{Name="iPhone 14 Plus",Manufacturer="iPhone",Price=33590000,Quantity=10,Desciption="Chip Apple A16 Bionic RAM: 6 GB Dung lượng: 128 GB ",Image="iphone6.jpg"},
				new Product{Name="iPhone 14 ",Manufacturer="iPhone",Price=11690000,Quantity=10,Desciption="Chip Apple A16 Bionic RAM: 4 GB Dung lượng: 64 GB",Image="iphone7.jpg"},
				new Product{Name="iPhone 13 ",Manufacturer="iPhone",Price=33590000,Quantity=10,Desciption="Chip Apple A15 Bionic RAM: 6 GB Dung lượng: 128 GB ",Image="iphone8.jpg"},
				new Product{Name="Điện thoại Samsung Galaxy Z Flip4 128GB",Manufacturer="Samsung",Price=20990000,Quantity=50,Desciption="Samsung Galaxy Z Flip4 128GB đã chính thức ra mắt thị trường công nghệ, đánh dấu sự trở lại của Samsung trên con đường định hướng người dùng về sự tiện lợi trên những chiếc điện thoại gập. Với độ bền được gia tăng cùng kiểu thiết kế đẹp mắt giúp Flip4 trở thành một trong những tâm điểm sáng giá cho nửa cuối năm 2022.",Image="samsung1.jpg"},
				new Product{Name="Điện thoại Samsung Galaxy S22 Ultra 5G 128GB",Manufacturer="Samsung",Price=27990000,Quantity=55,Desciption="Galaxy S22 Ultra 5G chiếc smartphone cao cấp nhất trong bộ 3 Galaxy S22 series mà Samsung đã cho ra mắt. Tích hợp bút S Pen hoàn hảo trong thân máy, trang bị vi xử lý mạnh mẽ cho các tác vụ sử dụng vô cùng mượt mà và nổi bật hơn với cụm camera không viền độc đáo mang đậm dấu ấn riêng.",Image="samsung2.jpg"},
				new Product{Name="Điện thoại Xiaomi Redmi Note 11S 5G",Manufacturer="Xiaomi",Price=6090000,Quantity=200,Desciption="Tại sự kiện ra mắt sản phẩm mới diễn ra hôm 29/3, điện thoại Xiaomi đã ra mắt Redmi Note 11S 5G toàn cầu. Thiết bị là một bản nâng cấp đáng giá so với Redmi Note 11S 4G, cùng xem máy có gì đặc biệt thôi nào.",Image="xiaomi1.jpg"},
				

			};

			context.Product.AddRange(products);
			context.SaveChanges();
		}
	}
}
