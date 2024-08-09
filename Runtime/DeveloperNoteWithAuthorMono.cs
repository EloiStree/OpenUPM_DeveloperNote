using UnityEngine;

public class DeveloperNoteWithAuthorMono : DeveloperNoteMono
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
