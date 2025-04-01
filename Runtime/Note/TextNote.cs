using UnityEngine;


namespace Eloi.Note
{
    [System.Serializable]
    public class TextNote : I_HasTextNote
    {

        [TextArea(2,5)]
        [SerializeField]
        string m_textNote;

        public void GetNote(out string note)
        {
            note = m_textNote;
        }

        public string GetNote()
        {
            GetNote(out string note);
            return note;
        }

        public void SetNote(string note)
        {
            m_textNote = note;
        }
    }

}