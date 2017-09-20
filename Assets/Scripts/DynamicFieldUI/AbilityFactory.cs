[System.Serializable]
public class AbilityFactory {
    public enum AbilityType {
        FireBall,
        FrostBolt,
        Heal,
    }
    public AbilityType Type = AbilityType.FireBall;

    public FireBall FireBall = new FireBall();
    public FrostBolt FrostBolt = new FrostBolt();
    public Heal Heal = new Heal();

    public Ability CreateAbility() {
        return GetAbilityFromType(Type);
    }

    public System.Type GetClassType(AbilityType abilityType)
    {
        return GetAbilityFromType(abilityType).GetType();
    }

    private Ability GetAbilityFromType(AbilityType type)
    {
        switch (type)
        {
            case AbilityType.FireBall:
                return FireBall;
            case AbilityType.FrostBolt:
                return FrostBolt;
            case AbilityType.Heal:
                return Heal;
            default:
                return FireBall;
        }
    }
}
