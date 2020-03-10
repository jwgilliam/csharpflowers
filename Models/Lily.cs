namespace FlowerShop
{
  public class Lily : IMothersDay
  {
    public string Color { get; set; }
    public string Type { get; set; }
    public string Name { get; set; }
    public int Cost { get; set; }
    public string WaterSchedule { get; set; }
    public bool Thorny { get; set; }
    public bool Fragrant { get; set; }
    public double StemLength { get; set; }
  }
}