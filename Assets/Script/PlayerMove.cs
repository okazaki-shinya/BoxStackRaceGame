using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private InputActionReference inputMove;
    [SerializeField] private float forwardSpeed = 3f;
    [SerializeField] private float sideSpeed = 5f;
    [SerializeField] private float xLimit = 5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * forwardSpeed * Time.deltaTime;

        Vector3 moveAmount = Vector3.zero;
        moveAmount.x = sideSpeed * Time.deltaTime * inputMove.action.ReadValue<float>();
        transform.Translate(moveAmount);


        Vector3 current = transform.position;
        current.x = Mathf.Clamp(current.x, -xLimit, xLimit);
        transform.position = current;
    }
    
}
