using UnityEngine;

public class ObsticalSpin : MonoBehaviour
{
    public int spin_speed = 150;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       transform.Rotate(new Vector3(0, spin_speed, 0) * Time.deltaTime); 
    }
}
