using System.Collections.Generic;

namespace BakeryTreats.Models
{
  public class ManageUsersViewModel
  {
    public ApplicationUser[] Administrators { get; set; }

    public ApplicationUser[] Everyone { get; set; }
  }
}