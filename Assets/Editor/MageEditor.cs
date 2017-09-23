using UnityEditor;

[CustomEditor(typeof(Mage), true)]
public class MageEditor : Editor {
    protected static string ABILITY_FACTORY_NAME = "PrimarySpell";
    protected Mage mageobject;
    protected SerializedObject serializedMage;
    protected SerializedProperty SerializedAbility;
    void OnEnable() {
        mageobject = (Mage)target;
        serializedMage = new SerializedObject(mageobject);
        SerializedAbility = serializedMage.FindProperty(ABILITY_FACTORY_NAME);
    }
    public override void OnInspectorGUI()
    {
        serializedMage.Update();
        DrawPropertiesExcluding(serializedMage, new string[] { ABILITY_FACTORY_NAME });
        DrawPrimarySpell();
        serializedMage.ApplyModifiedProperties();
    }

    protected void DrawPrimarySpell()
    {
        //display ability Type
        EditorGUILayout.LabelField(ABILITY_FACTORY_NAME, EditorStyles.boldLabel);
        EditorGUILayout.PropertyField(SerializedAbility.FindPropertyRelative("Type"));

        //display relevant ability properties based on ability type
        AbilityFactory abilityFactory = mageobject.PrimarySpell;
        System.Type typeOfAbility = abilityFactory.GetClassType(abilityFactory.Type);
        SerializedProperty specificAbility = (SerializedAbility.FindPropertyRelative(typeOfAbility.ToString())).Copy();
        string parentPath = specificAbility.propertyPath;
        while (specificAbility.NextVisible(true) && specificAbility.propertyPath.StartsWith(parentPath))
        {
            EditorGUILayout.PropertyField(specificAbility);
        }
    }
}
