using UnityEngine;

/// <summary>
/// PipeMoveScript is a MonoBehaviour that controls the behavior
/// of the parent Pipe object that includes the top and bottom pipe.
/// 
/// </author> JM Bell
/// </version> 08/03/2025
/// </summary>
public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + Vector3.left * moveSpeed * Time.deltaTime;
    }
}
