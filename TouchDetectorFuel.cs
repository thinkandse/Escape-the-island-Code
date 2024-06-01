using UnityEngine;

public class TouchDetectorFuel : MonoBehaviour
{
    private bool hasBeenTouched = false;
    public bool gotFuel = false; // Declare gotFuel at the class level
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
            gotFuel = true;
            winSystem.gotFuel = true; // Update the gotFuel variable in the WinSystem script
        }
    }
}
