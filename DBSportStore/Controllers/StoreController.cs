
using System;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.Web.Mvc;
using DBSportStore.Models;

namespace DBSportStore.Controllers
{
    public class StoreController : Controller
    {
        // Trang chủ: hiển thị danh sách sản phẩm mẫu
        public ActionResult Index()
        {
            var products = new List<ProductCardViewModel>
            {
                // Sản phẩm 1
                new ProductCardViewModel
                {
                    ProductId = 1,
                    NamePro = "Nike Air Zoom",
                    CategoryName = "Giày thể thao",
                    Price = 1290000,
                    ImagePro = "nike.jpg",
                    ShortDescription = "Giày chạy bộ chất lượng cao, thiết kế hiện đại và thoải mái."
                },

                // Sản phẩm 2
                new ProductCardViewModel
                {
                    ProductId = 2,
                    NamePro = "Adidas Training Tee",
                    CategoryName = "Áo quần thi đấu",
                    Price = 590000,
                    ImagePro = "adidas_shirt.jpg",
                    ShortDescription = "Áo thun thể thao thoáng khí, thích hợp tập luyện."
                },

                // Sản phẩm 3
                new ProductCardViewModel
                {
                    ProductId = 3,
                    NamePro = "Gym Performance Set",
                    CategoryName = "Dụng cụ thể thao",
                    Price = 890000,
                    ImagePro = "dumbbells.jpg",
                    ShortDescription = "Bộ tạ tay chất lượng cao, giúp tăng cường sức mạnh."
                },

                // Sản phẩm 4
                new ProductCardViewModel
                {
                    ProductId = 4,
                    NamePro = "Running Shoes Pro",
                    CategoryName = "Giày thể thao",
                    Price = 1490000,
                    ImagePro = "adidas_shoes.jpg",
                    ShortDescription = "Giày chạy bộ chuyên nghiệp, hỗ trợ tối đa cho đôi chân."
                },

                // Sản phẩm 5
                new ProductCardViewModel
                {
                    ProductId = 5,
                    NamePro = "Yoga Mat Deluxe",
                    CategoryName = "Dụng cụ thể thao",
                    Price = 350000,
                    ImagePro = "yoga_mat.jpg",
                    ShortDescription = "Thảm yoga cao cấp, chống trơn trượt, phù hợp cho các bài tập yoga."
                },

                // Sản phẩm 6
                new ProductCardViewModel
                {
                    ProductId = 6,
                    NamePro = "Running Shorts",
                    CategoryName = "Áo quần thi đấu",
                    Price = 290000,
                    ImagePro = "nike_shirt.jpg",
                    ShortDescription = "Quần chạy bộ nhẹ nhàng, thoáng khí, thích hợp cho các buổi tập luyện."
                },

                // Sản phẩm 7
                new ProductCardViewModel
                {
                    ProductId = 7,
                    NamePro = "Sports Watch",
                    CategoryName = "Phụ kiện thể thao",
                    Price = 1990000,
                    ImagePro = "smartwatch.jpg",
                    ShortDescription = "Đồng hồ thể thao thông minh, theo dõi nhịp tim và các hoạt động thể chất."
                }
            };

            return View(products);
        }

        // Trang giới thiệu cửa hàng
        public ActionResult AboutStore()
        {
            return View();
        }
    }
}