namespace FlowerShop
{
  public class Rose : IBirthday
  {
    public string Color { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Cost { get; set; }
    public string WaterSchedule { get; set; }
    public bool Thorny { get; set; }
    public bool Fragrant { get; set; }
  }
}