using BlazorShop.Shared;

namespace BlazorShop.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();
       
        public void LoadProducts()
        {
            Products = new List<Product>
        {
             new Product
        {
            Id = 1,
            CategoryId= 1,
            Title = "WHISKAS® Thức ăn cho mèo con dạng hạt vị cá thu 1.1kg",
            Description = "Thức ăn mèo con Whiskas vị cá thu 1.1kg.Cung cấp đủ chất dinh dưỡng cần thiết, giúp mèo cưng phát triển khỏe mạnh.Giàu Omega 3&6, axit béo giúp lông mèo khỏe và bóng mượt.Vitamin A & Taurine giúp mắt mèo luôn sáng tinh anh và khỏe mạnh.Nhanh chóng, tiện lợi, không tốn nhiều thời gian chuẩn bị.",
            Image = "images/1.jpg",
            Price = 112000,
            OriginalPrice = 125000,
        },
        new Product
        {
            Id = 2,
            CategoryId= 1,
            Title = "WHISKAS® Thức ăn cho mèo con dạng hạt vị cá biển 1.1kg",
            Description = "Thức ăn mèo con Whiskas vị cá biển 1.1kg.Cung cấp đủ chất dinh dưỡng cần thiết, giúp mèo cưng phát triển khỏe mạnh.Giàu Omega 3&6, axit béo giúp lông mèo khỏe và bóng mượt.Vitamin A & Taurine giúp mắt mèo luôn sáng tinh anh và khỏe mạnh.Nhanh chóng, tiện lợi, không tốn nhiều thời gian chuẩn bị.",
            Image = "images/2.jpg",
            Price = 112000,
            OriginalPrice = 125000,
        },
         new Product
        {
            Id = 3,
            CategoryId= 1,
            Title = "WHISKAS® Thức ăn cho mèo con dạng hạt vị cá ngừ 1.2kg",
            Description = "Thức ăn mèo con Whiskas vị cá thu 1.2kg.Cung cấp đủ chất dinh dưỡng cần thiết, giúp mèo cưng phát triển khỏe mạnh.Giàu Omega 3&6, axit béo giúp lông mèo khỏe và bóng mượt.Vitamin A & Taurine giúp mắt mèo luôn sáng tinh anh và khỏe mạnh.Nhanh chóng, tiện lợi, không tốn nhiều thời gian chuẩn bị.",
            Image = "images/3.jpg",
            Price = 112000,
            OriginalPrice = 125000,
        },
          new Product
        {
            Id = 4,
            CategoryId= 1,
            Title = "WHISKAS® Thức ăn cho mèo con dạng hạt vị cá thu 400g",
            Description = "Thức ăn mèo con Whiskas vị cá thu 400g.Cung cấp đủ chất dinh dưỡng cần thiết, giúp mèo cưng phát triển khỏe mạnh.Giàu Omega 3&6, axit béo giúp lông mèo khỏe và bóng mượt.Vitamin A & Taurine giúp mắt mèo luôn sáng tinh anh và khỏe mạnh.Nhanh chóng, tiện lợi, không tốn nhiều thời gian chuẩn bị.",
            Image = "images/4.jpg",
            Price = 48000,
            OriginalPrice = 60000,
        },
           new Product
        {
            Id = 5,
            CategoryId= 1,
            Title = "WHISKAS® Thức ăn cho mèo con dạng hạt vị cá ngừ 400g",
            Description = "Thức ăn mèo con Whiskas vị cá ngừ 400g.Cung cấp đủ chất dinh dưỡng cần thiết, giúp mèo cưng phát triển khỏe mạnh.Giàu Omega 3&6, axit béo giúp lông mèo khỏe và bóng mượt.Vitamin A & Taurine giúp mắt mèo luôn sáng tinh anh và khỏe mạnh.Nhanh chóng, tiện lợi, không tốn nhiều thời gian chuẩn bị.",
            Image = "images/5.jpg",
            Price = 50000,
            OriginalPrice = 60000,
        },
            new Product
        {
            Id = 6,
            CategoryId= 2,
            Title = "Thức ăn cho chó trưởng thành hạt classic pets vị bò 400g",
            Description = "Là sản phẩm giúp thú cưng tăng cường hệ miễn dich, phát triển làn da và bộ lông khỏe mạnh, óng mượt. Đồng thời hổ trợ phát triển trí não cho thú cưng,cũng như bổ sung năng lượng cho thú cưng hoạt đông. Giúp phát triển hệ xương và tạo cho hàm răng chăc khỏe, giảm mảng bám và cao răng",
            Image = "images/6.jpg",
            Price = 19000,
            OriginalPrice = 20000,
        },
             new Product
        {
            Id = 7,
            CategoryId= 2,
            Title = "Thức Ăn Dành Cho Chó Con - Hạt Classic Pets Hương Vị Sữa 400g",
            Description = "Hạt Classic Pets Puppy là loại hạt thức ăn dành riêng cho chó con từ 3 - 12 tháng tuổi. Chó con nên ăn loại hạt đúng độ tuổi để chúng có một hệ miễn dịch khỏe mạnh, giúp tiêu hóa và hấp thụ dinh dưỡng phát triển trí não, chăm sóc răng miêng, xương và răng chắc khỏe, da và lông óng mượt, và năng lượng tối ưu. ",
            Image = "images/7.jpg",
            Price = 25000,
            OriginalPrice = 40000,
        },
              new Product
        {
            Id = 8,
            CategoryId= 3,
            Title = "PATE HỖN HỢP CHO CHÓ MÈO KINGPET KING'SPET KING'S PET LON 380G",
            Description = "Được làm từ thịt gà/thịt cá đã được kiểm dịch chặt chẽ, kết hợp cùng gan gà tươi mọng được thanh trùng ở nhiệt độ cao nhằm giữ nguyên hương vị thơm ngon và hàm lượng dinh dưỡng. Sản phẩm là thức ăn hỗn hợp hoàn chỉnh thích hợp cho chó và mèo từ 01 tháng tuổi với những ưu điểm vượt trội:",
            Image = "images/8.jpg",
            Price = 37000,
            OriginalPrice = 40000,
        },
        };
        }
    }
}
