using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class AngledWalk: MonoBehaviour
{
    //VR Main Camera
    public GameObject Body;
    public GameObject parentMove;
    //Angle at which walk/stop will be triggered (x value of camera?)
    public float toggleAngle = 30.0f;
    //how fast to move
    public float speed = 0.01f;
    //should I move forward or not
    public bool moveforward;
    //character controller script
    //private CharacterController cc;
    private Rigidbody rb;
    Vector3 temPos;

    public bool islocal;
    // Use this for initialization
    void Start()
    {
        //find the character controller
        //cc = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();

    }

    // Update is called once per frame
    void Update()
    {
       
        //Check to see if the head has rotated down to the toggleAngle, but not more than straight down
        if (Body.transform.eulerAngles.x >= toggleAngle && Body.transform.eulerAngles.x < 90.0f)
        {

            //Debug.Log("Euler Angle: First Loop" + Body.transform.eulerAngles.x);
            moveforward = true;

        }
        else
        {
            //Debug.Log ("Euler Angle x" + Body.eulerAngles.x);
            //stop moving
            moveforward = false;
        }
        if (moveforward)
        {
            temPos = transform.position; //current coordinates
            Vector3 tmp = GvrReticle.returnPt();
            //Debug.Log(tmp);
            tmp.y = 2.0f;//Maybe set this diferently for the bombs???
            //tmp = tmp * Time.deltaTime * speed;
            //parentMove.transform.position = new Vector3(temPos.x - ((tmp.x / 60)), 2.0f, temPos.z - ((tmp.z / 60)));
            parentMove.transform.position = new Vector3(temPos.x + (tmp.x - temPos.x) / 60, 1.5f, temPos.z + (tmp.z - temPos.z) / 60);
            //float step = speed * Time.deltaTime;
            //transform.position = Vector3.MoveTowards(parentMove, tmp, step);
            //Debug.Log(Body.transform.position);

        }
    }
}