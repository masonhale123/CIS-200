using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class AirPackage : Package
{
  private decimal _cost;
  private decimal _zoneDistance;

  public AirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
      : base(originAddress, destAddress, length, width, height, weight)
      {
        
      }

  public boolean IsHeavy() {
    return Weight >= 75;  // not sure if this is how i reference the parent classes Weight. captial getter?
  }

  public boolean IsLarge() {
    return (Width + Height + Length) >= 100;
  }

  public override string ToString() 
  {
      string NL = Environment.NewLine; 

      return $"GroundPackage{NL}{base.ToString()}"; 
  }

}
