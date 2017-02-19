using quotingDojo.Models;
using System.Collections.Generic;
namespace quotingDojo.Factory{
    public interface IFactory<T> where T : BaseEntity{
    }
}