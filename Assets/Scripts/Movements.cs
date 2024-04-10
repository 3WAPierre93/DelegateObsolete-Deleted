using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    #region public
    [SerializeField]
    private float _movespeed = 10f;
    #endregion

    private void Awake()
    {
        _rgbd = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _direction.x = Input.GetAxisRaw("Horizontal") * _movespeed;
        _direction.y = Input.GetAxisRaw("Vertical") * _movespeed;
    }
    private void FixedUpdate()
    {
        _rgbd.velocity = _direction;
    }

    #region private
    private Vector2 _direction;
    private Rigidbody2D _rgbd;
    #endregion
    
}
