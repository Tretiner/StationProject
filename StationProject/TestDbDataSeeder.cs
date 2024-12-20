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
            PasswordHash = "AQAAAAIAAYagAAAAEN14pbIrIjUOiYmz2hCRcJJDEpvmWkVB7G0sgpZlnWxPd"
        };
        var vendor = new ApplicationUser
        {
            UserName = "Vendor123",
            NormalizedUserName = "VENDOR123",
            Email = "vendor@vendor.com",
            NormalizedEmail = "VENDOR@VENDOR.com",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAIAAYagAAAAEN14pbIrIjUOiYmz2hCRcJJDEpvmWkVB7G0sgpZlnWxPd"
        };
        var user = new ApplicationUser
        {
            UserName = "User123",
            NormalizedUserName = "USER123",
            Email = "user@user.com",
            NormalizedEmail = "USER@USER.com",
            EmailConfirmed = true,
            PasswordHash = "AQAAAAIAAYagAAAAEN14pbIrIjUOiYmz2hCRcJJDEpvmWkVB7G0sgpZlnWxPd"
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
            Id = Random.Shared.Next(),
            Name = "Письмо",
            ImageUrl = "https://m.media-amazon.com/images/G/01/software/coupons/pens-and-writing._CB485918325_SR300_.jpg"
        };
        await dbContext.Categories.AddAsync(category);
        await dbContext.SaveChangesAsync();

        var priceTemplate = new PriceTemplate()
        {
            Value = "{0} Р"
        };

        List<Product> products =
        [
            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Ручки Uni-Ball Jetstream RT — лучшая ручка NY Times Wirecutter на протяжении более десяти лет — упаковка из 3 черных тонких ручек, 0,7 мм — ручки «Снова в школу», шариковые ручки",
                "https://m.media-amazon.com/images/I/71FZ+Ku8dJL._AC_SY355_.jpg",
                140,
                100,
                "Шариковая ручка: наши черные шариковые ручки сочетают в себе плавное, яркое письмо гелевой ручки с быстросохнущими, стойкими к размазыванию свойствами шариковой ручки; "
                + "uni Super Ink: водо- и стойкие чернила помогают вам создавать долговечные, качественные документы, которые можно архивировать; наши чернила защищают от воды, выцветания и подделки; "
                + "Технология быстрого высыхания: наши черные чернила для ручек быстро сохнут и не размазываются, что делает эту ручку идеальной для левшей; "
                + "Качественное исполнение: наши письменные ручки имеют удобный рифленый захват и элегантные акценты из нержавеющей стали; удобная клипса обеспечивает доступность вашей любимой ручки; "
                + "Премиум производительность: наши инновационные черные ручки отлично подходят для всех ваших личных и профессиональных нужд в письме;",
                "Бренд\tUni-Ball\n" + "Форма пишущего инструмента\tШариковая ручка\n" + "Цвет\tЧерный\n" + "Цвет чернил\tЧерный\n" + "Возрастная категория (описание)\tРеклама"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Набор маркеров Zebra Pen Mildliner с двойным концом, скошенный и круглый концы, ассорти цветов, 15 штук",
                "https://m.media-amazon.com/images/I/81iJYy5jnnL._AC_UL320_.jpg",
                399.9,
                200,
                "Универсальный творческий инструмент! С широким скошенным концом с одной стороны и тонким круглым концом с другой, эти творческие маркеры отлично подходят для выделения, рукописного lettering и креативного самовыражения. "
                + "Привнесите жизнь в ваш bullet journal или изучение Библии! Маркеры Zebra Pen Mildliner имеют уникальный мягкий цвет, который делает любое творческое произведение немного более стильным в офисе, художественном отделе или студии. "
                + "Наносите чернила для дополнительного творчества! Полупрозрачные водоотталкивающие чернила в мягких цветах прекрасно накладываются и не просвечивают через страницу; маркеры с двойным концом идеально подходят для раскрашивания книг. "
                + "Выбирайте оттенки с помощью ассортимента цветов! С цветной клипсой на толстом конце вы можете быстро найти нужный оттенок одним взглядом; многоразовый контейнер для хранения включен, чтобы вы могли добавлять цвет где угодно. "
                + "Позвольте своему внутреннему художнику сиять! Zebra Pen предлагает широкий выбор инструментов для самовыражения, независимо от того, являетесь ли вы начинающим художником или профессионалом. "
                + "Водоотталкивающие чернила полупрозрачные и отлично подходят для наложения.",
                "<b>Бренд</b>: Zebra Pen\n"
                + "<b>Цвет чернил</b>: Ассорти\n"
                + "<b>Количество предметов</b>: 15\n"
                + "<b>Тип наконечника</b>:Скошенный\n"
                + "<b>Рекомендуемые области применения<b>: Раскрашивание, Рисование, Письмо"
            ),
            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Набор гелевых ручек Zebra Pen Sarasa Clip",
                "https://example.com/zebra_sarasa_clip.jpg",
                599.9,
                200,
                "Этот набор гелевых ручек предлагает гладкое письмо с водоразбавляемыми чернилами, которые быстро сохнут и не размазываются. "
                + "Ручки представлены в разнообразных ярких цветах, что делает их идеальными для заметок и творческих проектов.",
                "<b>Бренд</b>: Zebra Pen\n" + "<b>Цвет чернил</b>: Ассорти\n" + "<b>Размер наконечника</b>: 0.5 мм\n" + "<b>Рекомендуемые области применения</b>: Письмо, Журналирование, Рисование"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Финелинеры Stabilo Point 88",
                "https://example.com/stabilo_point_88.jpg",
                499.9,
                200,
                "Эти финелинеры известны своей точностью и яркими цветами, идеально подходят для детализированной работы, такой как рисование, письмо и раскрашивание. "
                + "Они имеют металлический наконечник, что обеспечивает долговечность.",
                "<b>Бренд</b>: Stabilo\n" + "<b>Цвет чернил</b>: Ассорти\n" + "<b>Размер наконечника</b>: 0.4 мм\n" + "<b>Рекомендуемые области применения</b>: Рисование, Bullet Journaling, Заметки"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Гелевая ручка Pilot G2",
                "https://pilotrus.ru/wa-data/public/shop/products/44/00/44/images/6485/6485.750.png",
                349.9,
                200,
                "Pilot G2 — популярная гелевая ручка, известная своим гладким письмом и долговечными чернилами. "
                + "Она имеет удобный захват и может быть перезаправлена, что делает ее экологически чистым выбором.",
                "<b>Бренд</b>: Pilot\n"
                + "<b>Цвет чернил</b>: Ассорти\n"
                + "<b>Размер наконечника</b>: 0.7 мм\n"
                + "<b>Рекомендуемые области применения</b>: Повседневное письмо, Профессиональное использование, Творческие проекты"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Пенки Faber-Castell PITT Artist",
                "https://ir-7.ozone.ru/s3/multimedia-1-x/wc350/7219207005.jpg",
                799.9,
                200,
                "Эти художественные ручки имеют пигментные чернила на основе индийских красок, которые водостойкие и светостойкие. "
                + "Идеально подходят для рисования, иллюстраций и раскрашивания с высокой точностью.",
                "<b>Бренд</b>: Faber-Castell\n"
                + "<b>Цвет чернил</b>: Черный (доступны ассорти)\n"
                + "<b>Размер наконечника</b>: Разные (кисть, тонкий, средний)\n"
                + "<b>Рекомендуемые области применения</b>: Художественные проекты, Иллюстрации, Каллиграфия"
            )
        ];

        await dbContext.Products.AddRangeAsync(products);
        await dbContext.SaveChangesAsync();

        category = new Category
        {
            Id = Random.Shared.Next(),
            Name = "Степлеры",
            ImageUrl = "https://fortland.ru/upload/iblock/e8f/3e5553d0_3425_11ed_ab5e_ac1f6b336335_0f8f81b0_fae0_11ed_ab61_ac1f6b336335.jpg"
        };
        await dbContext.Categories.AddAsync(category);
        await dbContext.SaveChangesAsync();

        products =
        [
            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Степлер Leitz NeXXt 5500",
                "https://ae04.alicdn.com/kf/A281ac9f829fe4d58af64f46e752a36d0l.jpeg",
                899.9,
                200,
                "Эргономичный степлер Leitz NeXXt 5500 обеспечивает надежное скрепление до 30 листов бумаги. "
                + "С его стильным дизайном и прочной конструкцией он станет идеальным помощником в офисе.",
                "<b>Бренд</b>: Leitz\n" + "<b>Вместимость</b>: до 30 листов\n" + "<b>Цвет</b>: Черный\n" + "<b>Рекомендуемые области применения</b>: Офис, Учеба"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Степлер Rapid 5050",
                "https://vollie.ru/assets/images/tovar/pictures/kancelyarskie-tovary/steplery/rapid/rapid-5050e-1.jpg",
                749.9,
                200,
                "Степлер Rapid 5050 отличается высокой прочностью и долговечностью. "
                + "Он может скреплять до 50 листов и идеально подходит для интенсивного использования.",
                "<b>Бренд</b>: Rapid\n" + "<b>Вместимость</b>: до 50 листов\n" + "<b>Цвет</b>: Серебристый\n" + "<b>Рекомендуемые области применения</b>: Офис, Печать"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Электрический степлер Bostitch B8E",
                "https://stapleheadquarters.com/images/LARGE/ELECTRIC-OFFICE-STAPLERS/BOSTITCH-B8E-L.JPG",
                2499.9,
                200,
                "Электрический степлер Bostitch B8E обеспечивает быстрое и легкое скрепление до 45 листов. "
                + "Идеален для офисов с высокой нагрузкой, он значительно ускоряет процесс.",
                "<b>Бренд</b>: Bostitch\n" + "<b>Вместимость</b>: до 45 листов\n" + "<b>Цвет</b>: Черный\n" + "<b>Рекомендуемые области применения</b>: Офис, Многостраничные документы"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Степлер Fellowes Helios",
                "https://static.insales-cdn.com/r/rHZhMkNnvIc/rs:fit:1000:0:1/q:100/plain/images/products/1/7085/413965229/7d923508cb1bb5be18e644f49cf60aad.jpg@jpg",
                1299.9,
                200,
                "Степлер Fellowes Helios сочетает в себе стильный дизайн и высокую функциональность. "
                + "Он легко скрепляет до 20 листов и имеет встроенный контейнер для скоб.",
                "<b>Бренд</b>: Fellowes\n" + "<b>Вместимость</b>: до 20 листов\n" + "<b>Цвет</b>: Красный\n" + "<b>Рекомендуемые области применения</b>: Офис, Учеба"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Мини-степлер Swingline Mini",
                "https://i.ebayimg.com/thumbs/images/g/gcwAAOSwU3BnVL0z/s-l1200.jpg",
                399.9,
                200,
                "Компактный мини-степлер Swingline Mini идеально подходит для использования на ходу. "
                + "Несмотря на свои размеры, он надежно скрепляет до 10 листов.",
                "<b>Бренд</b>: Swingline\n" + "<b>Вместимость</b>: до 10 листов\n" + "<b>Цвет</b>: Ассорти\n" + "<b>Рекомендуемые области применения</b>: Путешествия, Личное использование"
            ),

            CreateProduct(
                vendor,
                category.Id,
                priceTemplate,
                "Степлер Novus B40",
                "https://www.tdportal.ru/upload/iblock/c14/c145244b63e0cdfba49fd525bb57f304.jpg",
                1599.9,
                200,
                "Степлер Novus B40 предлагает высокую производительность и стильный дизайн. "
                + "Он способен скреплять до 40 листов и подходит для офисного использования.",
                "<b>Бренд</b>: Novus\n" + "<b>Вместимость</b>: до 40 листов\n" + "<b>Цвет</b>: Черный/Серебристый\n" + "<b>Рекомендуемые области применения</b>: Офис, Дома"
            )
        ];

        await dbContext.Products.AddRangeAsync(products);
        await dbContext.SaveChangesAsync();

        var utc = DateTimeOffset.Now;
        utc = utc.AddMonths(-9);
        
        // List<UserMonthlyActivityStat> monthStats = [];
        //
        // for (int i = 0; i < 10; i++)
        // {
        //     monthStats.Add(
        //         new UserMonthlyActivityStat
        //         {
        //             CreatedAt = utc.AddMonths(i),
        //             TotalSiteViews = Random.Shared.Next(200, 500)
        //         }
        //     );
        // }
        //
        // await dbContext.UserActivityMonthStats.AddRangeAsync(monthStats);
        // await dbContext.SaveChangesAsync();
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