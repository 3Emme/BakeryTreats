using System.Collections.Generic;

namespace BakeryTreats.Models
{
  public class Flavor
  {
    public Flavor()
    {
      this.Treats = new HashSet<TreatFlavor>();
    }
    public int FlavorId { get; set; }
    public string FlavorName { get; set; }
    public string FlavorDescription { get; set; }
    public virtual ICollection<TreatFlavor> Treats { get; set; }
  }
}