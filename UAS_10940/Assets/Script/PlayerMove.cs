using System.Collections;
using System.Collections.Generic;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float attackSpeed = .5f;
	public float coolDown;
	public float bulletSpeed = .5f;
    public float yValue = 1f; 
    public float xValue = 0.2f; 

	public float bulletPos; 
	public GameObject shootPos; 

	public Rigidbody2D bulletPrefab; 

    [SerializeField] private float speed;
    private Rigidbody2D body;

    private void Awake()
    {
        body = GetComponent<Rigidbody2D>();
        bulletPos=1;
    }

    private void Update()
    {
		bool shoot = CrossPlatformInputManager.GetButtonDown("Jump"); 

		 if(Time.time >= coolDown) 
         {
             if(shoot) 
             {
                 Fire();
             }
         }

        float horizontalInput = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontalInput * speed, body.velocity.y);

        //putar karakter
        if (horizontalInput > 0.01f)
            transform.localScale = new Vector3(182, 188, 4);
        else if (horizontalInput < -0.01f)
            transform.localScale = new Vector3(-182, 188, 4);

        if (Input.GetKey(KeyCode.W))
            body.velocity = new Vector2(body.velocity.x, speed);
    }

    	void Fire(){
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, shootPos.transform.position, shootPos.transform.rotation) as Rigidbody2D; 
		bPrefab.GetComponent<Rigidbody2D>().AddForce(new Vector2 (bulletPos * bulletSpeed, 0));
        coolDown = Time.time + attackSpeed;
     }
}