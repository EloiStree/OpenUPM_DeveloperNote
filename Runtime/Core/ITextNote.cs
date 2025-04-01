namespace Eloi.Note
{
    public interface ITextNote
    {
        void GetNote(out string note);
        void SetNote(string note);
    }
}