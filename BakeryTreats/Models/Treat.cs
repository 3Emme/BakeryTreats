using System.Collections.Generic;

namespace BakeryTreats.Models
{
  public class Treat
  {
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }
    public int TreatId { get; set; }
    public string TreatName { get; set; }
    public string TreatDescription { get; set; }
    public virtual ICollection<TreatFlavor> Flavors { get; set; }
  }
}