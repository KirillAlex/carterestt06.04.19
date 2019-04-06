namespace Data.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Data.CarContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "Data.CarContext";
        }

        /// <summary>
        /// Този метод добавя първоначалната демо информация в БД
        /// </summary>
        /// <remarks>
        ///     Автор: Кирилл Алексеев
        /// </remarks>
        protected override void Seed(Data.CarContext context)
        {

            context.Posts.AddOrUpdate(
                new Post() {
                    Id=1,
                    Name = "BMW e36", Decription = "Трето поколение – E36 (1990 – 1998) \n Хечбек вариантът на модела, продаван под марката „Компакт“, се произвежда от 1993 до 2000 година. Предното окачване е като другите модели от „E36“, а задното е взето от платформата „E30“. Освен в Европа, този модел се предлага и в САЩ, Канада и Австралия. Моторите са 316i, 316g, 318ti, 318tds (дизел) и 323ti.",
                    FileName = "e36.jpg" },
                 new Post()
                 {  Id=2,
                     Name = "BMW e60",
                     Decription = "БМВ Серия 5 E60 \n    Произвеждан 2003 – 2010 ; Двигател2,0 – 5,0 l бензин 2,0 – 3,0 l дизел Мощност 120 – 373 kW 163 – 507 к.с. Въртящ момент   210 – 580 N.m Задвижване  Задно / 4x4 Други характеристики Купе    Седан 4 врати Комби 5 врати Максимална скорост  220 – 250 km / h Ускорение 0 - 100 km / h    10,  0 – 4, 7 s Междуосие   2880 – 2889 mm Дължина 4841 – 4855 mm Ширина  1846 mm Височина    1468 – 1512 mm Тегло   1545 – 1735 kg",
                     FileName = "e60.jpg"
                 },
                 new Post()
                 {
                     Id = 3,
                     Name = "AUDI C6",
                     Decription = "Трето поколение – A6 (2004 – 2011) \n Двигател 2,0 – 5,2 l бензин,   2,0 – 3,0 l дизел,  Мощност 100 – 426 kW 136 – 580 к.с.,  Въртящ момент: 230 – 650 N.m , Скоростна кутия: 6 степени ръчна, 6 / 7 степени автоматична , Ускорение 0 - 100 km / h:  10,4 – 4,5s;  Междуосие   2759 – 2847 mm, Дължина 4916 – 5012 mm, Ширина  1855 mm, Височина    1459 – 1485 mm, Тегло   1520 – 2025 kg",
                     FileName = "a6.jpg"
                 },
                   new Post()
                   {
                       Id = 4,
                       Name = "CIVIC 6 ",
                       Decription = "Позната още като Miracle Civic, шеста генерация предлага най-много разновидности на модела – с 3-врати, 4-врати, 5-врати, купе и комби (Aerodeck). Приликата на 5-вратия модел с Rover 200 и Rover 400 не е случайна, по това време Honda и Rover разработват заедно автомобилите. Купето се произвежда в САЩ, моделите с 3 и 4 врати – в Япония, а моделът с 5 врати и комби моделът се прозвеждат в новия завод в Swindon (Англия). През 1997 г. Honda правят Facelift модела с 5 врати и комбито. Моделите с 3 и 4 врати получават Facelift през 1999. През 1997 г. се появява първия TYPE R (само в Япония) с мощност от 136 kW (185 к.с.) и кубатура 1,6 л.",
                       FileName = "civic.jpg"
                   }
                );

            context.Brands.AddOrUpdate(
                new Brand() {
                    Id =4,
                    Name = "BMW", Decription = "", Image = "bmw.png",
                    
                },
                new Brand()
                {
                    Id = 5,
                    Name = "AUDI",
                    Decription = "",
                    Image = "audi.png",

                },
                  new Brand()
                  {
                      Id = 6,
                      Name = "HONDA",
                      Decription = "",
                      Image = "honda.png",

                  }
            );

            context.BrandPosts.AddOrUpdate(
                        new BrandPost(){Id=5, BrandId=4, PostId=1},
                        new BrandPost(){Id=6, BrandId=4, PostId=2},
                        new BrandPost(){Id=7, BrandId=5, PostId=3},
                        new BrandPost(){Id=8, BrandId=6, PostId=4}


            );
            context.SaveChanges();
        }
    }
}
