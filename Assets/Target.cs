
using UnityEngine;



public class Target : MonoBehaviour {

	public float health = 50f;
    public GameObject ExplosionEffect;
    public void TakeDamage (float amount)
	{
		health -= amount;
		if (health <= 0f) 
		{
			Die ();
		}
	}
	void Die()
	{
        GameObject ExpolosionGO = Instantiate(ExplosionEffect);
        Destroy(ExpolosionGO, 2f);
        Destroy (gameObject);
	}
}
