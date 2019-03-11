using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleMove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float So = transform.position.x;
        float S = So + SpeedFactor * Time.deltaTime;
        transform.position = new Vector3(S, transform.position.y, transform.position.z);
    }
}
