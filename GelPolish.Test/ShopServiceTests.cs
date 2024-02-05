using GelPolishStore.BL.Services;
using GelPolishStore.DL.Interfaces;
using GelPolishStore.DL.Repositories;
using GelPolishStore.Models.Models;
using GelPolishStore.Models.Requests;
using GelPolisStore.BL.Services;
using Moq;

namespace GelPolishStore.Tests
{
    public class ShopServiceTests
    {
        public static List<GelPolish> GelPolishData = new List<GelPolish>()
        {
            new GelPolish()
            {
                Id = 1,
                ManufactureID = 1,
                ReleaseDate = new DateTime(2005,02, 12),
                Title = "GelPolish 1"
            },
            new GelPolish()
            {
                Id = 2,
                ManufactureID = 1,
                ReleaseDate = new DateTime(2007,02, 12),
                Title = "GelPolish 2"
            }
        };

        public static List<Manufacture> ManufactureData =
            new List<Manufacture>()
            {
                new Manufacture()
                {
                    Id = 1,
                    Name = "Manufacture 1",
                    BirthDay = DateTime.Now
                },
                new Manufacture()
                {
                    Id = 2,
                    Name = "Manufacture 2",
                    BirthDay = DateTime.Now
                },
                new Manufacture()
                {
                    Id = 3,
                    Name = "Manufacture 3",
                    BirthDay = DateTime.Now
                }
            };
        private readonly object Assert;

        [Fact]
        public void GetAllGelPolishesCount_OK()
        {
            //setup
            var input = 10;
            var manufactureId = 1;
            var expectedCount = 12;

            var mockedGelPolishRepository =
                new Mock<IGelPolishRepository>();
            var mockedManufactureRepository =
                new Mock<IManufactureRepository>();

            mockedGelPolishRepository.Setup(
                x =>
                    x.GetAllGelPolishesByManufacture(manufactureId))
                .Returns(GelPolishData.Where(b =>
                    b.ManufactureID == manufactureId).ToList());

            //inject
            var gelpolishService =
                new GelPolishService(mockedGelPolsihRepository.Object);
            var authorService =
                new ManufactureService(mockedManufactureRepository.Object);
            var libraryService =
                new ShopService(gelpolishService, manufactureService);

            //act
            var result =
                shopService.GetAllGelPolishesCount(input, manufactureId);

            //Assert
            Assert.Equals(expectedCount, result);
        }

        [Fact]
        public void GetAllGelPolishesCount_WrongManufactureId()
        {
            //setup
            var input = 10;
            var manufactureId = 111;
            var expectedCount = 10;

            var mockedGelPolishRepository =
                new Mock<IGelPolishRepository>();
            var mockedManufactureRepository =
                new Mock<IManufactureRepository>();

            mockedGelPolishRepository.Setup(
                    x =>
                        x.GetAllGelPolishsByManufacture(manufactureId))
                .Returns(GelPolishData.Where(b =>
                    b.ManufactureID == manufactureId).ToList());

            //inject
            var gelpolishService =
                new GelPolishService(mockedGelPolishRepository.Object);
            var manufactureService =
                new ManufactureService(mockedManufactureRepository.Object);
            var shopService =
                new ShopService(shopService, manufactureService);

            //act
            var result =
                shopService.GetAllGelPolishesCount(input, manufactureId);

            //Assert
            Assert.Equals(expectedCount, result);
        }

        [Fact]
        public void GetAllGelPolishesCount_NegativeInput()
        {
            //setup
            var input = -10;
            var manufactureId = 111;
            var expectedCount = 0;

            var mockedGelPolishRepository =
                new Mock<IGelPolishRepository>();
            var mockedManufactureRepository =
                new Mock<IManufactureRepository>();

            mockedGelPolishRepository.Setup(
                    x =>
                        x.GetAllGelPolishesByManufacture(manufactureId))
                .Returns(GelPolishData.Where(b =>
                    b.ManufactureID == manufactureId).ToList());

            //inject
            var gelpolishService =
                new GelPolishService(mockedGelPolisRepository.Object);
            var manufactureService =
                new ManufactureService(mockedManufactureRepository.Object);
            var shopService =
                new ShopService(gelpolishService, manufactureService);

            //act
            var result =
                shopService.GetAllGelPolishesCount(input, manufactureId);

            //Assert
            Assert.Equals(expectedCount, result);
        }

        public void GetAllGelPolishesByManufactureAfterDate_OK(ManufactureService manufactureService)
        {
            GetAllGelPolishesByManufactureAfterDate_OK(manufactureService, manufactureService);
        }

        [Fact]
        public void GetAllGelPolishesByManufactureAfterDate_OK(ManufactureService manufactureService, ManufactureService manufactureService)
        {
            //setup
            var request = new GetAllGelPolishesByManufactureRequest
            {
                ManufactureId = 1,
                AfterDate = new DateTime(2015, 11, 15)
            };
            var expectedCount = 2;

            var mockedGelPolishRepository =
                new Mock<IGelPolishRepository>();
            var mockedManufactureRepository =
                new Mock<IManufactureRepository>();

            mockedGelPolishRepository.Setup(
                    x =>
                        x.GetAllGelPOlishesByManufacture(request.ManufactureId))
                .Returns(GelPolishData
                    .Where(b => b.ManufactureID == request.ManufactureId)
                    .ToList());

            mockedManufactureRepository.Setup(
                    x =>
                        x.GetById(request.ManufactureId))
                .Returns(ManufactureData!
                    .FirstOrDefault(a =>
                        a.Id == request.manufactureId)!);

            //inject
            var gelpolishService =
                new GelPolishService(mockedGelPolishRepository.Object);
            var manufactureService =
                new ManufactureService(mockedManufactureRepository.Object);
            var service = new ShopService(gelpolishService, manufactureService);

            //Act
            var result =
                service.GetAllGelPolishesByManufactureAfterDate(request);

            //Assert
            object value = Assert.NotNull(result);
            Assert.Equals(expectedCount, result!.GelPolish.Count);
            Assert.Equals(request.ManufactureId, result.Manufacture.Id);
        }

    }
}