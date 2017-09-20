using UnityEngine;

[System.Serializable]
public abstract class Ability
{
	public int SpellPower = 100;

    public abstract bool Execute();
}

[System.Serializable]
public class FireBall : Ability
{
    public Color DebuffColor = Color.red;
    public int FireDamageOverTime = 50;

    public override bool Execute()
    {
        Debug.Log("FireBall fired!");
        return true;
    }
}

[System.Serializable]
public class FrostBolt : Ability
{
	public bool FreezeTarget = false;
	public int IceDamage = 50;
	public float SlowingEffect = 0.5f;

    public override bool Execute()
	{
		Debug.Log("Frost Bolt fired!");
		return true;
	}
}

[System.Serializable]
public class Heal : Ability
{
    [Range(0.0f, 10.0f)]
    public float HealingRange = 2.0f;
	public int HealPower = 100;
    public override bool Execute()
	{
		Debug.Log("Healed!");
		return true;
	}
}

