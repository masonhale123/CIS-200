using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class GroundPackage : Package
{
  private decimal _cost;
  private decimal _zoneDistance;

  public GroundPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight)
      : base(originAddress, destAddress, length, width, height, weight)
      {
        
      }

  public int ZoneDistance()
  {
    set
    {
      int firstDigitOrigin = int.Parse(originAddress.Zip.ToString().Substring(0,1));
      int firstDigitDestination = int.Parse(destAddress.Zip.ToString().Substring(0,1));

      _zoneDistance = Math.Abs(firstDigitOrigin - firstDigitDestination);
    }
  }

  public override decimal CalcCost()
  {
      return .15*(Length + Width + Height) + .07*(ZoneDist + 1)*(Weight);
  }

  public override string ToString() 
  {
      string NL = Environment.NewLine; 

      return $"GroundPackage{NL}{base.ToString()}"; 
  }

}
