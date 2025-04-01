using UnityEngine;


namespace Eloi.Note
{
    [System.Serializable]
public class AuthorOfNote: I_HasAuthorName
{
        [SerializeField] string m_authorName;

        public void GetAuthor(out string author)
        {
            author = m_authorName;
        }
        public string GetAuthor()
        {
            return m_authorName;
        }

        public void SetAuthor(string author)
        {
            m_authorName = author;
        }
    }

}