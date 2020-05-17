using System.Threading.Tasks;
using TRMDesktopUI.Library.Models;

namespace TRMDesktopUI.Library.Api
{
    public interface ISaleEnPoint
    {
        Task PostSale(SaleModel sale);
    }
}