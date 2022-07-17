using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chacterControls : MonoBehaviour
{
    #region Metriklerim

    float inputX;
    float inputY;
    [SerializeField] Transform Model;
    Animator Anim;
    Vector3 movement;
    Camera mainCam;
    [SerializeField] float gecikme;
    [Range(1, 20)]
    public float rotationSpeed;
    [Range(1, 20)]
    public float StrafeTurnSpeed;
    float maxSpeed;
    [SerializeField] KeyCode sprintButton = KeyCode.LeftShift;
    [SerializeField] KeyCode walkButton = KeyCode.C;
    [SerializeField] public float jump;
    float normalFov;
    [SerializeField] float SprintFov;
    public enum MovementType
    {
        Directional,
        Strafe
    };
    #endregion
    public MovementType hareketTipi;
    void Start()
    {
        Anim = GetComponent<Animator>();
        mainCam = Camera.main;
        normalFov = mainCam.fieldOfView;
    }

    private void LateUpdate()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.position = new Vector3(transform.position.x, jump*Time.deltaTime, transform.position.y);
        }
        */

        Movement();
    }
    void Movement()
    {
        if (hareketTipi == MovementType.Strafe)
        {
            inputX = Input.GetAxis("Horizontal");
            inputY = Input.GetAxis("Vertical");
            Anim.SetFloat("iX", inputX, gecikme, Time.deltaTime * 10);
            Anim.SetFloat("iY", inputX, gecikme, Time.deltaTime * 10);


            var hareketEdiyor = inputX != 0 || inputY != 0;
            if (hareketEdiyor)
            {
                float yawCamera = mainCam.transform.rotation.eulerAngles.y;
                transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, yawCamera, 0), StrafeTurnSpeed * Time.deltaTime);
                Anim.SetBool("strafeMoving", true);
            }
            else
            {
                Anim.SetBool("strafeMoving", false);
            }
        }

        if (hareketTipi == MovementType.Directional)
        {
            InputMove();
            InputRotation();
            movement = new Vector3(inputX, 0, inputY);
            if (Input.GetKey(sprintButton))
            {
                mainCam.fieldOfView = Mathf.Lerp(mainCam.fieldOfView, SprintFov, Time.deltaTime * 2);
                maxSpeed = 2;
                inputX = 2 * Input.GetAxis("Horizontal");
                inputY = 2 * Input.GetAxis("Vertical");
            }
            else if (Input.GetKey(walkButton))
            {
                mainCam.fieldOfView = Mathf.Lerp(mainCam.fieldOfView, normalFov, Time.deltaTime * 2);
                maxSpeed = 0.2f;
                inputX = Input.GetAxis("Horizontal");
                inputY = Input.GetAxis("Vertical");

            }
            else
            {
                mainCam.fieldOfView = Mathf.Lerp(mainCam.fieldOfView, normalFov, Time.deltaTime * 2);
                maxSpeed = 1;
                inputX = Input.GetAxis("Horizontal");
                inputY = Input.GetAxis("Vertical");
            }
        }

    }
    void InputMove()
    {
        Anim.SetFloat("speed", Vector3.ClampMagnitude(movement, maxSpeed).magnitude, gecikme, Time.deltaTime * 10);
    }
    void InputRotation()
    {
        Vector3 rotOfset = mainCam.transform.TransformDirection(movement);
        rotOfset.y = 0;
        Model.forward = Vector3.Slerp(Model.forward, rotOfset, Time.deltaTime * rotationSpeed);
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "EnemyDagger" && other.tag == "EnemyDagger2")
        {
            GetComponent<Collider>().isTrigger = true;
        }
        else
        {
            GetComponent<Collider>().isTrigger = false;
        }
    }

}
