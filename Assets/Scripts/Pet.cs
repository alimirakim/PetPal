using System.Collections.Generic;
using UnityEngine;


public class Pet : MonoBehaviour
{
  enum PetStatus {  }
  enum PetActivity { Idle, Sleeping, Resting, Eating, Playing, Chewing, Destroying, Training }
  enum PetMood { Happy, Sad, Afraid, Excited, Disgusted, Angry, Hungry, Sleepy, Lonely, Bored }
  
  private PetStatus status;
  private Dictionary<string, int> needs = new Dictionary<string, int>()
  {
    { "satiety", 5 },
    { "energy", 5 },
    { "hygeine", 5 },
    { "fun", 5 },
    { "love", 5 },
  };
  
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void DetermineStatus() {
      
    }
}
