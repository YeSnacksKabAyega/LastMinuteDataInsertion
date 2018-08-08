using Models.LastMinute;
using System.Collections.Generic;

namespace Services.LastMinute
{
    public interface IServices
    {
        BaseJsonResponse SaveSearch(List<Search> searchList);
    }
}
