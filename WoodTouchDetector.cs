using UnityEngine;

public class WoodTouchDetector: MonoBehaviour
{
    private bool hasBeenTouched = false;
    public bool gotWood = false; // Declare at the class level
    public WinSystem winSystem; // Reference to the WinSystem script

    void Start()
    {
        winSystem = FindObjectOfType<WinSystem>(); // Find the WinSystem script in the scene
    }

    void OnCollisionEnter(Collision collision)
    {
        if (!hasBeenTouched)
        {
            Debug.Log(gameObject.name + " has been touched");
            hasBeenTouched = true;
            gotWood = true;
            winSystem.gotWood = true; // Update the variable in the WinSystem script
        }
    }
}
