// See https://aka.ms/new-console-template for more information

using EagerLoading;
using Microsoft.EntityFrameworkCore;

var optionBuilder = new DbContextOptionsBuilder<MyDbContext>();
optionBuilder.UseSqlServer("Server=.; Database=MyDB; User Id=sa; Password=test@123");
using MyDbContext dbContext = new MyDbContext(optionBuilder.Options);

EFService efs = new EFService(dbContext);
efs.PrintTeachersWithCoursesAndTags();

Console.ReadKey();
