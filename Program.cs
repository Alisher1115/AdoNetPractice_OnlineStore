/*
 * Создано в SharpDevelop.
 * Пользователь: Alisher
 * Дата: 11.12.2018
 * Время: 0:00
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;
using System.Data;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineStore
{
	class Program
	{
		public static void Main(string[] args)
		{
            DataSet dataSet = new DataSet("OnlineStore");
            DataSetMethod(dataSet);

            Console.WriteLine("Выберите товары: ");

            Console.WriteLine("Посмотреть Корзину - 1");

			Console.ReadKey(true);
		}

        static DataSet DataSetMethod (DataSet dataSet)
        {
            var goods = new[] {
                new { Id = 1, Name = "Duis", ManufacturerId = 19, CategoryId = 20, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 32 },
                new { Id = 2, Name = "vitae", ManufacturerId = 41, CategoryId = 28, Description = "Lorem ipsum dolor sit amet,", Price = 80 },
                new { Id = 3, Name = "at", ManufacturerId = 74, CategoryId = 55, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 92 },
                new { Id = 4, Name = "eu", ManufacturerId = 69, CategoryId = 97, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 96 },
                new { Id = 5, Name = "vitae", ManufacturerId = 54, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 23 },
                new { Id = 6, Name = "ante", ManufacturerId = 21, CategoryId = 96, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 43 },
                new { Id = 7, Name = "viverra.", ManufacturerId = 30, CategoryId = 35, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 75 },
                new { Id = 8, Name = "vulputate", ManufacturerId = 78, CategoryId = 16, Description = "Lorem ipsum dolor sit amet,", Price = 63 },
                new { Id = 9, Name = "felis", ManufacturerId = 73, CategoryId = 1, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 61 },
                new { Id = 10, Name = "Morbi", ManufacturerId = 77, CategoryId = 71, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 88 },
                new { Id = 11, Name = "enim", ManufacturerId = 90, CategoryId = 73, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 22 },
                new { Id = 12, Name = "Maecenas", ManufacturerId = 71, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 41 },
                new { Id = 13, Name = "a", ManufacturerId = 98, CategoryId = 16, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 46 },
                new { Id = 14, Name = "Sed", ManufacturerId = 92, CategoryId = 68, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 21 },
                new { Id = 15, Name = "eu", ManufacturerId = 28, CategoryId = 41, Description = "Lorem ipsum dolor sit amet,", Price = 60 },
                new { Id = 16, Name = "sodales", ManufacturerId = 37, CategoryId = 54, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 91 },
                new { Id = 17, Name = "nunc", ManufacturerId = 30, CategoryId = 72, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 98 },
                new { Id = 18, Name = "augue", ManufacturerId = 30, CategoryId = 60, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 76 },
                new { Id = 19, Name = "nunc", ManufacturerId = 85, CategoryId = 60, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 57 },
                new { Id = 20, Name = "tellus", ManufacturerId = 84, CategoryId = 99, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 98 },
                new { Id = 21, Name = "diam", ManufacturerId = 31, CategoryId = 92, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 47 },
                new { Id = 22, Name = "amet", ManufacturerId = 17, CategoryId = 16, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 46 },
                new { Id = 23, Name = "faucibus", ManufacturerId = 88, CategoryId = 22, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 13 },
                new { Id = 24, Name = "et", ManufacturerId = 79, CategoryId = 67, Description = "Lorem ipsum dolor sit amet,", Price = 96 },
                new { Id = 25, Name = "a,", ManufacturerId = 11, CategoryId = 99, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 85 },
                new { Id = 26, Name = "nisl", ManufacturerId = 64, CategoryId = 15, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 58 },
                new { Id = 27, Name = "luctus", ManufacturerId = 68, CategoryId = 34, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 23 },
                new { Id = 28, Name = "Pellentesque", ManufacturerId = 59, CategoryId = 40, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 27 },
                new { Id = 29, Name = "pede.", ManufacturerId = 41, CategoryId = 72, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 10 },
                new { Id = 30, Name = "Suspendisse", ManufacturerId = 80, CategoryId = 54, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 80 },
                new { Id = 31, Name = "non,", ManufacturerId = 11, CategoryId = 21, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 13 },
                new { Id = 32, Name = "non", ManufacturerId = 96, CategoryId = 8, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 23 },
                new { Id = 33, Name = "risus.", ManufacturerId = 54, CategoryId = 89, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 36 },
                new { Id = 34, Name = "Integer", ManufacturerId = 43, CategoryId = 24, Description = "Lorem ipsum dolor sit amet,", Price = 92 },
                new { Id = 35, Name = "nec", ManufacturerId = 83, CategoryId = 17, Description = "Lorem ipsum dolor sit amet,", Price = 71 },
                new { Id = 36, Name = "Ut", ManufacturerId = 75, CategoryId = 97, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 20 },
                new { Id = 37, Name = "sapien,", ManufacturerId = 66, CategoryId = 71, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 75 },
                new { Id = 38, Name = "dolor", ManufacturerId = 70, CategoryId = 91, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 55 },
                new { Id = 39, Name = "sodales", ManufacturerId = 30, CategoryId = 38, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 83 },
                new { Id = 40, Name = "ullamcorper,", ManufacturerId = 98, CategoryId = 97, Description = "Lorem ipsum dolor sit amet,", Price = 65 },
                new { Id = 41, Name = "mauris", ManufacturerId = 66, CategoryId = 52, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 44 },
                new { Id = 42, Name = "sociis", ManufacturerId = 26, CategoryId = 24, Description = "Lorem ipsum dolor sit amet,", Price = 58 },
                new { Id = 43, Name = "per", ManufacturerId = 55, CategoryId = 100, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 31 },
                new { Id = 44, Name = "Quisque", ManufacturerId = 98, CategoryId = 60, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 86 },
                new { Id = 45, Name = "leo.", ManufacturerId = 38, CategoryId = 1, Description = "Lorem ipsum dolor sit amet,", Price = 54 },
                new { Id = 46, Name = "et", ManufacturerId = 37, CategoryId = 85, Description = "Lorem ipsum dolor sit amet,", Price = 19 },
                new { Id = 47, Name = "justo", ManufacturerId = 22, CategoryId = 68, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 77 },
                new { Id = 48, Name = "Nunc", ManufacturerId = 70, CategoryId = 88, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 73 },
                new { Id = 49, Name = "mattis", ManufacturerId = 41, CategoryId = 92, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 31 },
                new { Id = 50, Name = "risus,", ManufacturerId = 11, CategoryId = 30, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 44 },
                new { Id = 51, Name = "nec", ManufacturerId = 45, CategoryId = 2, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 84 },
                new { Id = 52, Name = "ut", ManufacturerId = 53, CategoryId = 61, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 18 },
                new { Id = 53, Name = "luctus", ManufacturerId = 86, CategoryId = 12, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 69 },
                new { Id = 54, Name = "amet", ManufacturerId = 71, CategoryId = 77, Description = "Lorem ipsum dolor sit amet,", Price = 48 },
                new { Id = 55, Name = "Aenean", ManufacturerId = 50, CategoryId = 32, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 75 },
                new { Id = 56, Name = "vitae", ManufacturerId = 83, CategoryId = 48, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 12 },
                new { Id = 57, Name = "sapien.", ManufacturerId = 17, CategoryId = 50, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 89 },
                new { Id = 58, Name = "non,", ManufacturerId = 9, CategoryId = 67, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 24 },
                new { Id = 59, Name = "Nullam", ManufacturerId = 64, CategoryId = 21, Description = "Lorem ipsum dolor sit amet,", Price = 61 },
                new { Id = 60, Name = "fermentum", ManufacturerId = 67, CategoryId = 43, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 32 },
                new { Id = 61, Name = "sem", ManufacturerId = 95, CategoryId = 26, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 23 },
                new { Id = 62, Name = "Integer", ManufacturerId = 37, CategoryId = 48, Description = "Lorem ipsum dolor sit amet,", Price = 10 },
                new { Id = 63, Name = "quis,", ManufacturerId = 93, CategoryId = 37, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 42 },
                new { Id = 64, Name = "Pellentesque", ManufacturerId = 83, CategoryId = 57, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 99 },
                new { Id = 65, Name = "diam.", ManufacturerId = 49, CategoryId = 26, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 22 },
                new { Id = 66, Name = "Vivamus", ManufacturerId = 11, CategoryId = 51, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 59 },
                new { Id = 67, Name = "enim.", ManufacturerId = 78, CategoryId = 8, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 10 },
                new { Id = 68, Name = "sem", ManufacturerId = 99, CategoryId = 31, Description = "Lorem ipsum dolor sit amet,", Price = 20 },
                new { Id = 69, Name = "Donec", ManufacturerId = 55, CategoryId = 15, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 41 },
                new { Id = 70, Name = "magna.", ManufacturerId = 38, CategoryId = 58, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 77 },
                new { Id = 71, Name = "diam.", ManufacturerId = 34, CategoryId = 14, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 72 },
                new { Id = 72, Name = "tincidunt", ManufacturerId = 50, CategoryId = 50, Description = "Lorem ipsum dolor sit amet,", Price = 85 },
                new { Id = 73, Name = "magna", ManufacturerId = 54, CategoryId = 10, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 39 },
                new { Id = 74, Name = "urna.", ManufacturerId = 99, CategoryId = 8, Description = "Lorem ipsum dolor sit amet,", Price = 63 },
                new { Id = 75, Name = "mauris", ManufacturerId = 38, CategoryId = 8, Description = "Lorem ipsum dolor sit amet,", Price = 85 },
                new { Id = 76, Name = "ac", ManufacturerId = 87, CategoryId = 41, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 26 },
                new { Id = 77, Name = "in,", ManufacturerId = 40, CategoryId = 4, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 45 },
                new { Id = 78, Name = "parturient", ManufacturerId = 15, CategoryId = 57, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 73 },
                new { Id = 79, Name = "sagittis", ManufacturerId = 8, CategoryId = 6, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 14 },
                new { Id = 80, Name = "Etiam", ManufacturerId = 63, CategoryId = 33, Description = "Lorem ipsum dolor sit amet,", Price = 36 },
                new { Id = 81, Name = "et", ManufacturerId = 85, CategoryId = 79, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 77 },
                new { Id = 82, Name = "tellus", ManufacturerId = 12, CategoryId = 42, Description = "Lorem ipsum dolor sit amet,", Price = 38 },
                new { Id = 83, Name = "lectus", ManufacturerId = 25, CategoryId = 54, Description = "Lorem ipsum dolor sit amet,", Price = 62 },
                new { Id = 84, Name = "Aliquam", ManufacturerId = 26, CategoryId = 88, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 61 },
                new { Id = 85, Name = "erat", ManufacturerId = 13, CategoryId = 66, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 18 },
                new { Id = 86, Name = "Vivamus", ManufacturerId = 17, CategoryId = 9, Description = "Lorem ipsum dolor sit amet, consectetuer", Price = 20 },
                new { Id = 87, Name = "leo.", ManufacturerId = 81, CategoryId = 98, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 92 },
                new { Id = 88, Name = "ipsum", ManufacturerId = 48, CategoryId = 92, Description = "Lorem ipsum dolor sit amet,", Price = 78 },
                new { Id = 89, Name = "nunc", ManufacturerId = 100, CategoryId = 57, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 93 },
                new { Id = 90, Name = "neque.", ManufacturerId = 25, CategoryId = 75, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 36 },
                new { Id = 91, Name = "molestie", ManufacturerId = 99, CategoryId = 37, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 50 },
                new { Id = 92, Name = "libero.", ManufacturerId = 69, CategoryId = 49, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 83 },
                new { Id = 93, Name = "risus.", ManufacturerId = 35, CategoryId = 41, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit.", Price = 84 },
                new { Id = 94, Name = "ut", ManufacturerId = 57, CategoryId = 53, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 22 },
                new { Id = 95, Name = "Aenean", ManufacturerId = 40, CategoryId = 41, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 42 },
                new { Id = 96, Name = "tempus,", ManufacturerId = 95, CategoryId = 49, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur sed", Price = 66 },
                new { Id = 97, Name = "Proin", ManufacturerId = 82, CategoryId = 21, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Curabitur", Price = 72 },
                new { Id = 98, Name = "Donec", ManufacturerId = 62, CategoryId = 40, Description = "Lorem ipsum dolor sit amet,", Price = 11 },
                new { Id = 99, Name = "neque", ManufacturerId = 79, CategoryId = 45, Description = "Lorem ipsum dolor sit amet,", Price = 33 },
                new { Id = 100, Name = "Quisque", ManufacturerId = 5, CategoryId = 36, Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing", Price = 35 }
            };

            var manufacturers = new[] {
                new { Id = 1, Name = "ultricies" },
                new { Id = 2, Name = "ligula." },
                new { Id = 3, Name = "sem" },
                new { Id = 4, Name = "velit" },
                new { Id = 5, Name = "urna" },
                new { Id = 6, Name = "at," },
                new { Id = 7, Name = "aliquet" },
                new { Id = 8, Name = "vel," },
                new { Id = 9, Name = "faucibus." },
                new { Id = 10, Name = "magna" },
                new { Id = 11, Name = "nunc" },
                new { Id = 12, Name = "felis" },
                new { Id = 13, Name = "est." },
                new { Id = 14, Name = "dolor." },
                new { Id = 15, Name = "Nunc" },
                new { Id = 16, Name = "ipsum" },
                new { Id = 17, Name = "pharetra." },
                new { Id = 18, Name = "a," },
                new { Id = 19, Name = "vel" },
                new { Id = 20, Name = "Integer" },
                new { Id = 21, Name = "nec" },
                new { Id = 22, Name = "nec" },
                new { Id = 23, Name = "consectetuer" },
                new { Id = 24, Name = "Morbi" },
                new { Id = 25, Name = "pede." },
                new { Id = 26, Name = "arcu." },
                new { Id = 27, Name = "lacinia" },
                new { Id = 28, Name = "sem" },
                new { Id = 29, Name = "Cras" },
                new { Id = 30, Name = "turpis." },
                new { Id = 31, Name = "adipiscing" },
                new { Id = 32, Name = "erat" },
                new { Id = 33, Name = "viverra." },
                new { Id = 34, Name = "nec" },
                new { Id = 35, Name = "adipiscing" },
                new { Id = 36, Name = "ipsum" },
                new { Id = 37, Name = "et" },
                new { Id = 38, Name = "Maecenas" },
                new { Id = 39, Name = "ac" },
                new { Id = 40, Name = "metus." },
                new { Id = 41, Name = "lorem" },
                new { Id = 42, Name = "quis," },
                new { Id = 43, Name = "Suspendisse" },
                new { Id = 44, Name = "feugiat" },
                new { Id = 45, Name = "nibh" },
                new { Id = 46, Name = "pretium" },
                new { Id = 47, Name = "Mauris" },
                new { Id = 48, Name = "blandit" },
                new { Id = 49, Name = "tempus," },
                new { Id = 50, Name = "Aenean" },
                new { Id = 51, Name = "arcu." },
                new { Id = 52, Name = "habitant" },
                new { Id = 53, Name = "vel" },
                new { Id = 54, Name = "eget" },
                new { Id = 55, Name = "ornare" },
                new { Id = 56, Name = "amet," },
                new { Id = 57, Name = "vitae," },
                new { Id = 58, Name = "faucibus" },
                new { Id = 59, Name = "quis" },
                new { Id = 60, Name = "vehicula" },
                new { Id = 61, Name = "habitant" },
                new { Id = 62, Name = "tristique" },
                new { Id = 63, Name = "bibendum" },
                new { Id = 64, Name = "semper" },
                new { Id = 65, Name = "posuere" },
                new { Id = 66, Name = "Integer" },
                new { Id = 67, Name = "urna." },
                new { Id = 68, Name = "eu" },
                new { Id = 69, Name = "non," },
                new { Id = 70, Name = "dictum" },
                new { Id = 71, Name = "Nam" },
                new { Id = 72, Name = "Integer" },
                new { Id = 73, Name = "a" },
                new { Id = 74, Name = "mi" },
                new { Id = 75, Name = "Suspendisse" },
                new { Id = 76, Name = "convallis" },
                new { Id = 77, Name = "congue," },
                new { Id = 78, Name = "Nam" },
                new { Id = 79, Name = "magna" },
                new { Id = 80, Name = "malesuada" },
                new { Id = 81, Name = "Donec" },
                new { Id = 82, Name = "egestas" },
                new { Id = 83, Name = "cursus" },
                new { Id = 84, Name = "ipsum." },
                new { Id = 85, Name = "ultrices." },
                new { Id = 86, Name = "sagittis." },
                new { Id = 87, Name = "parturient" },
                new { Id = 88, Name = "sit" },
                new { Id = 89, Name = "Nunc" },
                new { Id = 90, Name = "amet" },
                new { Id = 91, Name = "ac" },
                new { Id = 92, Name = "elit" },
                new { Id = 93, Name = "et" },
                new { Id = 94, Name = "quam" },
                new { Id = 95, Name = "sed" },
                new { Id = 96, Name = "lacinia" },
                new { Id = 97, Name = "libero." },
                new { Id = 98, Name = "Cras" },
                new { Id = 99, Name = "orci." },
                new { Id = 100, Name = "sit" }
            };

            var categories = new[] {
                new { Id = 1, Name = "urna" },
                new { Id = 2, Name = "elit," },
                new { Id = 3, Name = "scelerisque," },
                new { Id = 4, Name = "semper," },
                new { Id = 5, Name = "pede," },
                new { Id = 6, Name = "scelerisque" },
                new { Id = 7, Name = "sit" },
                new { Id = 8, Name = "quam" },
                new { Id = 9, Name = "id" },
                new { Id = 10, Name = "dolor" },
                new { Id = 11, Name = "adipiscing" },
                new { Id = 12, Name = "aliquet," },
                new { Id = 13, Name = "egestas." },
                new { Id = 14, Name = "quam" },
                new { Id = 15, Name = "a" },
                new { Id = 16, Name = "feugiat" },
                new { Id = 17, Name = "id" },
                new { Id = 18, Name = "dolor," },
                new { Id = 19, Name = "lacus." },
                new { Id = 20, Name = "mauris," },
                new { Id = 21, Name = "felis" },
                new { Id = 22, Name = "egestas." },
                new { Id = 23, Name = "dolor" },
                new { Id = 24, Name = "quis," },
                new { Id = 25, Name = "diam" },
                new { Id = 26, Name = "sem" },
                new { Id = 27, Name = "ullamcorper," },
                new { Id = 28, Name = "vehicula." },
                new { Id = 29, Name = "nunc," },
                new { Id = 30, Name = "Vivamus" },
                new { Id = 31, Name = "parturient" },
                new { Id = 32, Name = "sed," },
                new { Id = 33, Name = "luctus" },
                new { Id = 34, Name = "Aliquam" },
                new { Id = 35, Name = "mauris" },
                new { Id = 36, Name = "Vestibulum" },
                new { Id = 37, Name = "nisl." },
                new { Id = 38, Name = "faucibus" },
                new { Id = 39, Name = "Duis" },
                new { Id = 40, Name = "tempor" },
                new { Id = 41, Name = "suscipit" },
                new { Id = 42, Name = "feugiat" },
                new { Id = 43, Name = "Proin" },
                new { Id = 44, Name = "Phasellus" },
                new { Id = 45, Name = "vitae" },
                new { Id = 46, Name = "imperdiet," },
                new { Id = 47, Name = "dapibus" },
                new { Id = 48, Name = "ipsum." },
                new { Id = 49, Name = "fermentum" },
                new { Id = 50, Name = "auctor." },
                new { Id = 51, Name = "dignissim" },
                new { Id = 52, Name = "pharetra" },
                new { Id = 53, Name = "Aliquam" },
                new { Id = 54, Name = "magna." },
                new { Id = 55, Name = "mi" },
                new { Id = 56, Name = "Morbi" },
                new { Id = 57, Name = "lacinia" },
                new { Id = 58, Name = "fames" },
                new { Id = 59, Name = "amet," },
                new { Id = 60, Name = "Sed" },
                new { Id = 61, Name = "scelerisque" },
                new { Id = 62, Name = "dis" },
                new { Id = 63, Name = "aliquet" },
                new { Id = 64, Name = "non," },
                new { Id = 65, Name = "bibendum" },
                new { Id = 66, Name = "nec," },
                new { Id = 67, Name = "diam." },
                new { Id = 68, Name = "arcu" },
                new { Id = 69, Name = "ac" },
                new { Id = 70, Name = "Sed" },
                new { Id = 71, Name = "tellus" },
                new { Id = 72, Name = "dui" },
                new { Id = 73, Name = "mauris" },
                new { Id = 74, Name = "non," },
                new { Id = 75, Name = "Proin" },
                new { Id = 76, Name = "enim." },
                new { Id = 77, Name = "nonummy." },
                new { Id = 78, Name = "felis." },
                new { Id = 79, Name = "tincidunt" },
                new { Id = 80, Name = "vulputate" },
                new { Id = 81, Name = "placerat" },
                new { Id = 82, Name = "elit," },
                new { Id = 83, Name = "consequat" },
                new { Id = 84, Name = "ante" },
                new { Id = 85, Name = "Suspendisse" },
                new { Id = 86, Name = "non," },
                new { Id = 87, Name = "ac" },
                new { Id = 88, Name = "eu" },
                new { Id = 89, Name = "leo." },
                new { Id = 90, Name = "risus" },
                new { Id = 91, Name = "Sed" },
                new { Id = 92, Name = "lorem," },
                new { Id = 93, Name = "turpis." },
                new { Id = 94, Name = "id" },
                new { Id = 95, Name = "vitae" },
                new { Id = 96, Name = "amet" },
                new { Id = 97, Name = "massa" },
                new { Id = 98, Name = "lectus," },
                new { Id = 99, Name = "fermentum" },
                new { Id = 100, Name = "interdum" }
            };

            #region Customer
            DataTable customer = new DataTable("Customer");
            DataColumn customerId = new DataColumn("Id");
            customerId.DataType = typeof(int);
            customerId.AllowDBNull = false;
            customerId.AutoIncrement = true;
            customerId.AutoIncrementSeed = 1;
            customerId.AutoIncrementStep = 1;

            DataColumn customerFullName = new DataColumn("FullName");
            customerFullName.DataType = typeof(string);

            DataColumn customerAge = new DataColumn("Age");
            customerAge.DataType = typeof(int);

            DataColumn customerAddress = new DataColumn("Address");
            customerAddress.DataType = typeof(string);

            DataColumn customerPhone = new DataColumn("Phone");
            customerPhone.DataType = typeof(string);

            customer.Columns.Add(customerId);
            customer.Columns.Add(customerFullName);
            customer.Columns.Add(customerAge);
            customer.Columns.Add(customerAddress);
            customer.Columns.Add(customerPhone);

            // DataRow firstRow = customer.NewRow();

            // firstRow.BeginEdit();
            // firstRow.ItemArray = new object[] { 1, "P.P.Kirsanov", 42 };
            // firstRow.EndEdit();
            dataSet.Tables.Add(customer);
            #endregion

            #region Employee
            DataTable employee = new DataTable("Employee");
            DataColumn employeeId = new DataColumn("Id");
            employeeId.DataType = typeof(int);
            employeeId.AllowDBNull = false;
            employeeId.AutoIncrement = true;
            employeeId.AutoIncrementSeed = 1;
            employeeId.AutoIncrementStep = 1;

            DataColumn employeeFullName = new DataColumn("FullName");
            employeeFullName.DataType = typeof(string);

            DataColumn employeeAge = new DataColumn("Age");
            employeeAge.DataType = typeof(int);

            DataColumn employeeAddress = new DataColumn("Address");
            employeeAddress.DataType = typeof(string);

            DataColumn employeePhone = new DataColumn("Phone");
            employeePhone.DataType = typeof(string);

            employee.Columns.Add(employeeId);
            employee.Columns.Add(employeeFullName);
            employee.Columns.Add(employeeAge);
            employee.Columns.Add(employeeAddress);
            employee.Columns.Add(employeePhone);
            dataSet.Tables.Add(employee);
            #endregion

            #region Cart
            DataTable cart = new DataTable("Cart");
            DataColumn cartId = new DataColumn("Id");
            cartId.DataType = typeof(int);
            cartId.AllowDBNull = false;
            cartId.AutoIncrement = true;
            cartId.AutoIncrementSeed = 1;
            cartId.AutoIncrementStep = 1;

            DataColumn cartCustomerId = new DataColumn("CustomerId");
            cartCustomerId.DataType = typeof(int);

            DataColumn cartTotalSum = new DataColumn("TotalSum");
            cartTotalSum.DataType = typeof(int);

            cart.Columns.Add(cartId);
            cart.Columns.Add(cartCustomerId);
            cart.Columns.Add(cartTotalSum);

            dataSet.Tables.Add(cart);

            DataRelation cartCustomerIdRelation = new DataRelation("FK_cart_CustomerId", customerId, cartCustomerId);
            #endregion

            #region OrderStatus
            DataTable orderStatus = new DataTable("OrderStatus");
            DataColumn orderStatusId = new DataColumn("Id");
            orderStatusId.DataType = typeof(int);
            orderStatusId.AllowDBNull = false;
            orderStatusId.AutoIncrement = true;
            orderStatusId.AutoIncrementSeed = 1;
            orderStatusId.AutoIncrementStep = 1;

            DataColumn orderStatusName = new DataColumn("OrderStatusName");
            orderStatusName.DataType = typeof(string);

            orderStatus.Columns.Add(orderStatusId);
            orderStatus.Columns.Add(orderStatusName);
            dataSet.Tables.Add(orderStatus);
            #endregion

            #region Order
            DataTable order = new DataTable("Order");
            DataColumn orderId = new DataColumn("Id");
            orderId.DataType = typeof(int);
            orderId.AllowDBNull = false;
            orderId.AutoIncrement = true;
            orderId.AutoIncrementSeed = 1;
            orderId.AutoIncrementStep = 1;

            DataColumn orderCustomerId = new DataColumn("CustomerId");
            orderCustomerId.DataType = typeof(int);

            DataColumn orderEmployeeId = new DataColumn("EmployeeId");
            orderEmployeeId.DataType = typeof(int);

            DataColumn orderTotalSum = new DataColumn("TotalSum");
            orderTotalSum.DataType = typeof(int);

            DataColumn orderDate = new DataColumn("OrderDate");
            orderDate.DataType = typeof(DateTime);

            DataColumn orderOrderStatusId = new DataColumn("OrderStatusId");
            orderOrderStatusId.DataType = typeof(int);

            order.Columns.Add(orderId);
            order.Columns.Add(orderCustomerId);
            order.Columns.Add(orderEmployeeId);
            order.Columns.Add(orderTotalSum);
            order.Columns.Add(orderDate);
            order.Columns.Add(orderOrderStatusId);

            dataSet.Tables.Add(order);

            DataRelation orderCustomerIdRelation = new DataRelation("FK_order_CustomerId", customerId, orderCustomerId);
            DataRelation orderEmployeeIdRelation = new DataRelation("FK_order_EmployeeId", employeeId, orderEmployeeId);
            DataRelation orderOrderStatusIdRelation = new DataRelation("FK_order_orderStatusId", orderStatusId, orderOrderStatusId);
            #endregion

            #region DeliveryStatus
            DataTable deliveryStatus = new DataTable("DeliveryStatus");
            DataColumn deliveryStatusId = new DataColumn("Id");
            deliveryStatusId.DataType = typeof(int);
            deliveryStatusId.AllowDBNull = false;
            deliveryStatusId.AutoIncrement = true;
            deliveryStatusId.AutoIncrementSeed = 1;
            deliveryStatusId.AutoIncrementStep = 1;

            DataColumn deliveryStatusName = new DataColumn("deliveryStatusName");
            deliveryStatusName.DataType = typeof(string);

            deliveryStatus.Columns.Add(deliveryStatusId);
            deliveryStatus.Columns.Add(deliveryStatusName);
            dataSet.Tables.Add(deliveryStatus);
            #endregion

            #region Delivery
            DataTable delivery = new DataTable("Delivery");
            DataColumn deliveryId = new DataColumn("Id");
            deliveryId.DataType = typeof(int);
            deliveryId.AllowDBNull = false;
            deliveryId.AutoIncrement = true;
            deliveryId.AutoIncrementSeed = 1;
            deliveryId.AutoIncrementStep = 1;

            DataColumn deliveryOrderId = new DataColumn("OrderId");
            deliveryOrderId.DataType = typeof(int);

            DataColumn deliveryDeliveryStatusId = new DataColumn("DeliveryStatusId");
            deliveryDeliveryStatusId.DataType = typeof(int);

            delivery.Columns.Add(deliveryId);
            delivery.Columns.Add(deliveryOrderId);
            delivery.Columns.Add(deliveryDeliveryStatusId);

            dataSet.Tables.Add(delivery);

            DataRelation deliveryCustomerIdRelation = new DataRelation("FK_delivery_OrderId", orderId, deliveryOrderId);
            DataRelation deliveryDeliveryStatusIdRelation = new DataRelation("FK_delivery_StatusId", deliveryStatusId, deliveryDeliveryStatusId);
            #endregion

            #region Manufacturer
            DataTable manufacturer = new DataTable("Manufacturer");
            DataColumn manufacturerId = new DataColumn("Id");
            manufacturerId.DataType = typeof(int);
            manufacturerId.AllowDBNull = false;
            manufacturerId.AutoIncrement = true;
            manufacturerId.AutoIncrementSeed = 1;
            manufacturerId.AutoIncrementStep = 1;

            DataColumn manufacturerName = new DataColumn("Name");
            manufacturerName.DataType = typeof(string);

            manufacturer.Columns.Add(manufacturerId);
            manufacturer.Columns.Add(manufacturerName);
            dataSet.Tables.Add(manufacturer);
            #endregion

            #region Category
            DataTable category = new DataTable("Category");
            DataColumn categoryId = new DataColumn("Id");
            categoryId.DataType = typeof(int);
            categoryId.AllowDBNull = false;
            categoryId.AutoIncrement = true;
            categoryId.AutoIncrementSeed = 1;
            categoryId.AutoIncrementStep = 1;

            DataColumn categoryName = new DataColumn("Name");
            categoryName.DataType = typeof(string);

            category.Columns.Add(categoryId);
            category.Columns.Add(categoryName);
            dataSet.Tables.Add(category);
            #endregion

            #region Good
            DataTable good = new DataTable("Good");
            DataColumn goodId = new DataColumn("Id");
            goodId.DataType = typeof(int);
            goodId.AllowDBNull = false;
            goodId.AutoIncrement = true;
            goodId.AutoIncrementSeed = 1;
            goodId.AutoIncrementStep = 1;

            DataColumn goodName = new DataColumn("Name");
            goodName.DataType = typeof(string);

            DataColumn goodManufacturerId = new DataColumn("ManufacturerId");
            goodManufacturerId.DataType = typeof(int);

            DataColumn goodCategoryId = new DataColumn("CategoryId");
            goodCategoryId.DataType = typeof(int);

            DataColumn goodDescription = new DataColumn("Description");
            goodDescription.DataType = typeof(string);

            DataColumn goodPrice = new DataColumn("Price");
            goodPrice.DataType = typeof(int);

            good.Columns.Add(goodId);
            good.Columns.Add(goodName);
            good.Columns.Add(goodManufacturerId);
            good.Columns.Add(goodCategoryId);
            good.Columns.Add(goodDescription);
            good.Columns.Add(goodPrice);

            dataSet.Tables.Add(good);

            DataRelation goodManufacturerIdRelation = new DataRelation("FK_good_ManufacturerId", manufacturerId, goodManufacturerId);
            DataRelation goodCategoryIdRelation = new DataRelation("FK_good_CategoryId", categoryId, goodCategoryId);
            #endregion

            #region CartGood
            DataTable cartGood = new DataTable("CartGood");
            DataColumn cartGoodId = new DataColumn("Id");
            cartGoodId.DataType = typeof(int);
            cartGoodId.AllowDBNull = false;
            cartGoodId.AutoIncrement = true;
            cartGoodId.AutoIncrementSeed = 1;
            cartGoodId.AutoIncrementStep = 1;

            DataColumn cartGoodCartId = new DataColumn("CartId");
            cartGoodCartId.DataType = typeof(int);

            DataColumn cartGoodGoodId = new DataColumn("GoodId");
            cartGoodGoodId.DataType = typeof(int);

            DataColumn cartGoodGoodCount = new DataColumn("GoodCount");
            cartGoodGoodCount.DataType = typeof(int);

            cartGood.Columns.Add(cartGoodId);
            cartGood.Columns.Add(cartGoodCartId);
            cartGood.Columns.Add(cartGoodGoodId);
            cartGood.Columns.Add(cartGoodGoodCount);

            dataSet.Tables.Add(cartGood);

            DataRelation cartGoodCartIdRelation = new DataRelation("FK_cartGood_CartId", cartId, cartGoodCartId);
            DataRelation cartGoodGoodIdRelation = new DataRelation("FK_cartGood_CartId", goodId, cartGoodGoodId);
            #endregion

            #region OrderGood
            DataTable orderGood = new DataTable("OrderGood");
            DataColumn orderGoodId = new DataColumn("Id");
            orderGoodId.DataType = typeof(int);
            orderGoodId.AllowDBNull = false;
            orderGoodId.AutoIncrement = true;
            orderGoodId.AutoIncrementSeed = 1;
            orderGoodId.AutoIncrementStep = 1;

            DataColumn orderGoodOrderId = new DataColumn("OrderId");
            orderGoodOrderId.DataType = typeof(int);

            DataColumn orderGoodGoodId = new DataColumn("GoodId");
            orderGoodGoodId.DataType = typeof(int);

            DataColumn orderGoodGoodCount = new DataColumn("GoodCount");
            orderGoodGoodCount.DataType = typeof(int);

            orderGood.Columns.Add(orderGoodId);
            orderGood.Columns.Add(orderGoodOrderId);
            orderGood.Columns.Add(orderGoodGoodId);
            orderGood.Columns.Add(orderGoodGoodCount);

            dataSet.Tables.Add(orderGood);

            DataRelation orderGoodCartIdRelation = new DataRelation("FK_orderGood_CartId", orderId, orderGoodOrderId);
            DataRelation orderGoodGoodIdRelation = new DataRelation("FK_orderGood_CartId", goodId, orderGoodGoodId);
            #endregion

            #region TransactionStatus
            DataTable transactionStatus = new DataTable("TransactionStatus");
            DataColumn transactionStatusId = new DataColumn("Id");
            transactionStatusId.DataType = typeof(int);
            transactionStatusId.AllowDBNull = false;
            transactionStatusId.AutoIncrement = true;
            transactionStatusId.AutoIncrementSeed = 1;
            transactionStatusId.AutoIncrementStep = 1;

            DataColumn transactionStatusName = new DataColumn("transactionStatusName");
            transactionStatusName.DataType = typeof(string);

            transactionStatus.Columns.Add(transactionStatusId);
            transactionStatus.Columns.Add(transactionStatusName);
            dataSet.Tables.Add(transactionStatus);
            #endregion

            #region Transaction
            DataTable transaction = new DataTable("Transaction");
            DataColumn transactionId = new DataColumn("Id");
            transactionId.DataType = typeof(int);
            transactionId.AllowDBNull = false;
            transactionId.AutoIncrement = true;
            transactionId.AutoIncrementSeed = 1;
            transactionId.AutoIncrementStep = 1;

            DataColumn transactionOrderId = new DataColumn("OrderId");
            transactionOrderId.DataType = typeof(int);

            DataColumn transactionTransactionStatusId = new DataColumn("TransactionStatusId");
            transactionTransactionStatusId.DataType = typeof(int);

            transaction.Columns.Add(transactionId);
            transaction.Columns.Add(transactionOrderId);
            transaction.Columns.Add(transactionTransactionStatusId);

            dataSet.Tables.Add(transaction);

            DataRelation transactionCustomerIdRelation = new DataRelation("FK_transaction_OrderId", orderId, transactionOrderId);
            DataRelation transactionTransactionStatusIdRelation = new DataRelation("FK_transaction_StatusId", transactionStatusId, transactionTransactionStatusId);
            #endregion

            return dataSet;
        }
    }
}