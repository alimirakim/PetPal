using System;
using UnityEngine;


public class Clock : MonoBehaviour
{
  private string timePeriod;
  
  private DateTime now = DateTime.Now;
  
  
    // Start is called before the first frame update
    void Start()
    {
      timePeriod = GetTimePeriodLabel();
      Debug.Log(timePeriod);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private string GetTimePeriodLabel() {
      (string Label, TimeSpan Time)[] timesOfDay = new (string, TimeSpan)[] {
        ( "dawn",     new TimeSpan(6, 0, 0)  ),  // 6am
        ( "morning",  new TimeSpan(9, 0, 0)  ),  // 9am
        ( "noon",     new TimeSpan(12, 0, 0) ), // 12pm
        ( "latenoon", new TimeSpan(15, 0, 0) ), // 3pm
        ( "evening",  new TimeSpan(18, 0, 0) ), // 6pm
        ( "dusk",     new TimeSpan(21, 0, 0) ), // 9pm
        ( "midnight", new TimeSpan(24, 0, 0) ), // 12am
        ( "night",    new TimeSpan(3, 0, 0)  ),  // 3am
      };
      
        TimeSpan timeNow = DateTime.Now.TimeOfDay;
        Debug.Log(timeNow.ToString());
      
      for (int i = 0; i < timesOfDay.Length - 1; i++) {
        if (timeNow >= timesOfDay[i].Time && timeNow < timesOfDay[i+1].Time)
          return timesOfDay[i].Label;
      }
      
      return timesOfDay[timesOfDay.Length - 1].Label;
    }
}
