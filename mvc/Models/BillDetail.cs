using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace mvc.Models
{
    public class BillDetail
    {
		public int BillDetailId { get; set; }

		[Display(Name = "Chọn địa chỉ")]
		public int BillId { get; set; }
		[Display(Name = "Chọn sản phẩm")]
		public int ProductId { get; set; }
		[DisplayFormat(DataFormatString = "{0:#,##0} đ")]
		[Display(Name = "Giá")]
		public int Price { get; set; }

		[Display(Name = "Số lượng")]
		public int Quantity { get; set; }
		[DisplayFormat(DataFormatString = "{0:#,##0} đ")]
		[Display(Name = "Tổng trị giá")]
		public int Amount { get; set; }
		[Display(Name = "Địa chỉ")]
		public Bill Bill { get; set; }
		[Display(Name = "Tên sản phẩm")]
		public Product Product { get; set; }
	}
}
