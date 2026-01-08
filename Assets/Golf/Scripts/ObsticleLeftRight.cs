using Unity.VisualScripting;
using UnityEngine;

public class ObsticalLeftRight : MonoBehaviour
{
    public int move_speed = 3;
    public Vector3 move_dir;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       move_dir = Vector3.left; 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * move_speed * Time.deltaTime);

        
    }

    void OllisionEnter(Collision collision)
    {
        if (move_dir == Vector3.left)
            move_dir = Vector3.right;

        else if (move_dir == Vector3.right)
            move_dir = Vector3.right;

    }
}