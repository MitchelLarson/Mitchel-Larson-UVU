using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class magneticPull : MonoBehaviour
{
    public Rigidbody metalicObjects;
    public float MaxDistance = 10f; // Maximum range at which the marble will start being pulled to the cup
    public float MaxStrength = 5f; // Strength with which the marble will be pulled when it is right next to the cup (reduces with distance)
 
    void Update()
    {
        Update_Magnetism();
       
    }
 
    void Update_Magnetism()
    {
        float Distance = Vector3.Distance(metalicObjects.transform.position, this.transform.position);
 
        if (Distance < MaxDistance) // Marble is in range of the magnet
        {
            float TDistance = Mathf.InverseLerp(MaxDistance, 0f, Distance); // Give a decimal representing how far between 0 distance and max distance.
            float strength = Mathf.Lerp(0f, MaxStrength, TDistance); // Use that decimal to work out how much strength the magnet should apple
            Vector3 DirectionToObject = (this.transform.position - metalicObjects.transform.position).normalized; // Get the direction from the marble to the cup
 
            metalicObjects.AddForce(DirectionToObject * strength, ForceMode.Force);// apply force to the marble
 
        }
    }
 
    
}

