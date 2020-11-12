using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public new string name = "Untitled";
    public bool alive;
    public int age = 10;
    public int[] points = new int[5];
    public string[] names;

    public float speed{
        get{
            return sm.speed;
        }
    }

    private SpeedManager sm;

    void Awake(){
        print("Awake");
        sm = gameObject.GetComponent<SpeedManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        print("Start " + PosUtil.CalculateIndex(5, 3, 10));
    }

    // It's called at a fixed interval to help you have more accurate physics calculations
    void FixedUpdate()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var pos = transform.position;
        transform.position = new Vector3(pos.x + speed, pos.y, pos.z);
    }

    // It's called after everything is updated to help you to clean up any logic in your script
    // After fixed update & update have run
    void LateUpdate()
    {

    }
}
