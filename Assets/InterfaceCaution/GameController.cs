using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
    private IDamagable m_enemyThruInterface = null;
    private BasicEnemy m_enemy = null;

    IEnumerator Start () {
        GameObject enemyGo = GameObject.FindGameObjectWithTag("Enemy");

        m_enemy = enemyGo.GetComponent<BasicEnemy>();
        m_enemyThruInterface = m_enemy;

        Destroy(enemyGo);

        yield return null;

        if (m_enemy == null)
            Debug.Log("enemy is null");
        if (m_enemyThruInterface == null)
            Debug.Log("idamagable is null");

        if (m_enemyThruInterface.Equals(null))
            Debug.Log("idamagable equals null");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
