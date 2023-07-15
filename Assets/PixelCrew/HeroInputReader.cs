using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HeroInputReader : MonoBehaviour
{
    [SerializeField] private Hero _hero;
     
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHorizontalMovement(InputAction.CallbackContext context)
    {
        var direction = context.ReadValue<float>();
        _hero.SetDirection(new Vector3(direction, transform.position.y, transform.position.z));
    }
    public void OnVerticalMovement(InputAction.CallbackContext context) 
    {
        var direction = context.ReadValue<float>();
        _hero.SetDirection(new Vector3(transform.position.x, direction, transform.position.z));
    }
}
