using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NextDayAirPackage : AirPackage
{
  private decimal _cost;
  private decimal _expressFee;

    public NextDayAirPackage(Address originAddress, Address destAddress, double length, double width, double height, double weight, decimal expressFee)
      : base(originAddress, destAddress, length, width, height, weight)
      {
        
        ExpressFee = expressFee;
      }

      public ExpressFee() {
        get
        {
          _expressFee;
        }
      }

      public override decimal CalcCost()
      {

        decimal totalCost = .35*(Length + Width + Height) + .25*(Weight) + ExpressFee;

        if (IsHeavy) {
          totalCost = totalCost + .20*(Weight);
        }

        if (IsLarge) {
          totalCost = totalCost + .22*(Length + Width + Height);
        }

        return totalCost;
      }

      public override string ToString() 
      {
          string NL = Environment.NewLine; 

          return $"NextDayAirPackage{NL}{base.ToString()}"; 
      }

}
