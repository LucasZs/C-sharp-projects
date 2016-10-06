using System.Collections;

namespace ShopManager
{
    public interface IShop
    {
        IEnumerator GetWares();
        string GetName();
        string GetAddress();
        string GetOwner();
        void Closes();
    }
}
