using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection; // Add this line
using BookShop.controller;
using BookShop.Models.IService;
using BookShop.services;
using BookShop.Views;

namespace BookShop
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddScoped<IBookShopService, BookService>()
                .AddScoped<BookshopView>()
                .AddScoped<BookshopController>()
                .BuildServiceProvider();

            var controller = serviceProvider.GetService<BookshopController>();

            await controller.InitApplication();
        }
    }
}
