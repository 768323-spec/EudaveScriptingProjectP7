using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour
{
   public class Stuff
   {
        public int projectileA;
        public int projectileB;
        public int projectileC;
        public float fuel;

        public Stuff(int prA, int prB, int prC)
        {
            projectileA = prA;
            projectileB = prB;
            projectileC = prC; 
        }

        public Stuff(int prA, float fu)
        {
            projectileA = prA;
            fuel = fu;
        }

    // Constructor
    public Stuff()
    {
        projectileA = 1;
        projectileB = 1;
        projectileC = 1;
    }
   }


    // Creating an Instance (an Object) of the Stuff class
    public Stuff myStuff = new Stuff();


    void Start()
    {
        Debug.Log(myStuff.projectileA);
    }
}