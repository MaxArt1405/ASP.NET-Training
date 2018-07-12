
namespace JaggedArray
{
    public interface IComparer<T>
    {
        int Compare(T[] FirstItem, T[] SecondItem);
    }
}
