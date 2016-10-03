using System.Collections;

namespace ShopManager
{
    interface IShop
    {
        IEnumerator GetWares();
        string GetName();
        string GetAddress();
        string GetOwner();
    }
}
