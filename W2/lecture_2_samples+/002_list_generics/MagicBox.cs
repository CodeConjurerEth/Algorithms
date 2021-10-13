/**
 * My own MagicBox generic class woohoo! I can store and retrieve specific types of items in it ;).
 * No idea when or why I would use this, but this is the simplest custom generics example I could come up with.
 * 
 * For more advanced options see:
  * https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/generics/constraints-on-type-parameters
 */
class MagicBox<T>
{
	private T _item;

	public void StoreItem(T pItem)
	{
		_item = pItem;
	}

	public T RetrieveItem()
	{
		return _item;
	}
}
