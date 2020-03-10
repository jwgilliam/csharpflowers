using System;
using System.Collections.Generic;
namespace FlowerShop
{
  public class FlowerShop
  {
    public List<Rose> Roses = new List<Rose>();
    public List<Tulip> Tulips = new List<Tulip>();
    public List<Orchid> Orchids = new List<Orchid>();
    public List<Lily> Lilies = new List<Lily>();

    public List<IMothersDay> MakeMothersDayArrangement()
    {
      List<IMothersDay> Arrangement = new List<IMothersDay>();
      Arrangement.Add(new Lily());
      Arrangement.Add(new Orchid());

      return Arrangement;
    }

    public List<IBirthday> MakeBirthdayArrangement()
    {
      List<IBirthday> Arrangement = new List<IBirthday>();
      Arrangement.Add(new Rose());
      Arrangement.Add(new Tulip());

      return Arrangement;
    }

    public List<IGetWell> MakeGetWellArrangement()
    {
      List<IGetWell> Arrangement = new List<IGetWell>();
      Arrangement.Add(new Raffelsia());

      return Arrangement;
    }

  }
}