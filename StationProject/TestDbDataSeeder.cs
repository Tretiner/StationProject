using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using StationProject.Data;
using StationProject.Data.Models;

namespace StationProject;

public static class DbDataSeeder
{
    public static async Task SeedTestData(ApplicationDbContext dbContext)
    {
        var admin = new ApplicationUser
        {
            UserName = "Admin123",
            NormalizedUserName = "ADMIN123",
            Email = "admin@admin.com",
            NormalizedEmail = "ADMIN@ADMIN.com",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAIAAYagAAAAEBlHZ1ldeDh1BZiaaePJ4Z1BzznKsWnWhI+fb+zXC0TZkWWGpMbQMowXPQfA8sTZgw=="
        };
        var vendor = new ApplicationUser
        {
            UserName = "Vendor123",
            NormalizedUserName = "VENDOR123",
            Email = "vendor@vendor.com",
            NormalizedEmail = "VENDOR@VENDOR.com",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAIAAYagAAAAEBlHZ1ldeDh1BZiaaePJ4Z1BzznKsWnWhI+fb+zXC0TZkWWGpMbQMowXPQfA8sTZgw=="
        };
        var user = new ApplicationUser
        {
            UserName = "User123",
            NormalizedUserName = "USER123",
            Email = "user@user.com",
            NormalizedEmail = "USER@USER.com",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAIAAYagAAAAEBlHZ1ldeDh1BZiaaePJ4Z1BzznKsWnWhI+fb+zXC0TZkWWGpMbQMowXPQfA8sTZgw=="
        };
        await dbContext.Users.AddRangeAsync([admin, vendor, user]);

        var adminRole = new ApplicationRole { Name = "Admin", NormalizedName = "ADMIN" };
        var vendorRole = new ApplicationRole { Name = "Vendor", NormalizedName = "VENDOR" };
        var joeRole = new ApplicationRole { Name = "User", NormalizedName = "USER" };
        await dbContext.Roles.AddRangeAsync([adminRole, vendorRole, joeRole]);
        await dbContext.SaveChangesAsync();

        var adminUserRole = new IdentityUserRole<int> { UserId = admin.Id, RoleId = adminRole.Id };
        var vendorUserRole = new IdentityUserRole<int> { UserId = vendor.Id, RoleId = vendorRole.Id };
        var userUserRole = new IdentityUserRole<int> { UserId = user.Id, RoleId = joeRole.Id };
        await dbContext.UserRoles.AddRangeAsync([adminUserRole, vendorUserRole, userUserRole]);
        await dbContext.SaveChangesAsync();

        await AddTestCategories(dbContext, vendor);
    }

    public static async Task AddTestCategories(ApplicationDbContext dbContext, ApplicationUser vendor)
    {
        var category = new Category
        {
            Name = "Канцелярские принадлежности",
            ImageUrl = ""
        };
        await dbContext.Categories.AddAsync(category);
        await dbContext.SaveChangesAsync();

        var priceTemplate = new PriceTemplate()
        {
            Value = "{0} Р"
        };

        List<Product> products =
        [
            CreateProduct(vendor, category.Id, priceTemplate, "Ручка гелевая", "images/pens/gel_pen.jpg", 1.50, 100, "Гелевая ручка с мягким захватом.", "Цвет: синий, Толщина линии: 0.5 мм"),
            CreateProduct(vendor, category.Id, priceTemplate, "Блокнот A5", "images/notebooks/a5_notebook.jpg", 3.00, 200, "Блокнот формата A5 с линейкой.", "Количество страниц: 100, Цвет обложки: черный"),
            CreateProduct(vendor, category.Id, priceTemplate, "Скрепки", "images/staples/staples.jpg", 0.50, 500, "Набор скрепок для бумаги.", "Количество в упаковке: 100 штук"),
            CreateProduct(vendor, category.Id, priceTemplate, "Ластик", "images/erasers/eraser.jpg", 0.25, 150, "Ластик для карандаша.", "Размер: стандартный"),
            CreateProduct(vendor, category.Id, priceTemplate, "Клей-карандаш", "images/glue/glue_stick.jpg", 1.20, 80, "Клей-карандаш для бумаги.", "Объем: 20 г"),
            CreateProduct(vendor, category.Id, priceTemplate, "Маркер для доски", "images/markers/whiteboard_marker.jpg", 2.00, 60, "Маркер для белой доски.", "Цвет чернил: черный, Толщина линии: 2 мм"),
            CreateProduct(vendor, category.Id, priceTemplate, "Папка для документов", "images/folders/document_folder.jpg", 4.00, 120, "Папка для хранения документов.", "Материал: пластик, Формат A4")
        ];

        await dbContext.Products.AddRangeAsync(products);
        await dbContext.SaveChangesAsync();

    }

    // [
    // new Category
    // {
    //     Name = "Офисная техника",
    //     ImageUrl = "images/categories/office_tech.jpg",
    //     Products = new List<Product>
    //     {
    //         CreateProduct(vendor, "Принтер лазерный", "images/printers/laser_printer.jpg", 150.00, 10, "Лазерный принтер с функцией двусторонней печати.", "Максимальный формат бумаги A4, Скорость печати до 30 стр./мин."),
    //         CreateProduct(vendor, "Сканер документов", "images/scanners/document_scanner.jpg", 120.00, 15, "Сканер для документов с автоматической подачей.", "Разрешение сканирования до 600 dpi."),
    //         CreateProduct(vendor, "МФУ (принтер, сканер, копир)", "images/multifunction/mfu.jpg", 200.00, 8, "Многофункциональное устройство для офиса.", "Функции печати, сканирования и копирования."),
    //         CreateProduct(vendor, "Проектор", "images/projectors/projector.jpg", 300.00, 5, "Проектор с высоким разрешением для презентаций.", "Яркость до 3000 люмен."),
    //         CreateProduct(vendor, "Электронная доска", "images/boards/electronic_board.jpg", 400.00, 3, "Интерактивная электронная доска для презентаций.", "Подключение по Wi-Fi, Размер экрана – 65 дюймов."),
    //         CreateProduct(vendor, "Копировальный аппарат", "images/copy_machine/copy_machine.jpg", 250.00, 4, "Копировальный аппарат с функцией цветного копирования.", "Скорость копирования до 25 стр./мин."),
    //         CreateProduct(vendor, "Факс", "images/fax/fax_machine.jpg", 100.00, 10, "Факс для отправки и получения документов.", "Поддерживает отправку цветных документов.")
    //     }
    // },
    //
    // new Category
    // {
    //     Name = "Мебель для офиса",
    //     ImageUrl = "images/categories/office_furniture.jpg",
    //     Products = new List<Product>
    //     {
    //         CreateProduct(vendor, "Офисное кресло", "images/furniture/office_chair.jpg", 120.00, 50, "Регулируемое офисное кресло с подлокотниками.", ""),
    //         CreateProduct(vendor, "Стол письменный", "images/furniture/writing_desk.jpg", 250.00, 30, "Письменный стол с ящиками для хранения.", ""),
    //         CreateProduct(vendor, "Стеллаж", "images/furniture/shelf.jpg", 150.00, 20, "Стеллаж для книг и документов.", ""),
    //         CreateProduct(vendor, "Кофейный столик", "images/furniture/coffee_table.jpg", 80.00, 25, "Кофейный столик из стекла и металла.", ""),
    //         CreateProduct(vendor, "Офисная перегородка", "images/furniture/office_partition.jpg", 200.00, 15, "Перегородка для разделения рабочего пространства.", ""),
    //         CreateProduct(vendor, "Настольная лампа", "images/furniture/desk_lamp.jpg", 40.00, 70, "Настольная лампа с регулируемой яркостью.", ""),
    //         CreateProduct(vendor, "Коврик для мыши", "images/furniture/mouse_pad.jpg", 10.00, 150, "Коврик для мыши с антискользящей основой.", "")
    //     }
    // },
    //
    // new Category
    // {
    //     Name = "Компьютерные аксессуары",
    //     ImageUrl = "images/categories/computer_accessories.jpg",
    //     Products = new List<Product>
    //     {
    //         CreateProduct(vendor, "Клавиатура USB", "images/accessories/usb_keyboard.jpg", 30.00, 200, "Удобная клавиатура с подсветкой.", "Тип подключения — USB."),
    //         CreateProduct(vendor, "Мышь беспроводная", "images/accessories/wireless_mouse.jpg", 25.00, 150, "Беспроводная мышь с эргономичным дизайном.", "Тип подключения — Bluetooth."),
    //         CreateProduct(vendor, "Наушники с микрофоном", "images/accessories/headphones_with_mic.jpg", 50.00, 100, "Наушники с качественным звуком и встроенным микрофоном.", "Тип подключения —3.5 мм."),
    //         CreateProduct(vendor, "Вебкамера HD", "images/accessories/hd_webcam.jpg", 70.00, 80, "HD вебкамера для видеозвонков.", "Разрешение —1080p."),
    //         CreateProduct(vendor, "USB хаб", "images/accessories/usb_hub.jpg", 15.00, 150, "USB хаб на четыре порта.", "Тип подключения — USB."),
    //         CreateProduct(vendor, "Сетевой фильтр", "images/accessories/power_strip.jpg", 20.00, 100, "Сетевой фильтр с защитой от перенапряжения.", "Количество розеток —5."),
    //         CreateProduct(vendor, "Флеш-накопитель", "images/accessories/flash_drive.jpg", 10.00, 300, "Флеш-накопитель на32 ГБ.", "Тип подключения — USB.")
    //     }
    // }
    // ];

    private static Product CreateProduct(
        ApplicationUser vendor,
        int categoryId,
        PriceTemplate priceTemplate,
        string name,
        string imageUrl,
        double priceValue,
        int countValue,
        string description,
        string characteristics
    )
    {
        return new Product
        {
            Id = Random.Shared.Next(),
            VendorId = vendor.Id,
            Name = name,
            CategoryId = categoryId,
            Images = new List<ProductImage>
            {
                new ProductImage
                {
                    Url = imageUrl
                }
            },
            Price = new Price
            {
                Id = Random.Shared.Next(),
                Value = priceValue,
                Template = priceTemplate
            },
            Count = new ProductCount
            {
                Count = countValue
            },
            Description = description,
            Characteristics = characteristics
        };
    }
}