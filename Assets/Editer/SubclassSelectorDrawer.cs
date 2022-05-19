#if UNITY_2019_3_OR_NEWER
using System;
using System.Reflection;
using System.Linq;
using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(SubclassSelectorAttribute))]
public class SubclassSelectorDrawer : PropertyDrawer
{
    bool initialized = false;
    Type[] inheritedTypes;
    string[] typePopupNameArray;
    string[] typeFullNameArray;
    int currentTypeIndex;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType != SerializedPropertyType.ManagedReference) return;
        if (!initialized)
        {
            Initialize(property);
            initialized = true;
        }
        GetCurrentTypeIndex(property.managedReferenceFullTypename);
        int selectedTypeIndex = EditorGUI.Popup(GetPopupPosition(position), currentTypeIndex, typePopupNameArray);
        UpdatePropertyToSelectedTypeIndex(property, selectedTypeIndex);
        EditorGUI.PropertyField(position, property, label, true);
    }

    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return EditorGUI.GetPropertyHeight(property, true);
    }

    private void Initialize(SerializedProperty property)
    {
        SubclassSelectorAttribute utility = (SubclassSelectorAttribute)attribute;
        GetAllInheritedTypes(GetFieldType(property), utility.IsIncludeMono());
        GetInheritedTypeNameArrays();
    }

    private void GetCurrentTypeIndex(string typeFullName)
    {
        currentTypeIndex = Array.IndexOf(typeFullNameArray, typeFullName);
    }

    private void GetAllInheritedTypes(Type baseType, bool includeMono)
    {
        Type monoType = typeof(MonoBehaviour);
        inheritedTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => baseType.IsAssignableFrom(p) && p.IsClass && (!monoType.IsAssignableFrom(p) || includeMono))
            .Prepend(null)
            .ToArray();
    }

    private void GetInheritedTypeNameArrays()
    {
        typePopupNameArray = inheritedTypes.Select(type => type == null ? "<null>" : type.ToString()).ToArray();
        typeFullNameArray = inheritedTypes.Select(type => type == null ? "" : string.Format("{0} {1}", type.Assembly.ToString().Split(',')[0], type.FullName)).ToArray();
    }

    public static Type GetFieldType(SerializedProperty property)
    {
        const BindingFlags bindingAttr =
                BindingFlags.NonPublic |
                BindingFlags.Public |
                BindingFlags.FlattenHierarchy |
                BindingFlags.Instance
            ;

        var propertyPaths = property.propertyPath.Split('.');
        var fieldType = property.serializedObject.targetObject.GetType();
        for (int i = 0; i < propertyPaths.Length; i++)
        {
            FieldInfo field = fieldType.GetField(propertyPaths[i], bindingAttr);
            // ”z—ñ‘Î‰ž
            if (propertyPaths[i].Contains("Array"))
            {
                // ”z—ñ‚Ìê‡
                if (fieldType.IsArray)
                {
                    // GetElementType ‚Å—v‘f‚ÌŒ^‚ðŽæ“¾‚·‚é
                    fieldType = fieldType.GetElementType();
                }
                // ƒŠƒXƒg‚Ìê‡
                else
                {
                    // GetGenericArguments ‚Å—v‘f‚ÌŒ^‚ðŽæ“¾‚·‚é
                    var genericArguments = fieldType.GetGenericArguments();
                    if (genericArguments.Count() == 0) continue;
                    fieldType = genericArguments[0];
                }

                //data[0]‚ð•]‰¿‚µ‚És‚­‚Ì‚ÅA‚Æ‚Î‚·B
                ++i;
                continue;
            }

            if (field != null)
            {
                //else
                fieldType = field.FieldType;
            }
        }

        return fieldType;
    }

    private void UpdatePropertyToSelectedTypeIndex(SerializedProperty property, int selectedTypeIndex)
    {
        if (currentTypeIndex == selectedTypeIndex) return;
        currentTypeIndex = selectedTypeIndex;
        Type selectedType = inheritedTypes[selectedTypeIndex];
        property.managedReferenceValue =
            selectedType == null ? null : Activator.CreateInstance(selectedType);
    }

    private Rect GetPopupPosition(Rect currentPosition)
    {
        Rect popupPosition = new Rect(currentPosition);
        popupPosition.width -= EditorGUIUtility.labelWidth;
        popupPosition.x += EditorGUIUtility.labelWidth;
        popupPosition.height = EditorGUIUtility.singleLineHeight;
        return popupPosition;
    }
}
#endif