
using UnityEngine;

namespace Eloi.Note
{
    [System.Serializable]
    public class TextAssetNote : I_HasTextNoteGet
    {

        public TextAsset m_textNote;

        public void GetNote(out string note)
        {
            try
            {
                if (m_textNote == null)
                    note = "";
                note = m_textNote.text;
            }
            catch (System.Exception e)
            {
                note = "";
            }
        }
        public string GetNote()
        {
            GetNote(out string note);
            return note;
        }
    }
}