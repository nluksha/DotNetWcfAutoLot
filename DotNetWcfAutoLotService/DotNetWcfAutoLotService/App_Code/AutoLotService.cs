using AutoMapper;
using DotNetEFAutoLot.DAL.Models;
using DotNetEFAutoLot.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

public class AutoLotService : IAutoLotService
{
    private MapperConfiguration mapperConfiguration;

    public AutoLotService()
    {
        mapperConfiguration = new MapperConfiguration(cfg => cfg.CreateMap<Inventory, InventoryRecord>());
    }

    public List<InventoryRecord> GetInventory()
    {
        var mapper = new Mapper(mapperConfiguration);
        var repo = new InventoryRepository();
        var records = repo.GetAll();
        var resultRecords = mapper.Map<List<InventoryRecord>>(records);
        repo.Dispose();

        return resultRecords;
    }

    public void InsertCar(string make, string color, string petName)
    {
        var repo = new InventoryRepository();
        repo.Add(new Inventory
        {
            Make = make,
            Color = color,
            PetName = petName
        });

        repo.Dispose();
    }

    public void InsertCar(InventoryRecord car)
    {
        var repo = new InventoryRepository();
        repo.Add(new Inventory
        {
            Make = car.Make,
            Color = car.Color,
            PetName = car.PetName
        });

        repo.Dispose();
    }
}
