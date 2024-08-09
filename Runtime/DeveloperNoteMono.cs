using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class DeveloperNoteObjectMono : MonoBehaviour { }
public abstract class DeveloperNoteCreditedMono : DeveloperNoteObjectMono
{
    [Tooltip("Who wrote the developer note")]
    public string m_authorOfTheNote;
    protected virtual void OnValidate()
    {
#if UNITY_EDITOR
        UnityEditor.EditorPrefs.SetString("CurrentDev", m_authorOfTheNote);
#endif
    }

    private void Reset()
    {
#if UNITY_EDITOR
        m_authorOfTheNote = UnityEditor.EditorPrefs.GetString("CurrentDev", "");
#endif
    }
}


public class DeveloperNoteMono : DeveloperNoteObjectMono
{
    [Tooltip("Just a note of the developer")]
    [TextArea(2, 10)]
    public string m_developerNote;

}
