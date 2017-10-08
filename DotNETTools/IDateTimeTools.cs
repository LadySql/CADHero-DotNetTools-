using System;

namespace CADHERO
{
    public interface IDateTimeTools
    {
          int DaysInMonth(int Year, int Month)
      ;

          DateTime UtcNow()
        ;
          DateTime Today()
       ;
          int Compare(DateTime t1, DateTime t2)
       ;
          bool IsLeapYear(int Year)
        ;
          DateTime TryParse(string s)
        ;
          DateTime ParseCultureAware(string DateTime, Culture culture)
       ;
        
      String ToShortDateString(DateTime DateTime);
      String ToLongDateString(DateTime DateTime)
    ;
      String ToShortTimeString(DateTime DateTime)
  ;
      String ToLongTimeString(DateTime DateTime)
   ;
    }
}