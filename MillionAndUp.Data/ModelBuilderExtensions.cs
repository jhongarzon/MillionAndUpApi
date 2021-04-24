using Bogus;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MillionAndUp.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            var random = new Random();

            var owners = CreateOwners();
            modelBuilder.Entity<Owner>().HasData(owners);

            var properties = CreateProperties(owners, random);
            modelBuilder.Entity<Property>().HasData(properties);

            var propertyImages = CreatePropertyImages(properties, random);
            modelBuilder.Entity<PropertyImage>().HasData(propertyImages);

            var propertyTrace = CreatePropertyTraces(properties, random);
            modelBuilder.Entity<PropertyTrace>().HasData(propertyTrace);
        }

        private static Owner[] CreateOwners()
        {
            int i = 1;
            var faker = new Faker<Owner>()
                .RuleFor(x => x.OwnerId, f => i++)
                .RuleFor(x => x.Name, f => f.Name.FullName())
                .RuleFor(x => x.Photo, f => f.Image.PicsumUrl())
                .RuleFor(x => x.Address, f => f.Address.Direction())
                .RuleFor(x => x.Birthday, f => f.Date.PastOffset(30).DateTime);
            return faker.Generate(10).ToArray();
        }
        private static Property[] CreateProperties(Owner[] owners, Random random)
        {
            int i = 1;
            var faker = new Faker<Property>()
            .RuleFor(x => x.PropertyId, f => i++)
            .RuleFor(x => x.OwnerId, f => owners[random.Next(0, 9)].OwnerId)
            .RuleFor(x => x.Name, f => f.Name.FullName())
            .RuleFor(x => x.Address, f => f.Address.Direction())
            .RuleFor(x => x.InternalCode, f => f.Hacker.Abbreviation())
            .RuleFor(x => x.Price, f => f.Random.Decimal())
            .RuleFor(x => x.Price, f => random.Next(2015, 2021));

            return faker.Generate(20).ToArray();
        }
        private static PropertyImage[] CreatePropertyImages(Property[] properties, Random random)
        {
            int i = 1;
            var faker = new Faker<PropertyImage>()
            .RuleFor(x => x.PropertyImageId, f => i++)
            .RuleFor(x => x.PropertyId, f => properties[random.Next(0, 19)].PropertyId)
            .RuleFor(x => x.FilePath, f => f.Image.PicsumUrl())
            .RuleFor(x => x.Enabled, f => f.Random.Bool());

            return faker.Generate(30).ToArray();
        }
        private static PropertyTrace[] CreatePropertyTraces(Property[] properties, Random random)
        {
            int i = 1;

            var faker = new Faker<PropertyTrace>()
            .RuleFor(x => x.PropertyTraceId, f => i++)
            .RuleFor(x => x.PropertyId, f => properties[random.Next(0, 19)].PropertyId)
            .RuleFor(x => x.Name, f => f.Address.StreetName())
            .RuleFor(x => x.Value, f => f.Random.Decimal());

            return faker.Generate(30).ToArray();
        }
    }
}
